using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        /// <summary>
        /// Method to get a message
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
