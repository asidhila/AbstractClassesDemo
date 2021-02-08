using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vechile
    {
        public Motorcycle()
        {

        }
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("$This {Get Type().Name} is a {Get Type(.Base Type .Name} this is virtually in drive");
        }
    }
}




