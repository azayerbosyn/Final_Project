using System;
using System.Collections.Generic;
using Final_Project.Data.Models;

namespace Final_Project.Data.Intefaces
{
    public interface ISoldiersCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
