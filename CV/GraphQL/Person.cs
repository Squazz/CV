using System;
using System.Collections.Generic;

namespace CV.GraphQL
{
    public class Person : Entity
    {
        public int Age => CalculateAge(Birthday);

        public List<int> Companies { get; set; }
        public List<int> Skills { get; set; }
        public List<int> Educations { get; set; }
        public DateTime Birthday { get; set; }

        private int CalculateAge(DateTime BirthDate)
        {
            // Shamelessly stolen: https://stackoverflow.com/a/3153008/1955317
            int yearsPassed = DateTime.Now.Year - BirthDate.Year;
            // Are we before the birth date this year? If so subtract one year from the mix
            if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
            {
                yearsPassed--;
            }
            return yearsPassed;
        }
    }
}