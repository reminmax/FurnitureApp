using FurnitureApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp.Services.Data
{
    internal class SampleDataService : IDataService
    {
        public List<FurnitureCategory> GetCategories()
        {
            return new List<FurnitureCategory>()
            {
                new FurnitureCategory("All", true),
                new FurnitureCategory("Chair"),
                new FurnitureCategory("Table"),
                new FurnitureCategory("Lamp"),
                new FurnitureCategory("Floor")
            };
        }

        public List<FurnitureItem> GetItems()
        {
            return new List<FurnitureItem>()
            { 
                new FurnitureItem()
                { 
                    Name = "BBT8013 Chair",
                    Category = "Chair",
                    MainImage = "chair_01_1.png",
                    Images = new List<string> { "chair_01_2.png", "chair_01_3.png", "chair_01_4.png" },
                    Maker = "Baxton Studio",
                    Price = 102,
                    ColorsList = new List<string> { "#bfb7b2", "#333333", "#495198"},
                    Description = "Baxton Studio BBT8013-Grey Chair armchairs, Grey. Ergonomical for humans body curve.",
                    Rating = 4.7F
                },
                new FurnitureItem()
                {
                    Name = "Knight Chair",
                    Category = "Chair",
                    MainImage = "chair_02_1.png",
                    Images = new List<string> { "chair_02_2.png", "chair_02_3.png", "chair_02_4.png" },
                    Maker = "Christopher Knight",
                    Price = 221,
                    ColorsList = new List<string> { "#4e4f51", "#333333", "#495198"},
                    Description = "Christopher Knight Home Felicity Mid-Century Fabric Arm Chair, Charcoal.",
                    Rating = 5.2F
                },
                new FurnitureItem()
                {
                    Name = "Office Desk Chair",
                    Category = "Chair",
                    MainImage = "chair_03_1.png",
                    Images = new List<string> { "chair_03_2.png", "chair_03_3.png", "chair_03_4.png" },
                    Maker = "Widji",
                    Price = 249,
                    ColorsList = new List<string> { "#48434b", "#333333", "#495198"},
                    Description = "Basics Padded Office Desk Chair with Armrests, Adjustable Height/Tilt, 360-Degree Swivel, 275Lb Capacity - Black.",
                    Rating = 3.9F
                },
            };
        }
    }
}
