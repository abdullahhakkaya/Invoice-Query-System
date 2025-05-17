using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceQuerySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Invoice Application Started\n");

                // Sample data
                var invoices = new List<Invoice>
                {
                    new Invoice { PartNumber = 83, PartDescription = "Electric sander", Quantity = 7, Price = 57.98M },
                    new Invoice { PartNumber = 24, PartDescription = "Electric saw", Quantity = 18, Price = 99.99M },
                    new Invoice { PartNumber = 71, PartDescription = "Sledgehammer", Quantity = 11, Price = 21.50M },
                    new Invoice { PartNumber = 77, PartDescription = "Hammer", Quantity = 76, Price = 11.99M },
                    new Invoice { PartNumber = 39, PartDescription = "Lawn mower", Quantity = 3, Price = 79.50M },
                    new Invoice { PartNumber = 68, PartDescription = "Screwdriver", Quantity = 106, Price = 6.99M },
                    new Invoice { PartNumber = 56, PartDescription = "Jigsaw", Quantity = 21, Price = 11.50M },
                    new Invoice { PartNumber = 32, PartDescription = "Wrench", Quantity = 34, Price = 7.50M }
                };

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("INVOICE QUERY SYSTEM");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("1 - Sort by part description");
                    Console.WriteLine("2 - Sort by price");
                    Console.WriteLine("3 - Show stock quantities");
                    Console.WriteLine("4 - Show total amounts");
                    Console.WriteLine("5 - Show products with total between $200 and $500");
                    Console.WriteLine("6 - Exit");
                    Console.WriteLine("------------------------");
                    Console.Write("Your choice (1-6): ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("\nPart No - Description - Quantity - Price (Sorted by Description):");
                            var query1 = from i in invoices
                                         orderby i.PartDescription
                                         select new { i.PartNumber, i.PartDescription, i.Quantity, i.Price };
                            foreach (var i in query1)
                                Console.WriteLine($"- {i.PartNumber} - {i.PartDescription} - {i.Quantity} - {i.Price}$");
                            break;

                        case "2":
                            Console.WriteLine("\nPart No - Description - Quantity - Price (Sorted by Price):");
                            var query2 = from i in invoices
                                         orderby i.Price descending
                                         select new { i.PartNumber, i.PartDescription, i.Quantity, i.Price };
                            foreach (var i in query2)
                                Console.WriteLine($"- {i.PartNumber} - {i.PartDescription} - {i.Quantity} - {i.Price}$");
                            break;

                        case "3":
                            Console.WriteLine("\nPart Description - Quantity (Sorted by Quantity):");
                            var query3 = from i in invoices
                                         orderby i.Quantity descending
                                         select new { i.PartDescription, i.Quantity };
                            foreach (var i in query3)
                                Console.WriteLine($"- {i.PartDescription}: {i.Quantity} units");
                            break;

                        case "4":
                            Console.WriteLine("\nPart Description - Total Amount (Sorted by Total):");
                            var query4 = from i in invoices
                                         let total = i.Quantity * i.Price
                                         orderby total descending
                                         select new { i.PartDescription, Total = total };
                            foreach (var i in query4)
                                Console.WriteLine($"- {i.PartDescription}: ${i.Total:F2}");
                            break;

                        case "5":
                            Console.WriteLine("\nProducts with Total Between $200 and $500:");
                            var query5 = from i in invoices
                                         let total = i.Quantity * i.Price
                                         where total >= 200M && total <= 500M
                                         orderby total descending
                                         select new { i.PartNumber, i.PartDescription, i.Quantity, i.Price, Total = total };
                            foreach (var i in query5)
                                Console.WriteLine($"- {i.PartNumber} - {i.PartDescription} - {i.Quantity} - {i.Price} - ${i.Total:F2}");
                            break;

                        case "6":
                            Console.WriteLine("\nExiting program...");
                            return;

                        default:
                            Console.WriteLine("\nInvalid choice! Please enter a number between 1 and 6.");
                            break;
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey();
            }
        }
    }
}
