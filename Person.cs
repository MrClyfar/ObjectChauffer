namespace ObjectChauffer
{
    using System.Collections.Generic;

    public class Person
    {
        public int Age { get; set; }

        public string FirstName { get; set; }

        public IList<int> Numbers { get; set; }

        public string Surname { get; set; }

        public override string ToString()
        {
            return string.Concat(this.FirstName, " ", this.Surname, " is ", this.Age);
        }
    }
}