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
        bool IsInt(string userInput);

        [OperationContract]
        string PrimeNumber(int userInput);

    }

}
