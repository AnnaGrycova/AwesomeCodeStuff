using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Anagram
{
    class Anagram
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }

        public Anagram (string text1, string text2)
        {
            Text1 = text1;
            Text2 = text2;
        }

        public bool Check()
        {
            var text1 = String.Concat(Text1.Where(c => !Char.IsWhiteSpace(c)));
            var text2 = String.Concat(Text2.Where(c => !Char.IsWhiteSpace(c)));
            if (text1.Length != text2.Length)
            {
                return false;
            }
            //c => c .... identicka anonymni funkce, ktera nic nedela, jen to OrderBy potrebuje funkci
            //LINQ
            text1 = String.Concat(text1.ToLower().OrderBy(c => c));
            text2 = String.Concat(text2.ToLower().OrderBy(c => c));

            return text1 == text2;
        }
    }
}
