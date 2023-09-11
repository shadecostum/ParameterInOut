using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterInOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1=10;
            int number2=25;
            //reference value initialization neccesary,But here out not neccesary
            int sum;//asume addres 1000
            float product;//asume addres 1004

            //using OUT parameter
            Console.WriteLine("---OUT parameter---");
            SumProduct(number1,number2,out sum,out product);
            Console.WriteLine(sum);// addres 1000 same
            Console.WriteLine(product);// addres 1004 same
            Console.WriteLine("------end-------");





            Console.WriteLine("---Reference parameter---");
            //refrence key used ref
            int number3 = 10;
            Console.WriteLine("Befor function calling "+number3);
            incrementReference(ref number3);
            Console.WriteLine("After function called " + number3);
            Console.WriteLine("------end-------");



            Console.WriteLine("---IN parameter---");
            //in and out combined
            //read only cannot modify
            int number4 = 10;
            int number5 = 20;
            int resultInOut;
            bool b= functionInOut(in number4, in number5, out resultInOut);
            Console.WriteLine( b ? "Number Less than 50": "Number Greater than 50");
            Console.WriteLine("------end-------");


        }

     
        private static bool functionInOut(in int number4, in int number5, out int resultInOut)
        {
           // number4++; ReadOnly
            Console.WriteLine(""+number4);
            resultInOut =number4 + number5;
            Console.WriteLine("" + resultInOut);
            if (resultInOut < 50)
            {
                return true;
            }
            else { return false; }
        }

        private static void incrementReference(ref int number3)
        {
            //number3++;
            number3 = 5;
            //it automaticaly number3 addres value changed main function
            Console.WriteLine("inside function  " + number3);
        }


        static void SumProduct(int value1,int value2,out int sumed,out float producted)
        {
           
            sumed =value1 + value2;// addres 1000 same
            producted =value1 * value2;// addres 1004 same

           // Console.WriteLine(sumed + "," + producted);//only sumed and producted value recived after calculation 
        }



        //params mainly used it helps you to create dynamic input parameters
        //a single method can accept more variables to calculate
       

       
    }
}
