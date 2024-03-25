using APP.Core._1;

namespace APP.Core.HW._1
{
    public class SyntaxWhereHW
    {
        public void Example()
        {
            // Car collection
            IList<Car> carList = new List<Car>()
            {
                new Car {CarID=1,CarName="BMW23",Year=2023},
                new Car {CarID=1,CarName="BMW24",Year=2024},
              // add More #TODO
            };

            // LINQ Query Syntax to find car between 2000 to 2024

            //var carBw2000to2024 = // #TODO

            Console.WriteLine("Car list between 2000 to 2024 carList:");

            //foreach (Car x in carBw2000to2024)
            //{
            //    Console.WriteLine(x.CarName);
            //}
        }
    }

    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public int Year { get; set; }
    }
}
