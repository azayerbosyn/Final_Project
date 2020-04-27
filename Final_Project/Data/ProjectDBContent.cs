using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;
using Final_Project.Data.Models;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Final_Project.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ProjectDBContent : DbContext
    {

    /*    public ProjectDBContent(DbContextOptions<ProjectDBContent> options) : base(options)
        {

        }
*/
        
        public Microsoft.EntityFrameworkCore.DbSet<Soldier> Soldier { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Category> Category { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseMySql("server=localhost;port=3307;userid=root;password=supernatural091;database=soldier;");

        }
    }
}
