using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Data;
using Final_Project.Data.Intefaces;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers
{
    public class SoldiersController : Controller
    {
        private ProjectDBContent db = new ProjectDBContent();
        private readonly IAllSoldiers _allSoldiers;
        private readonly ISoldiersCategory _allCategory;

        public SoldiersController(IAllSoldiers IAllSoldiers, ISoldiersCategory ISoldiersCat)
        {
            _allSoldiers = IAllSoldiers;
            _allCategory = ISoldiersCat;
        }

        public ViewResult ListAll()
        {
            //var soldiers = _allSoldiers.Soldiers;
            //return View(soldiers);
            ViewBag.Title = "Soldiers Info page";
            SoldiersListViewModel obj = new SoldiersListViewModel();
            obj.AllSoldiers = _allSoldiers.Soldiers;
            obj.SoldiCategory = "Soldiers";

            return View(obj);
        }

    }
}
