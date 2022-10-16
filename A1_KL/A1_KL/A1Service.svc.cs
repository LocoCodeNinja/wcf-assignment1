using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
    }
}
