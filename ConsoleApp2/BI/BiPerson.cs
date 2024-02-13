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

            if (CheckedData(PersonParameter.Name))
                ChecksList.Add("Nombre invalido");

            if (CheckedData(PersonParameter.FatherLastName))
                ChecksList.Add("Nombre invalido");

            if (CheckedData(PersonParameter.MotherLastName))
                ChecksList.Add("Nombre invalido");

            return ChecksList;
        }

        private static bool VerfifyText(string text)
        {
            bool Check = false;
            foreach(char letter in text.Replace(" ", ""))
            {
                if (char.IsLetter(letter))
                {
                    Check = true;
                    break;
                }
            }    
            return Check;
            }
        }

    }
}
