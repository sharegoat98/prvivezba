using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Request input: ");
            string req = Console.ReadLine();
            
            //za sada proveravamo samo za get metod
            if (req.ToLower().StartsWith("get "))
            {
                UserRequest.Request = req;
            } else
            {
                throw new Exception("Method not valid. Try using GET method");
            }

            Console.Read();
        }
    }
}
