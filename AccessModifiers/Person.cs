using System;

namespace AccessModifiers
{
    public class Person
    {
        /*        private DateTime _birthdate;

                public void setBirthDate(DateTime birthdate)
                {
                    _birthdate = birthdate;
                }

                public DateTime getBirthDate()
                {
                    return _birthdate;
                }*/

        public string Name { get; set; }
        public string  Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
               }
        }


    }
}
