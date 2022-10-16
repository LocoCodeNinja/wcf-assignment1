using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace A1_KL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IA1Service
    {
        [OperationContract]
        bool IsInt(string n1);
        [OperationContract]
        string PrimeNumber(int n1);
        [OperationContract]
        string SumOfDigits(string n1);
        [OperationContract]
        string ReverseString(string n1);
        [OperationContract]
        string TagHTML(string n1, string n2);
        [OperationContract]
        string OrderNumbers(string n1, string n2, string n3, string n4, string n5, string n6);

    }

}
