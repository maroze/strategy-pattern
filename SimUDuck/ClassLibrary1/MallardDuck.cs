﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new DQuack();
        }
        //public MallardDuck() : base(new FlyWithWings(), new DQuack())
        //{
        //}
        public override string Display()
        {
            return "Кряква ";
        }
    }
}
