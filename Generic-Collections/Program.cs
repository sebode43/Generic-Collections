using System;
using System.Collections.Generic;

namespace Generic_Collections {
    class Program {
        static void Main(string[] args) {

            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
            }
            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
            }

            var strings = new List<string>(12);
            strings.Add("Robbie");
            strings.Add("Armon");
            strings.Add("Danae");
            strings.Add("Traci");
            strings.Add("Manish");
            strings.Add("Vaughn");
            strings.Add("Sarah");
            strings.Add("David");
            strings.Add("Ian");
            strings.Add("Laura");
            strings.Add("Parker");
            strings.Add("George");
            Console.WriteLine();
            foreach(var aString in strings) {
                Console.Write($" {aString} ");
            }

            var Customers = new List<Customer>();
            var Amazon = new Customer(1, "Amazon", true);
            var PG = new Customer(2, "P&G", true);
            var Meijer = new Customer { ID = 3, Name = "Meijer", Active = true };
            var Target = new Customer { ID = 4, Name = "Target" };
            var Microsoft = new Customer { ID = 5, Name = "Microsoft", Active = false };

            Customers.Add(Amazon);
            Customers.Add(PG);
            var custArray = new Customer[] { Meijer, Target, Microsoft };
            Customers.AddRange(custArray);
            
            Console.WriteLine();

            foreach (var customer in Customers) {
                //if (customer.Active == true) {
                //    Console.Write($" {customer.ID} {customer.Name} ");
                if (customer.Active == false) {
                    continue; //break to find the ones that are false
                }
                Console.Write($" {customer.ID} {customer.Name} ");
            
            }
            Console.WriteLine();
            var custName= "Not Found";
            foreach (var cust in Customers) {
                if (cust.ID == 3) {
                    custName = cust.Name;
                    break;
                }
                

            }
                
          Console.WriteLine($" Customer whose ID is 3 is {custName} ");

            Console.WriteLine();
            var CustDictionary = new Dictionary<int, Customer>();
            CustDictionary.Add(Amazon.ID, Amazon);
            CustDictionary.Add(Target.ID, Target);
            CustDictionary.Add(Meijer.ID, Meijer);
            CustDictionary.Add(PG.ID, PG);
            CustDictionary.Add(Microsoft.ID, Microsoft);

            var cust2 = CustDictionary[3].Name;
            Console.WriteLine($"Customer ID 3 is {cust2}");
            Console.WriteLine($"Customer ID 2 is {CustDictionary[2].Name}");

            foreach(var key in CustDictionary.Keys) {
                var custKey = CustDictionary[key];
                Console.WriteLine($"{custKey.Name}");
            }
            var Color = "black";
            var Error = false;

            Color = (Error == true) ? "red" : "green";

        }
    }
}
