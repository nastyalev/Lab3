using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Students_
{
    public class Student : Abstract_Student
    {
        public override string Student_name()
        {
            return "Студент:" + First_name + " " + Last_name;
        }
        public override string Namber_()
        {
            return "Номер студенческого: " + Namber;
        }
        public override string Direction_()
        {
            return "Студент:" + Direction;
        }
        public override string Form_()
        {
            return "Номер студенческого: " + Form;
        }
        public override string Years_()
        {
            return "Студент:" + Years;
        }
    }
}
