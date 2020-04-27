using System;
using System.Collections.Generic;
using Final_Project.Data.Models;

namespace Final_Project.ViewModels
{
    public class SoldiersListViewModel
    {
        public IEnumerable<Soldier> AllSoldiers { get; set; }

        public string SoldiCategory { get; set; }
    }
}
