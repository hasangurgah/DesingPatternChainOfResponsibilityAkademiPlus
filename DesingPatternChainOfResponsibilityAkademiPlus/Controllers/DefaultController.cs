﻿using DesingPatternChainOfResponsibilityAkademiPlus.ChainOfResponsibility;
using DesingPatternChainOfResponsibilityAkademiPlus.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesingPatternChainOfResponsibilityAkademiPlus.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee regionManager = new RegionManager();

            treasurer.SetNextApprover(managerAsistant);
            managerAsistant.SetNextApprover(manager);
            manager.SetNextApprover(regionManager);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
