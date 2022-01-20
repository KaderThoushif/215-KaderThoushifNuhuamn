using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class Employee : Department
    {
        public void getFirstName()
        {
            Console.WriteLine(" First Name : Kader Thoushif Nuhuman ");
        }
        public void getLastName()
        {
            Console.WriteLine(" Last Name : H ");
        }

        public override void getDepartmentDetail()
        {
            Console.WriteLine(" Employee Department : Developers Team ");
        }
    }
}
