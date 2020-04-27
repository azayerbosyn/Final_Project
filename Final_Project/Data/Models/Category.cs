﻿using System;
using System.Collections.Generic;

namespace Final_Project.Data.Models
{
    public class Category
    {
        public int Id { set; get; }

        public string CategoryName { set; get; }

        public string Desc { set; get; }

        public List<Soldier> Soldiers { set; get; }
    }
}
