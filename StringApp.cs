using System;

namespace LibraryAPI
{
    public class StringApp
    {
        /// <summary>
        /// Numbers to string.
        /// Ex: 1->a, 2->b
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="isCaps">if set to <c>true</c> [is caps].</param>
        /// <returns></returns>
        public string NumberToString(int number, bool isCaps)
        {
            char c = (char)((isCaps ? 65 : 97) + (number - 1));
            return c.ToString();
        }
        public string NumberToExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = string.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (dividend - modulo) / 26;
            }

            return columnName;
        }
    }
}
