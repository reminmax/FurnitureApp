using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp.Models
{
    internal class FurnitureCategory
    {
        public string Name { get; set; }
        
        public bool IsSelected { get; set; }

        public FurnitureCategory(string name, bool isSelected = false)
        {
            Name = name;
            IsSelected = isSelected;
        }
    }
}
