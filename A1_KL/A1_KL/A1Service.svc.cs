using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI;

namespace A1_KL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IA1Service
    {
        public bool IsInt(string userInput)
        {
            if (int.TryParse(userInput, out int value))
            {
                return true;
            }
            return false;
        }

        public string PrimeNumber(int userInput)
        {
            string isPrime = userInput + " is a PRIME NUMBER!";
            string isNotPrime = userInput + " is NOT a PRIME NUMBER!";
            if (userInput <= 1)
            {
                //not a prime
                return isNotPrime;
            }
            if (userInput == 2)
            {
                //is prime
                return isPrime;
            }
            if (userInput % 2 == 0)
            {
                //is not
                return isNotPrime;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(userInput));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (userInput % i == 0)
                {
                    //is not
                    return isNotPrime;
                }
            }

            //else is prime
            return isPrime;
        }

        public string ReverseString(string n1)
        {
            char[] charArray = n1.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string SumOfDigits(string n1)
        {
            int value = Int32.Parse(n1);
            int sum = 0;
            string result;

            while(value != 0)
            {
                sum += value % 10;
                value /= 10;
            }

            result = "The sum of " + n1 + " is " + sum;
            return result;

        }

        public string TagHTML(string n1, string n2)
        {
            string result = "<" + n1 + ">" + n2 + "<" + n1 + ">";
            return result;
        }

        public string OrderNumbers(string n1, string n2, string n3, string n4, string n5, string n6)
        {
            int no1 = Int32.Parse(n1);
            int no2 = Int32.Parse(n2);
            int no3 = Int32.Parse(n3);
            int no4 = Int32.Parse(n4);
            int no5 = Int32.Parse(n5);
            int[] intArray = new int[5] { no1, no2, no3, no4, no5 };
            string result = "";

            if (n6 == "1")
            {
                Array.Sort(intArray);              
                result = string.Join(", ", intArray);
            }
            if (n6 == "2")
            {
                Array.Sort(intArray);
                Array.Reverse(intArray);
                result = string.Join(", ", intArray);
            }
            return result;
            

        }
    }
}
