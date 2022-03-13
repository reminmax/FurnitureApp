using FurnitureApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp.Services.Data
{
    internal interface IDataService
    {
        List<FurnitureCategory> GetCategories();

        List<FurnitureItem> GetItems();
    }
}
