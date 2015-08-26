namespace ObjectChauffer
{
    using System.Collections.Generic;

    public class Person
    {
        /// <summary>
        /// Gets or sets the person's age.
        /// </summary>
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