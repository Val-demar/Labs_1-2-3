using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты фигур на шахматной доске (например, a4, e5, h7):");

            Console.Write("Координаты короля (буква): ");
            char kingColumn = Convert.ToChar(Console.ReadLine());
            Console.Write("Координаты короля (цифра): ");
            int kingRow = int.Parse(Console.ReadLine());

            Console.Write("Координаты ладьи (буква): ");
            char rookColumn = Convert.ToChar(Console.ReadLine());
            Console.Write("Координаты ладьи (цифра): ");
            int rookRow = int.Parse(Console.ReadLine());

            Console.Write("Координаты слона (буква): ");
            char bishopColumn = Convert.ToChar(Console.ReadLine());
            Console.Write("Координаты слона (цифра): ");
            int bishopRow = int.Parse(Console.ReadLine());



            bool isKingThreatenedByRook = AlarmByRook(kingColumn, kingRow, rookColumn, rookRow);
            bool isKingThreatenedByBishop = AlarmByBishop(kingColumn, kingRow, bishopColumn, bishopRow);

            if (isKingThreatenedByRook && isKingThreatenedByBishop)
            {
                Console.WriteLine("Король под угрозой ладьи и слона");
            }
            else if (isKingThreatenedByRook)
            {
                Console.WriteLine("Король под угрозой Ладьи");
            }
            else if (isKingThreatenedByBishop)
            {
                Console.WriteLine("Король под угрозой слона");
            }
            else
            {
                Console.WriteLine("Нет угрозы");
            }

            Console.ReadLine();
        }

        static bool AlarmByRook(char kingColumn, int kingRow, char rookColumn, int rookRow)
        {
            return kingColumn == rookColumn || kingRow == rookRow;
        }

        static bool AlarmByBishop(char kingColumn, int kingRow, char bishopColumn, int bishopRow)
        {
            int columnDiff = Math.Abs(kingColumn - bishopColumn);
            int rowDiff = Math.Abs(kingRow - bishopRow);

            return columnDiff == rowDiff;
        }
    }
}
    



