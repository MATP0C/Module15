using System;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var softwareManufacturers = new List<string>()
            {
                "Microsoft", "Apple", "Oracle"
            };

            var hardwareManufacturers = new List<string>()
            {
                "Apple", "Samsung", "Intel"
            };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

            foreach (var itCom in itCompanies)
            {
                Console.WriteLine(itCom);
            }
        } 
    }
}