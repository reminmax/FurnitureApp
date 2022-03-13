using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp.Models
{
    internal class FurnitureItem
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Maker { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public List<string> ColorsList { get; set; }

        public string MainImage { get; set; }

        public List<string> Images { get; set; }

        public float Rating { get; set; }
    }
}
