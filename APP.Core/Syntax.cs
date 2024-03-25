using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APP.Core
{
    public class Syntax
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void QuerySyntax()
        {
            var query = from number in numbers
                        where number % 2 == 0
                        select number;

            // Print Query Syntax results
            Console.WriteLine("Query Syntax Results:");
            foreach (var num in query)
            {
                Console.WriteLine(num);
            }
        }

        public void MethodSyntax()
        {
            var query = numbers
                     .Where(number => number % 2 == 1)
                     .Select(number => number);

            // Print Method Syntax results
            Console.WriteLine("Method Syntax Results:");
            foreach (var num in query)
            {
                Console.WriteLine(num);
            }
        }

        public void MixedSyntax()
        {
            var query = numbers
                .Where(number => number % 2 == 0)
                .Select(x => x)
                .ToList();

            // Print Mixed Syntax results
            Console.WriteLine("Mixed Syntax Results:");
            foreach (var num in query)
            {
                Console.WriteLine(num);
            }
        }
    }
}
