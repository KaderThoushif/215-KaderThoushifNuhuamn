﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal Says Hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }

    }

    class  Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog song");
        }

    }
}
