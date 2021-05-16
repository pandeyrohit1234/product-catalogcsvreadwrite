using System;
using System.Collections.Generic;
using System.Text;

namespace Category___library
{
    public class CategoryMenu
    {
        public void Categorymenu()
        {

            Console.Clear();
            Console.WriteLine("------------WELCOME TO CATEGORY MENU-------------");
            Console.WriteLine("-------Select-----");
            Console.WriteLine(" 1.GET all category");
            Console.WriteLine("2.SEARCH category");
            Console.WriteLine("3.ADD Category");
            Console.WriteLine("4.Delete category");
            Console.WriteLine("5.Exit");
            string cchoice = Console.ReadLine();
            Console.WriteLine("");
            CateogryOperation categoryoperation = new CateogryOperation();

            if (cchoice == "1")
            {
               categoryoperation.GetCategory();
            }
            else if (cchoice == "2")
            {
                categoryoperation.SearchCategory();
            }
            else if (cchoice == "3")
            {
                 categoryoperation.AddCategory();
            }
            else if (cchoice == "4")
            {
                  categoryoperation.DeleteCategory();
            }
            else if (cchoice == "5")
            {
                Console.WriteLine("Please try again");
                
            }

        }
    }
}
