using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1CSE445
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int c2f(int c); // convert Celsius temperature to Fahrenheit temperature 
        [OperationContract]
        int f2c(int f); // convert Fahrenheit temperature to Celsius temperature 

        [OperationContract]
        string sort(string s);
    }
}
