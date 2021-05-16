using System;
using System.Collections.Generic;
using System.Text;

namespace Product___library
{
    public class ProductMenu
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------WELCOME TO Product MENU-------------------------");
            Console.WriteLine("-----Select-----  \n1.Add products   \n2.Get Product \n3.DELETE product  \n4.SearchProduct \n5.Exit");
            string choice = Console.ReadLine();
            Console.WriteLine("");
            ProductOperation inputmanagement = new ProductOperation();

            if (choice == "1")
            {
                inputmanagement.AddProduct();
            }
            
            
            else if (choice == "2")
            {
                inputmanagement.GetProduct();
            }
           

            else if (choice == "3")
            {
                inputmanagement.DeleteProduct();
                Console.WriteLine("Product Deleted");

            }

            else if (choice == "4")
            {
                inputmanagement.SearchProduct();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Please try again");
            }

        }
    }
}
