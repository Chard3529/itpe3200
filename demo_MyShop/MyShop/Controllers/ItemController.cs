using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers;

public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = GetItems();
        ViewBag.CurrentViewName = "Table";
        return View(items);
    }

    public IActionResult Grid()
    {
        var items = GetItems();
        ViewBag.CurrentViewName = "Grid";
        return View(items);
    }

    public List<Item> GetItems()
    {
        // A list for storing the items
        var items = new List<Item>();

        // Decleration of items: 
        var item1 = new Item(1, "Vegan Chiken Leg", 60);
        item1.Description = "Delicious crispy soy chiken leg, with bbq sauce";
        item1.ImageUrl = "/images/chickenleg.jpg";

        var item2 = new Item(2, "Pizza", 80);
        item2.Description = "An italian style pizza with vegan chese, corn hotdogs and a creamy sauce";
        item2.ImageUrl = "/images/pizza.jpg";

        var item3 = new Item(3, "French Fries", 60);
        item3.Description = "Our freshly cut fries, served with vegan mayo and ketchup";
        item3.ImageUrl = "/images/frenchfries.jpg";

        // From chatgpt:
        var item4 = new Item(4, "Vegan Ribs", 120);
        item4.Description = "Tender plant-based ribs glazed with smoky BBQ sauce, served with a side of slaw.";
        item4.ImageUrl = "/images/ribs.jpg";

        var item5 = new Item(5, "Vegan Tacos", 90);
        item5.Description = "Three soft tacos filled with spiced soy protein, fresh veggies, and creamy guacamole.";
        item5.ImageUrl = "/images/tacos.jpg";

        var item6 = new Item(6, "Vegan Fish & Chips", 110);
        item6.Description = "Crispy battered soy-based fish fillet with golden fries and tartar sauce.";
        item6.ImageUrl = "/images/fishandchips.jpg";

        var item7 = new Item(7, "Coca Cola", 40);
        item7.Description = "A refreshing glass bottle of chilled Coca Cola.";
        item7.ImageUrl = "/images/coke.jpg";

        var item8 = new Item(8, "Apple Cider", 50);
        item8.Description = "A refreshing sparkling apple cider, served chilled.";
        item8.ImageUrl = "/images/cider.jpg";

        items.Add(item1);
        items.Add(item2);
        items.Add(item3);
        items.Add(item4);
        items.Add(item5);
        items.Add(item6);
        items.Add(item7);
        items.Add(item8);

        return items;
    }
}