using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceVaksin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceVaksin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceVaksin.svc or ServiceVaksin.svc.cs at the Solution Explorer and start debugging.
    public class ServiceVaksin : IServiceVaksin
    {
        public string Hello()
        {
            return "Hello Wolrd";
        }

        public string hi(string name)
        {
            return "Hi" + name;
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }

}
