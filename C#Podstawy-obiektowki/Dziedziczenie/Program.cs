using Dziedziczenie.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact user = new Contact();
            user.name = "Karol ";
            Console.WriteLine(user.name);
            Console.ReadKey();
        }
    }
}
