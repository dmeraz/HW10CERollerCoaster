using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Text.RegularExpressions;

namespace HW10CERollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader hamlet = new StreamReader("..\\..\\..\\Hamlet.txt");
            string line = hamlet.ReadLine();

            while (line != null)
            {
                char[] array = line.ToCharArray(); 
                line = hamlet.ReadLine();

                for (int i = 0; i < array.Length; i++)
                {
                    char altLetter = array[i];

                    //If () attempts
                    //Regex.IsMatch(line, "^[a-z, A-Z]+$");
                    //Regex.IsMatch(line, "\\D")
                    //array[i] >= 'a' && array[i] <= 'z' || array[i] >= 'A' && array[i] <= 'Z'
                    ////char.IsLetter(altLetter) && char.IsLower(altLetter)

                    if (char.IsLetter(altLetter))
                    {
                        array[i] = char.ToUpper(altLetter);
                        i++;
                    }
                }

                string result = new string(array);

                Console.WriteLine(result);
            }

            hamlet.Close();
        }
    }
}
