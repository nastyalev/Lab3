using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Students_
{
    public abstract class Abstract_Student
    {

        protected double Namber;
        protected string First_name;
        protected string Last_name;
        protected string Form;
        protected double Years;
        protected string Direction;

        public abstract string Student_name();
        public abstract string Namber_();
        public abstract string Direction_();
        public abstract string Form_();
        public abstract string Years_();
    }
} 
