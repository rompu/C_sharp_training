using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Person
    {   //auto implemented properties on top, constructors after and calculated properties on the bottom

        public string Name { get; set; }
        public DateTime Birthdate { get; private set; } //auto implemented property , privaet means that it is read only

        public Person(DateTime birthDate)
        {
            Birthdate = birthDate;
        }

        public double Weight { get;}

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        //private DateTime _birthdate;

        //public DateTime Birthdate
        //{
        //    get { return _birthdate; }
        //    set { _birthdate = value; }

        //}
    }
}
