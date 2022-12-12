using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translite
{
    public class Logic
    {

        public string a;
        public string b;
        public Logic(string a, string b)
        {
            this.a = a;

            this.b = b;
            if (a.StartsWith("Eng"))
            {
                    
                foreach (var item in Ukr[b])
                {
                    Console.Write(item);
                }
            }
            if (a.StartsWith("Ukr"))
            {
                    Console.WriteLine("Виберіть слово для перекладу|Привіт|,|Допобачення|");
                foreach (var item in Eng[b])
                {
                    Console.Write(item);

                }
            }
        }



        public static Dictionary<string, string> Ukr = new Dictionary<string, string>()
        {
            ["Helow"] = "Привіт",
            ["Goodbye"] = "Допобачення"

        };

        public static Dictionary<string, string> Eng = new Dictionary<string, string>()
        {

            ["Привіт"] = "Helow",
            ["Допобачення"] = "Goodbye"
        };


    }


}
