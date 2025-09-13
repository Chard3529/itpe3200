using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MyShop.ViewModels;
using MyShop.Models;

namespace MyShop.Controllers;

public class ItemController : Controller
{

    // GET localhost/Item/Table 
    public IActionResult Table()
    {
        var items = GetItems();
        var itemsViewModel = new ItemsViewModel(items, "Table");
        return View(itemsViewModel);
    }

    // GET localhost/Item/Grid
    public IActionResult Grid()
    {
        var items = GetItems();
        var itemsViewModel = new ItemsViewModel(items, "Grid");
        return View(itemsViewModel);
    }

    // Get localhost/Item/Details/itemid
    public IActionResult Details(int id)
    {
        var items = GetItems();
        var item = items.FirstOrDefault(i => i.ItemId == id);

        if (item == null)
        {
            return NotFound();
        }
        else
        {
            return View(item);
        }
        
    }
    public List<Item> GetItems()
    {
        // A list for storing the items
        var items = new List<Item>();

        var item1 = new Item(1, "Vegan Chicken Leg", 60,
            "Delicious crispy soy chicken leg, with bbq sauce",
            "/images/chickenleg.jpg");

        var item2 = new Item(2, "Pizza", 80,
            "An Italian style pizza with vegan cheese, corn hotdogs and a creamy sauce",
            "/images/pizza.jpg");

        var item3 = new Item(3, "French Fries", 60,
            "Our freshly cut fries, served with vegan mayo and ketchup",
            "/images/frenchfries.jpg");

        var item4 = new Item(4, "Vegan Ribs", 120,
            "Tender plant-based ribs glazed with smoky BBQ sauce, served with a side of slaw.",
            "/images/ribs.jpg");

        var item5 = new Item(5, "Vegan Tacos", 90,
            "Three soft tacos filled with spiced soy protein, fresh veggies, and creamy guacamole.",
            "/images/tacos.jpg");

        var item6 = new Item(6, "Vegan Fish & Chips", 110,
            "Crispy battered soy-based fish fillet with golden fries and tartar sauce.",
            "/images/fishandchips.jpg");

        var item7 = new Item(7, "Coca Cola", 40,
            "A refreshing glass bottle of chilled Coca Cola.",
            "/images/coke.jpg");

        var item8 = new Item(8, "Apple Cider", 50,
            "A refreshing sparkling apple cider, served chilled.",
            "/images/cider.jpg");

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