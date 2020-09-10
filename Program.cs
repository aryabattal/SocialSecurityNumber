using System;
using System.Dynamic;
using System.IO;

namespace socialsecuritynumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string socialSecurityNumber;
            string gender;
            string generation;

            if (args.Length > 0)
            {
                firstName = args[0];
                lastName = args[1];
                socialSecurityNumber = args[2];
            }
            else
            {


                Console.Write("Please enter your firstname: ");
                firstName = Console.ReadLine();

                Console.Write("Please enter your lastname: ");
                lastName = Console.ReadLine();

                Console.Write("Please enter your Social Security Number (YYMMDD-XXXX): ");
                socialSecurityNumber = Console.ReadLine();
            }





            int genderNumber = int.Parse(socialSecurityNumber.Substring(socialSecurityNumber.Length - 2, 1));

            bool isFemale = genderNumber % 2 == 0;

            gender = isFemale ? "Female" : "Male";

            DateTime birthDate = DateTime.ParseExact(socialSecurityNumber.Substring(0, 6), "yyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;

            if ((birthDate.Month > DateTime.Now.Month) || (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
            {
                age--;


            }

            if (1883 <= birthDate.Year && 1900 >= birthDate.Year)
            {

                generation = "The Lost Generation";
            }

            else if (1901 <= birthDate.Year && 1927 >= birthDate.Year)
            {
                generation = "The Greatest";
            }

            else if (1928 <= birthDate.Year && 1945 >= birthDate.Year)
            {
                generation = "The Silent Generation";
            }

            else if (1946 <= birthDate.Year && 1964 >= birthDate.Year)
            {
                generation = "The Baby Boomers";
            }

            else if (1965 <= birthDate.Year && 1980 >= birthDate.Year)
            {
                generation = "The Generation X";
            }

            else if (1981 <= birthDate.Year && 1996 >= birthDate.Year)
            {
                generation = "The Millennials";
            }

            else if (1997 <= birthDate.Year && 2012 >= birthDate.Year)
            {
                generation = "The Zoomers";
            }

            else if (2013 <= birthDate.Year && 2025 >= birthDate.Year)
            {
                generation = "The Generation Alpha";
            }

            else
            {
                generation = "Unknown generation";
            }


            Console.Clear();

            Console.WriteLine(@$"
         Name:                      { firstName }{lastName}
         Social security number:    { socialSecurityNumber }
         Gender:                    { gender }
         Age:                       { age }
         generation:                { generation}");


        }

    }
}

