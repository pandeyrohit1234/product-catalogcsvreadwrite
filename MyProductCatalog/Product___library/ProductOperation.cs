using CsvHelper;
using CsvHelper.Configuration;
using Product___library.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Product___library
{
    public class ProductOperation
    { 
        string ProductFilePath = @"C:\Users\LENOVO\source\repos\MyProductCatalog\CSV\product.csv";
        
        List<Product> ProductList = new List<Product>();


        public void GetProduct()
        {
            Console.Clear();
            using (StreamReader input = File.OpenText(ProductFilePath))
            using (CsvHelper.CsvReader csvReader = new CsvHelper.CsvReader(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();
                Console.WriteLine("calling get product");
                Console.WriteLine("Id\tName\tShortCode\tManufacture\tDescription\tPrice\t\tCATEGORY");
                foreach (var record in records)
                {
                    Console.WriteLine(record.ProductID + "\t" + record.Name + "\t" + record.ShortCode + "\t"
                       + record.Manufacturer + "\t\t" + record.Description + "\t" + record.SellingPrice + "\t" + record.CategoryName);
                }

            }
        }
        public void AddProduct()
        {
            //File.Create(ProductFilePath+ "/product.csv");
            string productName = "";
            while (productName.Length < 1)
            {
                Console.WriteLine("Enter name \nName is required");
                productName = Console.ReadLine();
            }
            string shortCode = "";
            while (shortCode.Length > 4 || shortCode.Length < 1)
            {
                Console.WriteLine("Enter shortcode \nShortcode is required(0<length<5)");
                shortCode = Console.ReadLine();
            }
            string desc = "";
            while (desc.Length < 1)
            {
                Console.WriteLine("Enter Description \nDescription is required");
                desc = Console.ReadLine();
            }
            string manufacturer = "";
            while (manufacturer.Length < 1)
            {
                Console.WriteLine("Enter Manufacturer \nManufacturer is required");
                manufacturer = Console.ReadLine();
            }
            int sellingprice = 0;
            while (sellingprice < 1)
            {
                Console.WriteLine("Enter SellingPrice \nSellingPrice > 0 is required");
                sellingprice = Convert.ToInt32(Console.ReadLine());
            }
          

            ProductList.Add(new Product
            {
                ProductID = ProductList.Count + 1,
                Name = productName,
                ShortCode = shortCode,
                Description = desc,
                SellingPrice = sellingprice,
                Manufacturer = manufacturer,
                //CategoryName = Cname,

            });

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
            };
            using (var writer = new StreamWriter(ProductFilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.WriteRecords(ProductList);
                Console.WriteLine("\n");
                Console.WriteLine("Added successfully");
                writer.Flush();
            }

        }

        public void SearchProduct()
        {
            Console.WriteLine("1 : Give Name");
            Console.WriteLine("2 : Give Short Code");

            int ch3 = Convert.ToInt32(Console.ReadLine());
            switch (ch3)
            {
                case 1:
                    Console.WriteLine("Enter Name : ");
                    var name = Console.ReadLine();
                    SearchByName(name);
                    break;
                case 2:
                    Console.WriteLine("Enter Short Code : ");
                    var sc = Console.ReadLine();
                    SearchByShortCode(sc);
                    break;
            }
        }
        public void SearchByName(string Name)
        {
            var s = File.ReadLines(ProductFilePath);
            foreach (var line in s)
            {
                if (line.Split(',')[0].Equals(Name))
                {
                    Console.WriteLine(line);
                    return;
                }

            }
        }
        public void SearchByShortCode(string shortCode)
        {
            var s = File.ReadLines(ProductFilePath);
            foreach (var line in s)
            {
                if (line.Split(',')[1].Equals(shortCode))
                {
                    Console.WriteLine(line);
                    return;
                }

            }
        }

        public void DeleteProduct()
        {
            List<Product> records;
            Console.WriteLine("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());
            using (var reader = new StreamReader(ProductFilePath))
            using (var csvFile = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csvFile.GetRecords<Product>().ToList();
                for (int i = 0; i < records.Count; ++i)
                {
                    if (records[i].ProductID == id)
                    {
                        records.RemoveAt(i);
                    }
                }
            }
            using (var writer = new StreamWriter(ProductFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }
    }
}
