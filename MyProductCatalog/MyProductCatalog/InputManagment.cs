using System;
using System.Collections.Generic;
using System.Text;
using Product___library;
using Category___library;


namespace MyProductCatalog
{
    public class InputManagment
    {
        public void input()
        {
          

            Console.WriteLine("\tPRODUCT  CATALOG");
            Console.WriteLine("");
            while (true)
            {

                Console.WriteLine("--------ENTER--------  \n1.Product  \n2.Category  \n3.Exit : ");
                string firstchoice = Console.ReadLine();
                Console.WriteLine("");

                if (firstchoice.ToUpper() == "1")
                {
                    ProductMenu productManager = new ProductMenu();
                    productManager.MainMenu();
                }
                if (firstchoice.ToUpper() == "2")
                {
                    CategoryMenu categorymenu = new CategoryMenu();
                    categorymenu.Categorymenu();

                }
                if (firstchoice.ToUpper() == "3")
                {
                    Console.WriteLine("Please Visit Again");
                    break;
                }

            }
        }
    }
}