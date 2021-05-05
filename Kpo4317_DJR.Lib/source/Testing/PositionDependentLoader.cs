using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4317_DJR.Lib
{
    public class PositionDependentLoader
    {
        public static int[] fieldsLength = { 14, 6, 4, 4 };

        ///*summary*
        ///Метод класса считывает строку данных в позиционно-зависимом формате
        ///
        public SemiConductor ObjectFromString(string originalString)
        {
            ///     создать объект-полупроводник
            SemiConductor semiconductor = new SemiConductor();
            ///     создать массив полей объекта, прочитанных из строки
            string[] fields = new string[4];
            ///     создать переменную-счётчик пройденных символов в строке
            int currentSymbol = 0;
            ///     пройтись по массиву размеров полей
            for (int i = 0; i < fieldsLength.Length; i++)
            {
                ///         пройти определённое количество элементов в строке (количество из массива размеров)
                for (int j = 0; j < fieldsLength[i]; j++)
                {
                    ///             добавить текущий элемент к строке текущего поля
                    fields[i] += originalString[currentSymbol];
                    ///             увеличить счётчик прочитанных элементов
                    currentSymbol++;
                }
            }
            ///     присвоить каждому полю объекта-полупроводника значение из массива полей
            semiconductor.Substance_name = fields[0];
            semiconductor.ForbiddenZone_width = fields[1];
            semiconductor.Electron_move = fields[2];
            semiconductor.Hole_move = fields[3];
            ///     вернуть объект-полупроводник
            return semiconductor;
        }
    }
}
