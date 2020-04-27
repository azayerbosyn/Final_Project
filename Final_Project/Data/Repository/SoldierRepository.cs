using System;
using System.Collections.Generic;
using System.Linq;
using Final_Project.Data.Intefaces;
using Final_Project.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data.Repository
{
    public class SoldierRepository : IAllSoldiers
    {

        private readonly ProjectDBContent projectDBContent;

        public SoldierRepository(ProjectDBContent projectDBContent)
        {
            this.projectDBContent = projectDBContent;
        }
       

        public IEnumerable<Soldier> Soldiers => projectDBContent.Soldier.Include(c => c.Category);//получаем все обьекты



        public Soldier getObjectSoldier(int soldierId) => projectDBContent.Soldier.FirstOrDefault(p => p.Id == soldierId);//получаем один обьект
    }
}
