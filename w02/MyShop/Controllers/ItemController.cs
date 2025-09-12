using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers;

public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = new List<Item>();

        var item1 = new Item(1, "Pizza", 60);

        var item2 = new Item(2, "Fish and chips", 80);

        var item3 = new Item(3, "Tacos", 50);
       
        items.Add(item1);
        items.Add(item2);
        items.Add(item3);

        ViewBag.CurrentViewName = "List of Shop Items";
        return View(items);
    }
}