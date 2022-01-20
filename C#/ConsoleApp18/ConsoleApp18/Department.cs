using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
   abstract class Department
    {
 
            public void getDepartmentName()
            {
                Console.WriteLine(" Department : IT Department ");
            }
            
            public void getNumberOfDepartment()
            {
                Console.WriteLine(" Number of Department : 2 ");
            }
           
            public virtual void getDepartmentDetail()
            {
                Console.WriteLine(" Departments : Team Leaders, Developer ");
            }
        }
    }

