using Category___library.Entities;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Category___library
{
    public class CateogryOperation
    {


      string CategoryFilePath = @"C:\Users\LENOVO\source\repos\MyProductCatalog\CSV\category.csv";

        List<Category> CategoryList = new List<Category>();

        public void AddCategory()
        {
            Console.Clear();

            //File.Create(CategoryFilePath + "/category.csv");
            string categoryName = "";
            while (categoryName.Length < 1)
            {
                Console.WriteLine("Enter name \nName is required");
                categoryName = Console.ReadLine();
            }
            string pCode = "";
            while (pCode.Length > 4 || pCode.Length < 1)
            {
                Console.WriteLine("Enter shortcode \nShortcode is required(0<length<5)");
                pCode = Console.ReadLine();
            }
            string desc = "";
            while (desc.Length < 1)
            {
                Console.WriteLine("Enter Description \nDescription is required");
                desc = Console.ReadLine();
            }
           
            CategoryList.Add(new Category
            {
                CategoryID = CategoryList.Count + 1,
                Name = categoryName,
                ShortCode = pCode,
                Description = desc,

            });
          

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
            };
            using (var writer = new StreamWriter(CategoryFilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {
                csvWriter.WriteRecords(CategoryList);
                Console.WriteLine("\n");
                Console.WriteLine("Added successfully");
            }
        }

        public void GetCategory()
        {
            Console.Clear();
            using (StreamReader input = File.OpenText(CategoryFilePath))
            using (CsvHelper.CsvReader csvReader = new CsvHelper.CsvReader(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();
                Console.WriteLine("Id\tName\tShortCode\tDescription");
                foreach (var record in records)
                {
                    Console.WriteLine(record.CategoryID + "\t" + record.Name + "\t" + record.ShortCode + "\t"
                       + "\t\t" + record.Description);
                }
            }
        }

        public void SearchCategory()
        {
            Console.Clear();
            Console.WriteLine("1 : Give ID");
            Console.WriteLine("2 : Give Name");
            Console.WriteLine("3 : Give Short Code");

            int ch3 = Convert.ToInt32(Console.ReadLine());
            switch (ch3)
            {
                case 1:
                    Console.WriteLine("Enter Id : ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    SearchByID(a);
                    break;
                case 2:
                    Console.WriteLine("Enter Name : ");
                    var name = Console.ReadLine();
                    SearchByName(name);
                    break;
                case 3:
                    Console.WriteLine("Enter Short Code : ");
                    var sc = Console.ReadLine();
                    SearchByShortCode(sc);
                    break;
            }
        }
        public  void SearchByID(int id)
        {
            var d = CategoryList.FindAll((i) => i.CategoryID == id);
            if (d.Count > 0)
            {
                d.ForEach((i) =>
                {
                    Console.WriteLine($"{i.CategoryID} \t\t {i.Name}\t\t{i.ShortCode}\t\t{i.Description}");
                });
            }
            else
            {
                Console.WriteLine("InValid Id");
            }

        }
        public void SearchByName(string Name)
        {
            var s = File.ReadLines(CategoryFilePath);
            foreach (var line in s)
            {
                if (line.Split(',')[1].Equals(Name))
                {
                    Console.WriteLine(line);
                    return;
                }

            }

        }
        public void SearchByShortCode(string shortCode)
        {
            var s = File.ReadLines(CategoryFilePath);
            foreach (var line in s)
            {
                if (line.Split(',')[2].Equals(shortCode))
                {
                    Console.WriteLine(line);
                    return;
                }

            }
        }


        public void DeleteCategory()
        {
            List<Category> records;
            Console.WriteLine("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());
            using (var reader = new StreamReader(CategoryFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Category>().ToList();
                for (int i = 0; i < records.Count; ++i)
                {
                    if (records[i].CategoryID == id)
                    {
                        records.RemoveAt(i);
                    }
                }
            }

            using (var writer = new StreamWriter(CategoryFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }
    }
}
