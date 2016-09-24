using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                int letterCount = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    char altLetter = array[i];

                    if (char.IsLetter(altLetter))
                    {
                        if (letterCount % 2 == 0)
                        {
                            array[i] = char.ToUpper(altLetter);
                        }
                        else
                        {
                            array[i] = char.ToLower(altLetter);
                        }
                        letterCount++;
                    }
                }

                string result = new string(array);

                Console.WriteLine(result);
            }

            hamlet.Close();
        }
    }
}
