using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            //User Anurag will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Dave", RedMI);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Tom", RedMI);
            //User Priyanka will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Mitch", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();
            // Now product is available
            RedMI.setAvailability("Available");
            Console.Read();
        }
    }
}
