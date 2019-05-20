using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseApp
{
    class Decrypt
    {
        public void decrypt(ref string messDecrypt)
        {
            string morseMessDecrypt = " ";
            string[] morseArrayDecrypt;
            char[] separator = { ' ' };
            morseArrayDecrypt = messDecrypt.Split(separator);

            /* foreach (var item in morseArrayDecrypt)
             {
                 Console.WriteLine(item);
             }*/

            for (int i = 0; i < morseArrayDecrypt.Length; i++)
            {
                string morse = morseArrayDecrypt[i].ToString().ToLower();
                switch (morse)
                {
                    case "-...-":
                        morseMessDecrypt += "  ";
                        break;

                    case "......":
                        morseMessDecrypt += ". ";
                        break;

                    case ".-.-.-":
                        morseMessDecrypt += ", ";
                        break;

                    case "-....-":
                        morseMessDecrypt += "- ";
                        break;

                    case ".-":
                        morseMessDecrypt += "а ";
                        break;

                    case "-...":
                        morseMessDecrypt += "б ";
                        break;


                    case ".--":
                        morseMessDecrypt += "в ";
                        break;

                    case "--.":
                        morseMessDecrypt += "г ";
                        break;

                    case "-..":
                        morseMessDecrypt += "д ";
                        break;

                    case ".": //он же ё
                        morseMessDecrypt += "е ";
                        break;

                    case "...-":
                        morseMessDecrypt += "ж ";
                        break;

                    case "--..":
                        morseMessDecrypt += "з ";
                        break;

                    case "..":
                        morseMessDecrypt += "и ";
                        break;

                    case ".---":
                        morseMessDecrypt += "й ";
                        break;

                    case "-.-":
                        morseMessDecrypt += "к ";
                        break;

                    case ".-..":
                        morseMessDecrypt += "л ";
                        break;

                    case "--":
                        morseMessDecrypt += "м ";
                        break;

                    case "-.":
                        morseMessDecrypt += "н ";
                        break;

                    case "---":
                        morseMessDecrypt += "о ";
                        break;

                    case ".--.":
                        morseMessDecrypt += "п ";
                        break;

                    case ".-.":
                        morseMessDecrypt += "р ";
                        break;

                    case "...":
                        morseMessDecrypt += "с ";
                        break;

                    case "-":
                        morseMessDecrypt += "т ";
                        break;

                    case "..-":
                        morseMessDecrypt += "у ";
                        break;

                    case "..-.":
                        morseMessDecrypt += "ф ";
                        break;

                    case "....":
                        morseMessDecrypt += "х ";
                        break;

                    case "-.-.":
                        morseMessDecrypt += "ц ";
                        break;

                    case "---.":
                        morseMessDecrypt += "ч ";
                        break;

                    case "----":
                        morseMessDecrypt += "ш ";
                        break;

                    case "--.-":
                        morseMessDecrypt += "щ ";
                        break;

                    case "--.--":
                        morseMessDecrypt += "ъ ";
                        break;

                    case "-.--":
                        morseMessDecrypt += "ы ";
                        break;

                    case "-..-": // он же Ъ
                        morseMessDecrypt += "ь ";
                        break;

                    case "..-..":
                        morseMessDecrypt += "э ";
                        break;

                    case "..--":
                        morseMessDecrypt += "ю ";
                        break;

                    case ".-.-":
                        morseMessDecrypt += "я ";
                        break;

                   /* default:
                        Console.WriteLine("Вы написали что-то плохое\nЯ обиделся\nПОКА");
                        Console.ReadKey();
                        break;*/
                }
            }
            messDecrypt = morseMessDecrypt.Trim();
            //Console.WriteLine(morseMessDecrypt.Trim());
        }
    }
}