using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectChauffer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2 };

            Person person = ObjectChauffeur.Create<Person>()
               .WithFirstName("Jason")
               .WithSurname("Evans")
               .WithAge(36)
               .WithNumbers(numbers)
               .Build();

            Console.WriteLine(person.ToString());

            foreach (var num in person.Numbers)
                Console.WriteLine(num);
        }
    }
}
