using Product_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogStreams.Entities
{
    public class MainMenu
    {
        public static void mainMenu()
        {
            
            
            
            
            
            
            Console.WriteLine("1. Products");
            Console.WriteLine("2. Categories");
            Console.WriteLine("3. Exit");
            userinput();

        }

        public static void userinput()
        {
           
            
            
            int input = Convert.ToInt32(Console.ReadLine());
            if(input==1)
            {
                ProductMenu.productmenu();
            }
        }






        //public static void createCsvFile(string dirPath)
        //{
        //    //File.Create("csvData.csv");
        //    File.Create(dirPath + "/csvdata.csv");
        //}

        //public static void writeCsvData(string dirPath)
        //{
        //    string filePath = dirPath + "/csvdata.csv";
        //    //using (StreamWriter file = new StreamWriter(filePath, true))
        //    //{

        //    string filerow = "\n" + "2" + "," + "Pen" + "," + "1000";

        //    if (!File.Exists(filePath))
        //    {
        //        string fileHeader = "Id" + "," + "Name" + "," + "Price";
        //        File.WriteAllText(filePath, fileHeader);
        //        Console.WriteLine("heelo csv");
        //    }

        //    File.AppendAllText(filePath, filerow);

            //}
        }
        //public void GetProduct()
        //{

        //    Console.WriteLine("ProductID\t\tName\t\tShortCode\t\tDescription");
        //    Console.WriteLine(" ");
        //    foreach (var item in products)
        //    {
        //        Console.WriteLine(item.ProductID + "\t\t" + item.ProductName + "\t\t" + item.ShortCode + "\t\t\t" + item.Description);
        //    }
        //}

        //public static void DeleteProduct()
        //{
        //    Console.WriteLine("Please select an option to delete");
        //    Console.Write("1. Give id\t");
        //    Console.WriteLine(" ");
        //    Console.WriteLine("2. Give Short Code\t");
        //    Console.WriteLine(" ");





        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    if (choice == 1)
        //    {
        //        Console.WriteLine("Enter Id :");
        //        int id = Convert.ToInt32(Console.ReadLine());





        //        products.RemoveAt(id - 1);
        //    }
        //    else if (choice == 2)
        //    {
        //        Console.WriteLine("Enter Short Code : ");
        //        string shortcode = Console.ReadLine();
        //        var producttoremove = products.Single(r => r.ShortCode == shortcode);
        //        products.Remove(producttoremove);
        //    }





        //}



        ////Add new product
        //public static void AddProduct(string pName, string pCode, string desc, int sp)
        //{

        //    CategoryOperation.categories.ForEach((i) =>
        //    {
        //        Console.WriteLine(i.Category_ID + i.Category_Name);
        //    });
        //    List<Category> productCategories = new List<Category>();
        //    string choice;
        //    do
        //    {
        //        Console.WriteLine("GIVE CATEGORY ID ");
        //        int id = Convert.ToInt32(Console.ReadLine());
        //        var data = CategoryOperation.categories.Single((a) => a.Category_ID == id);
        //        if (data != null)
        //            productCategories.Add(data);
        //        Console.WriteLine("FOR ADDING MORE CATEGORY : yes , else : no ");
        //        choice = Console.ReadLine();
        //    } while (choice == "yes");




        //    products.Add(new Products
        //    {

        //        ProductID = Products.ID,
        //        ProductName = pName,
        //        ShortCode = pCode,
        //        Description = desc,
        //        SellingPrice = sp,
        //        Category = productCategories,

        //    });
        //    ListOfAllCategories();
        //}

        //public static void ListOfAllCategories()
        //{
        //    Console.WriteLine("ProductID" + "\t" + "Product Name" + "\t\t" + "Product Short Code" + "\t" + "Product Description" + "\t" + "Product Selling Price" + "\t" + "Category" + "\n");
        //    products.ForEach((i) =>
        //    {

        //        string s = "";
        //        i.Category.ForEach(c => {
        //            s += c.Category_Name + ", ";
        //        });

        //        Console.WriteLine($"{i.ProductID} \t\t {i.ProductName}\t\t\t {i.ShortCode}\t\t\t{i.Description}\t\t\t{i.SellingPrice}\t\t{s}");
        //    });
        //}




        ////Search new Product
        //public void SearchById(int id)
        //{

        //    var d = products.FindAll((i) => i.ProductID == id);
        //    if (d.Count > 0)
        //    {
        //        d.ForEach((i) =>
        //        {
        //            Console.WriteLine($"{i.ProductID} \t\t {i.ProductName}\t\t{i.Manufacturer}\t\t{i.Description}\t\t{i.SellingPrice}");
        //        });
        //    }
        //    else
        //    {
        //        Console.WriteLine("Id Not Found");
        //    }




        //}

 }
