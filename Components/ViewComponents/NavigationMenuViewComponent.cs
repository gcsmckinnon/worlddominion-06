﻿using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using WorldDominion.Models;

namespace WorldDominion.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<MenuItem>
            {
                new MenuItem { Controller = "Home", Action = "Index", Label = "Home" },
                new MenuItem { Controller = "Home", Action = "About", Label = "About" },
                new MenuItem { Controller = "Departments", Action = "Index", Label = "Departments", DropdownItems = new List<MenuItem> {
                    new MenuItem { Controller = "Departments", Action = "Index", Label = "List" },
                    new MenuItem { Controller = "Departments", Action = "Create", Label = "Create" },
                } },
                new MenuItem { Controller = "Products", Action = "Index", Label = "Products", DropdownItems = new List<MenuItem> {
                    new MenuItem { Controller = "Products", Action = "Index", Label = "List" },
                    new MenuItem { Controller = "Products", Action = "Create", Label = "Create" },
                } },
                new MenuItem { Controller = "Home", Action = "Privacy", Label = "Privacy" },
            };

            return View(menuItems);
        }
    }
}
