using System;
using System.Collections.Generic;
using System.Text;

namespace Category___library.Entities
{
    public class Category
    {
        private static int ID = 1;
        public int CategoryID { get; set; }
        public static int IDIncrementer()
        {
            return ID++;
        }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Description { get; set; }
    }
}
