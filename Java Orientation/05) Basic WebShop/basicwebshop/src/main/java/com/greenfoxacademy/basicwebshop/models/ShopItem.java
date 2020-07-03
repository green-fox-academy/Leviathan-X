package com.greenfoxacademy.basicwebshop.models;

public class ShopItem {
    private String name;
    private String description;
    private double price;
    private int quantityOfStock;

    public ShopItem(String name) {
        this.name = name;
        description = "No description";
        price = 5;
        quantityOfStock = 1;
    }
    public ShopItem(String name, String description) {
        this.name = name;
        this.description = description;
        price = 5;
        quantityOfStock = 1;
    }
    public ShopItem(String name, String description, double price) {
        this.name = name;
        this.description = description;
        this.price = price;
        quantityOfStock = 1;
    }
    public ShopItem(String name, String description, double price, int quantityOfStock) {
        this.name = name;
        this.description = description;
        this.price = price;
        this.quantityOfStock = quantityOfStock;
    }

    public String getName() {
        return name;
    }
    public String getDescription() {
        return description;
    }
    public double getPrice() {
        return price;
    }
    public int getQuantityOfStock() {
        return quantityOfStock;
    }
}
