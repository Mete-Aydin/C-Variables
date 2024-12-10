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

            //Added string, string stores text
            string firstName = "Mete";
            string lastName = "Aydin";
            //Output  
            Console.WriteLine("Hello My Firstname is = {0} and my Lastname = {1}.",firstName ,lastName );




            //Added string, string stores text
            string firstName1 = "Mete";
            string lastName1= "Aydin";

            // Added Nickname
            string nickname = "The Coder";

            // Output the text
            Console.WriteLine("Hello! My Firstname is = {0}, my Lastname is = {1}, and people call me = {2}.", firstName, lastName, nickname);


            // Added a Integer 
            // int Stores whole numbers!
            int myNum;
            myNum = 29;

            Console.WriteLine("Hello! My Firstname is = {0}, my Lastname is = {1}, and people call me = {2} and im {3} Years Old .", firstName, lastName, nickname, myNum);

            // Deklaration von zwei int-Variablen
            int zahl1 = 15;
            int zahl2 = 4;

            // Durchführung verschiedener Operationen
            int summe = zahl1 + zahl2;       // Addition
            int differenz = zahl1 - zahl2;   // Subtraktion
            int produkt = zahl1 * zahl2;     // Multiplikation
            int quotient = zahl1 / zahl2;    // Ganzzahldivision
            int rest = zahl1 % zahl2;        // Modulo (Rest)

            // Ausgabe der Ergebnisse
            Console.WriteLine("Die Zahlen sind: {0} und {1}", zahl1, zahl2);
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.WriteLine("Die Differenz ist: {0}", differenz);
            Console.WriteLine("Das Produkt ist: {0}", produkt);
            Console.WriteLine("Der Quotient ist: {0}", quotient);
            Console.WriteLine("Der Rest ist: {0}", rest);

            // There are many other Variables like  double char bool

            //added double
            // double stores floating point numbers, with decimals, such as 19.99 or -19.99
            double myDou = 2.0;
            // Deklaration von zwei double-Variablen
            double num1 = 5.5;
            double num2 = 3.2;

            // Durchführung verschiedener Operationen
            double sum = num1 + num2;       // Addition
            double difference = num1 - num2; // Subtraktion
            double product = num1 * num2;    // Multiplikation
            double quotient1 = num1 / num2;   // Division

            // Ausgabe der Ergebnisse
            Console.WriteLine("Die Zahlen sind: {0} und {1}", num1, num2);
            Console.WriteLine("Die Summe ist: {0}", sum);
            Console.WriteLine("Die Differenz ist: {0}", difference);
            Console.WriteLine("Das Produkt ist: {0}", product);
            Console.WriteLine("Der Quotient ist: {0}", quotient1);


            Console.WriteLine("The Double Number is : {0}",myDou);

            //added char
            // char is used for single characters
            char myLetter = 'D';

            Console.WriteLine("Hey my Letter is : {0}", myLetter);

            //added bool    
            //bool stores values with two condition -> true or false

            bool myBoolTrue = true;
            bool myBoolFalse = false;
           
            Console.WriteLine("This Outputs : {0}", myBoolTrue);
            Console.WriteLine("This Outputs : {0}", myBoolFalse);


            //Constants are used to cancel overwrite existing values.
            // In this Example its an Error because u cant Overwirte myNumber.
            const int myNumber = 10;
            //myNumber 20; // Its a Error.;









        }
    }
}
