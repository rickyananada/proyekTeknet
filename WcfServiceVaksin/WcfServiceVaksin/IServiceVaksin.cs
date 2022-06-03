using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceVaksin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceVaksin" in both code and config file together.
    [ServiceContract]
    public interface IServiceVaksin
    {
        [OperationContract]
        string Hello();
        [OperationContract]
        string hi(string name);
        [OperationContract]
        int sum(int a, int b);
    }
}
