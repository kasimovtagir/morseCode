using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseApp
{
    class Encrypt
    {
        public void encrypt(ref string messEncrypt)
        {
            string morseMessEncrypt = " ";
            for (int i = 0; i < messEncrypt.Length; i++)
            {
                switch (messEncrypt[i].ToString().ToLower())
                {
                    case " ":
                        morseMessEncrypt += "-...- ";
                        break;

                    case ".":
                        morseMessEncrypt += "...... ";
                        break;

                    case ",":
                        morseMessEncrypt += ".-.-.- ";
                        break;

                    case "-":
                        morseMessEncrypt += "-....- ";
                        break;

                    case "а":
                        morseMessEncrypt += ".- ";
                        break;

                    case "б":
                        morseMessEncrypt += "-... ";
                        break;

                    case "в":
                        morseMessEncrypt += ".-- ";
                        break;

                    case "г":
                        morseMessEncrypt += "--. ";
                        break;

                    case "д":
                        morseMessEncrypt += "-.. ";
                        break;

                    case "е": //он же ё
                        morseMessEncrypt += ". ";
                        break;

                    case "ж":
                        morseMessEncrypt += "...- ";
                        break;

                    case "з":
                        morseMessEncrypt += "--.. ";
                        break;

                    case "и":
                        morseMessEncrypt += ".. ";
                        break;

                    case "й":
                        morseMessEncrypt += ".--- ";
                        break;

                    case "к":
                        morseMessEncrypt += "-.- ";
                        break;

                    case "л":
                        morseMessEncrypt += ".-.. ";
                        break;

                    case "м":
                        morseMessEncrypt += "-- ";
                        break;

                    case "н":
                        morseMessEncrypt += "-. ";
                        break;

                    case "о":
                        morseMessEncrypt += "--- ";
                        break;

                    case "п":
                        morseMessEncrypt += ".--. ";
                        break;

                    case "р":
                        morseMessEncrypt += ".-. ";
                        break;

                    case "с":
                        morseMessEncrypt += "... ";
                        break;

                    case "т":
                        morseMessEncrypt += "- ";
                        break;

                    case "у":
                        morseMessEncrypt += "..- ";
                        break;

                    case "ф":
                        morseMessEncrypt += "..-. ";
                        break;

                    case "х":
                        morseMessEncrypt += ".... ";
                        break;

                    case "ц":
                        morseMessEncrypt += "-.-. ";
                        break;

                    case "ч":
                        morseMessEncrypt += "---. ";
                        break;

                    case "ш":
                        morseMessEncrypt += "---- ";
                        break;

                    case "щ":
                        morseMessEncrypt += "--.- ";
                        break;

                    case "ъ":
                        morseMessEncrypt += "--.-- ";
                        break;

                    case "ы":
                        morseMessEncrypt += "-.-- ";
                        break;

                    case "ь": // он же Ъ
                        morseMessEncrypt += "-..- ";
                        break;

                    case "э":
                        morseMessEncrypt += "..-.. ";
                        break;

                    case "ю":
                        morseMessEncrypt += "..-- ";
                        break;

                    case "я":
                        morseMessEncrypt += ".-.- ";
                        break;

                    /*default:
                        Console.WriteLine("Вы написали что-то плохое\nЯ обиделся\nПОКА");
                        break;*/

                }

            }
            messEncrypt = morseMessEncrypt.Trim();
            //Console.WriteLine(morseMessEncrypt.Trim());
        }
    }
}