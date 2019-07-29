using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step165TryCatchExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("How old are you?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer)
                    {
                        Console.WriteLine("Please enter your age using only numbers.");
                        validAnswer = int.TryParse(Console.ReadLine(), out age);
                    }
                }
                if (age < 1)
                {
                    throw new AgeException();
                }
                int nowYear = DateTime.Now.Year;
                int userYearBorn = nowYear - age;

                Console.WriteLine("You were born in the year: " + userYearBorn);
                Console.ReadLine();
            }
            catch (AgeException)
            {
                Console.WriteLine("You've listed an age less than a year old, how are you even using a computer?");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your System Admin.");
                Console.ReadLine();
                return;
            }
        }
    }
}
