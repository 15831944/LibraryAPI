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
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c.ToString();
        }
    }
}
