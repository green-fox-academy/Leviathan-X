package com.greenfoxacademy.basicwebshop.models;

import java.util.ArrayList;
import java.util.List;

public class WebShop {
    List<ShopItem> items;

    public WebShop() {
        items = new ArrayList<>();
        ShopItem runningShoesNike = new ShopItem("Running shoes",
                "Nike running shoes for every day sport", 1000, 5);
        items.add(runningShoesNike);
        ShopItem printer = new ShopItem("Printer",
                "Some HP printer that will print pages", 3000, 2);
        items.add(printer);
        ShopItem cocaCola = new ShopItem("Coca Cola",
                "0.5l standard coke", 25, 0);
        items.add(cocaCola);
        ShopItem wokin = new ShopItem("Wokin",
                "Chicken with fried rice and WOKIN sauce", 119, 100);
        items.add(wokin);
        ShopItem tshirt = new ShopItem("T-shirt",
                "Blue with a corgi on a bike", 300, 1);
        items.add(tshirt);
    }

    public List<ShopItem> getItems() {
        return items;
    }
}
