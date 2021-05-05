using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4317_DJR.Lib;

namespace Kpo4317_DJR.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            txtboxLogPath.Text = AppGlobalSettings.LogPath;
            txtboxDataFileName.Text = AppGlobalSettings.DataFileName;
        }

        private BindingSource bsSemiConductors = new BindingSource();

        private void LoadingRow(int currentStatus)
        {
            //ListLoadingProgressBar.Value = currentStatus;
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                mnOpen.Enabled = false;
                mnOpenSemiconductor.Enabled = false;

                ISemiconductorListLoader loader = CastleWindsorContainer.container.Resolve<ISemiconductorListLoader>(AppGlobalSettings.ImportSetting);
                loader.LoadingRow = LoadingRow;
                await Task.Run(() => loader.Execute());
                ListLoadingProgressBar.Value = ListLoadingProgressBar.Maximum;
                bsSemiConductors.DataSource = loader.semiconductorList;
                dgvSemiConductors.DataSource = bsSemiConductors;

                mnOpen.Enabled = true;
                mnOpenSemiconductor.Enabled = true;
            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog("Ошибка №1: " + ex.Message);

            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex);
            }
        }

        private void mnOpenSemiconductor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSemiConductor frmSemiConductor = new FrmSemiConductor();

                SemiConductor semiconductor = (bsSemiConductors.Current as SemiConductor);
                frmSemiConductor.SetSemiconductor(semiconductor);

                frmSemiConductor.ShowDialog();
            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog("Ошибка №1: " + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }
    }
}
