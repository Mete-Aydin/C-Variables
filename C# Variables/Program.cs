using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Im Learning  Variables!

            // To Creat a variable, i need to specify the type and assign it a Value: type variableName = value;

            //Added Variables
            string firstName = "Mete";
            string lastName = "Aydin";
            //Output  
            Console.WriteLine("Hello My Firstname is = {0} and my Lastname = {1}.",firstName ,lastName );




            //Added Variables
            string firstName1= "Mete";
            string lastName1= "Aydin";

            // Added Nickname
            string nickname = "The Coder";

            // Output the text
            Console.WriteLine("Hello! My Firstname is = {0}, my Lastname is = {1}, and people call me = {2}.", firstName, lastName, nickname);


            // Added a Integer 
            int myNum;
            myNum = 29;

            Console.WriteLine("Hello! My Firstname is = {0}, my Lastname is = {1}, and people call me = {2} and im {3} Years Old .", firstName, lastName, nickname, myNum);




        }
    }
}
