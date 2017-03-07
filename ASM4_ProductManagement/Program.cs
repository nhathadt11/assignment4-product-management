using ASM4_ProductManagement;
using ASM4_ProductManagement.Repository;
using ASM4_ProductManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            SuppilerService suppilerService = new SuppilerService();
            CategoryService categoryService = new CategoryService();
            while (true)
            {
                Console.WriteLine("\n-------Welcome-------");
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine("\n-------All Products-------");
                        Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Name", "Price"));
                        productService.GetAll()
                            .ForEach(p => Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}",
                                     p.ProductID, p.ProductName, p.UnitsOnOrder)));
                        break;
                    case 2:
                        Console.WriteLine("\n-------All Suppilers-------");
                        Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Company Name", "City"));
                        suppilerService.GetAll()
                            .ForEach(s => Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}",
                                    s.SupplierID, s.CompanyName, s.City)));
                        break;
                    case 3:
                        Console.WriteLine("\n-------All Categories-------");
                        Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-50}", "ID", "Name", "Description"));
                        categoryService.GetAll()
                            .ForEach(c => Console.WriteLine("{0,-5}{1,-35}{2,-50}", c.CategoryID, c.CategoryName, c.Description));
                        break;
                    case 4:
                        string searchValue;
                        Console.Write("Enter product name: ");
                        searchValue = Console.ReadLine();
                        Console.WriteLine("\n-------Search result for: " + searchValue + "-------");
                        List<Product> products = productService.SearchProductByName(searchValue);
                        if (products.Count != 0)
                        {
                            Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Name", "Price"));
                            products.ForEach(p => Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}",
                                     p.ProductID, p.ProductName, p.UnitsOnOrder)));
                        }
                        else
                        {
                            Console.WriteLine("No product found!");
                        }
                        break;
                    case 5:
                        Console.Write("Enter company name: ");
                        searchValue = Console.ReadLine();
                        Console.WriteLine("\n-------Search result for: " + searchValue + "-------");
                        List<Supplier> suppilers = suppilerService.SearchSuppilerByCompanyName(searchValue);
                        if (suppilers.Count != 0)
                        {
                            Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}", "ID", "Company Name", "City"));
                            suppilers.ForEach(s => Console.WriteLine(string.Format("{0,-5}{1,-35}{2,-10}",
                                        s.SupplierID, s.CompanyName, s.City)));
                        }
                        else
                        {
                            Console.WriteLine("No suppiler found!");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        static int Menu()
        {
            int choice;
            Console.WriteLine("1.	List all Products.");
            Console.WriteLine("2.	List all Suppliers.");
            Console.WriteLine("3.	List all Categories.");
            Console.WriteLine("4.	Search Products by Product name.");
            Console.WriteLine("5.	Search Suppliers by Company Name.");
            Console.WriteLine("6.   Quit.");
            Console.Write("Your choice: ");
            while (!int.TryParse(Console.ReadLine(), out choice)) { break; }
            return choice;
        }
    }
}
