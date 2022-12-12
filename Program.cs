using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translite;

Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("Виберіть мову на яку перекладати |Ukr| або |Eng|");
string a = Console.ReadLine();

if (a.StartsWith("Eng")) Console.WriteLine("Виберіть слово для перекладу|Helow|,|Goodbye|");
if (a.StartsWith("Ukr")) Console.WriteLine("Виберіть слово для перекладу|Привіт|,|Допобачення|");
    string b = Console.ReadLine();
Logic logic = new Logic(a, b);






