using ConsoleApp2.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BI
{
    public class BiPerson
    {
        public static List<string> CheckedData(Dto PersonParameter)
        {
            List<string> ChecksList = new();
                if (PersonParameter.Name.Length <= 2)
                ChecksList.Add("Ingrese un nombre valido");

            if (PersonParameter.FatherLastName.Length <= 2)
                ChecksList.Add("Ingrese un nombre valido");

            if (PersonParameter.MotherLastName.Length <= 2)
                ChecksList.Add("Ingrese un nombre valido");

            if (VerifyText(PersonParameter.Name))
                ChecksList.Add("Nombre invalido");

            if (VerifyText(PersonParameter.FatherLastName))
                ChecksList.Add("Nombre invalido");

            if (VerifyText(PersonParameter.MotherLastName))
                ChecksList.Add("Nombre invalido");

            return ChecksList;
        }

        private static bool VerifyText(string text)
        {
            bool Check = false;
            foreach(char letter in text.Replace(" ", ""))
            {
                if (!char.IsLetter(letter))
                {
                    Check = true;
                    break;
                }
            }    
            return Check;
            }
        }

    }

