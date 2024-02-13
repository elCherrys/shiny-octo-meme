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
                ChecksList.Add("Muy pocas letras para un nombre ಠ_ಠ");

            if (PersonParameter.FatherLastName.Length <= 2)
                ChecksList.Add("Nombre demasiado corto 3=/");

            if (PersonParameter.MotherLastName.Length <= 2)
                ChecksList.Add("Tu apellido materno no puede ser tan corto -.-");

            if (VerifyText(PersonParameter.Name))
                ChecksList.Add("Los nombres no llevan simbolos ni numeros!");

            if (VerifyText(PersonParameter.FatherLastName))
                ChecksList.Add("Los apellidos paternos no llevan simbolos ni numeros!");

            if (VerifyText(PersonParameter.MotherLastName))
                ChecksList.Add("Los apellidos maternos no llevan simbolos ni numeros!");

            if (VerifyAge(PersonParameter.Age))
                ChecksList.Add("Edad Invalida");


            return ChecksList;
        }

        private static bool VerifyText(string text)
        {
            bool Check = false;
            foreach (char letter in text.Replace(" ", ""))
            {
                if (!char.IsLetter(letter))
                {
                    Check = true;
                    break;
                }
            }
            return Check;
        }


        private static bool VerifyAge(string text)
        {
            bool CheckAge = false;
            foreach (char letter in text)
            {
                if (!char.IsDigit(letter))
                {
                    CheckAge = true;
                    break;
                }
            }
            return CheckAge;
        }

    }
}

