using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////declaring an array without initializing
            //int[] myFirstArray;
            ////declaring and initializing a second array
            //string[] myStringArray = { "First", "second", "third", "fourth" };
            ////declare and initialize a char array with the letters of your last name - single quotes for char
            //char[] myLastName = { 's', 'e', 'e', 'l' };
            ////I want my console to print three elements of my array using index position
            //Console.WriteLine(myLastName[0]);
            //Console.WriteLine(myLastName[3]);
            //Console.WriteLine(myLastName[1]);
            ////create the following arrays and print using the correct index numbers:
            ////Array of Top 10 Vacaction spots;
            ////print the first and last vacation spots
            ////say string array instead of string brackets
            //string[] VacationSpots = { "Paris", "Melbourne", "Sidney", "Orlando", "Vegas", "NY", "Nashville", "Hinton", "Cleveland", "NC" };
            //Console.WriteLine(VacationSpots[0]);
            //Console.WriteLine(VacationSpots[9]);
            ////Array of the ages of 3 children you know
            ////print each child's age
            ////concatenation adds ages together instead of reading as string
            //int[] myChildAge = { 5, 16, 6 };
            //Console.WriteLine(myChildAge[0]);
            //Console.WriteLine(myChildAge[1]);
            //Console.WriteLine(myChildAge[2]);
            ////Array of GPA's on a 4.0 of scale of 8 students - you don't have to print
            ////double[] myGPA = ["2.56", "3.70", "2.91", "1.75", "4.00", "2.25", "1.50", "3.42"];
            ////Array of the first letter of 4 of your classmate's names sitting near you
            ////print all four on the same line
            ////Console.WriteLine(myClassmateName); this only works for char, not strings, etc.
            //char[] myClassmateName = { 'd', 'j', 't', 'j' };
            //Console.Write(myClassmateName[0]);
            //Console.Write(myClassmateName[1]);
            //Console.Write(myClassmateName[2]);
            //Console.Write(myClassmateName[3]);
            //Console.WriteLine("");
            //Console.WriteLine(myClassmateName);
            //Console.WriteLine("");
            //Console.WriteLine(myClassmateName[0] + " " + myClassmateName[1] + " " + myClassmateName[2] + " " + myClassmateName[3]);
            //Console.WriteLine("{0},{1},{2},{3}", myClassmateName[0], myClassmateName[1], myClassmateName[2], myClassmateName[3]);
            //loops are best way to print an array --- getting to this on Thursday 7.6.2017


            //new keyword = new datatype must be the same datatype as the original
            //datatype[ nameOfArray = new dataType[#ofElements};
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21]; //creating a dresser with 21 drawers, not a value of 21 so string ok

            ////nameOfArray[index] = Element;
            //studentsInClass[0] = "Jordan";
            ////allow user to enter the next student
            //Console.WriteLine("Please enter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            ////to check it was done correctly
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);
            ////get age of each student
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////create a new int array with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21]; 
            ////Assign the value of the int at the 0 index of ageOfStudentsInClass to...
            ////...the users's input converted into an int
            ////console.readline takes info in as string, int.parse converts from string to int
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]);
            ////Create a new string variable and set it equal to the int at the index of 0...
            ////and convert it into string
            ////converts int to string -- To.String method builds strings
            //string firstIndex = ageOfStudentsInClass[0].ToString();

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            ////like how many characters in string = 5
            //Console.WriteLine(restaurantsInMall.Length);

            ////for review
            ////declare and not initialize
            //int[] myIntArrayAgain;
            ////declare and initialize an array when I know the elements
            //char[] lettersInFirstName = { 'D', 'a', 'n', 'i', 'e', 'l' };
            ////declare and initialize an array when I don't know the elements, only how many elements there will be
            //string[] variableName = new string[42];

            //to practice using .Length, create a char array of the letters in your middle name
            //print the number of char's to the console
            //char[] lettersInMiddleName = { 'L', 'y', 'n', 'n' };
            //Console.WriteLine(lettersInMiddleName.Length);

            //declare and initialize a string array
            //using the length property, print the second to last element in the array
            //string[] favCar = { "'65 Stingray", "'04 Eclipse", "'11 Caliber" };
            //int numCars = favCar.Length;
            ////looking for the index of 1
            ////Console.WriteLine(favCar[1]);
            //Console.WriteLine(favCar[numCars-2]);
            ////or without setting new int variable
            //Console.WriteLine(favCar[favCar.Length - 2]);

            //indexOf is a method used to search an array for a specified value and returns
            //the index position of the first matching value found
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            ////capital Array is an object, like String, Console, etc.
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////run it = 0, first instance of 1985 is at index 0

            ////LastIndexOf is a method used to search an array for a specified value and returns
            ////the index position of the last matching value found, reading right to left
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));
            ////run it = 4

            //reverse method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);






            




        }
    }
}
