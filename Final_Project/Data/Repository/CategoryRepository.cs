using System;
using System.Collections.Generic;
using Final_Project.Data.Intefaces;
using Final_Project.Data.Models;
using System.Linq;
using System.Threading.Tasks;
namespace Final_Project.Data.Repository
{
    public class CategoryRepository : ISoldiersCategory
    {
        private readonly ProjectDBContent projectDBContent;

        public CategoryRepository(ProjectDBContent projectDBContent)
        {
            this.projectDBContent = projectDBContent;
        }

        public IEnumerable<Category> AllCategories => projectDBContent.Category;//получаем все обьекты категорий
    }
}
