package com.greenfoxacademy.basicwebshop.controllers;

import com.greenfoxacademy.basicwebshop.models.ShopItem;
import com.greenfoxacademy.basicwebshop.models.WebShop;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

@Controller
public class WebShopController {
    private WebShop webShop;

    public WebShopController() {
        webShop = new WebShop();
    }

    @GetMapping("/webshop")
    public String showAllItems(Model model) {
        model.addAttribute("items", webShop.getItems());
        return "showAllItems";
    }

    @GetMapping("/webshop/only-available")
    public String showOnlyAvailable(Model model) {
        List<ShopItem> availableItems = webShop.getItems().stream()
                .filter(item -> item.getQuantityOfStock() > 0)
                .collect(Collectors.toList());
        model.addAttribute("items", availableItems);
        return "showAllItems";
    }

    @GetMapping("/webshop/cheapest-first")
    public String showCheapestFirst(Model model) {
        List<ShopItem> sortedByCheapestItems = webShop.getItems().stream()
                .sorted(Comparator.comparing(ShopItem::getPrice))
                .collect(Collectors.toList());
        model.addAttribute("items", sortedByCheapestItems);
        return "showAllItems";
    }

    @GetMapping("/webshop/contains-nike")
    public String showContainsNike(Model model) {
        List<ShopItem> containNikeItems = webShop.getItems().stream()
                .filter(item -> item.getName().toLowerCase().contains("nike")
                || item.getDescription().toLowerCase().contains("nike"))
                .collect(Collectors.toList());
        model.addAttribute("items", containNikeItems);
        return "showAllItems";
    }

    @GetMapping("/webshop/average-stock")
    public String showAverageStock(Model model) {
        double averageOfItems = webShop.getItems().stream()
                .mapToDouble(ShopItem::getQuantityOfStock)
                .average()
                .orElse(0);
        model.addAttribute("averageOfItems", averageOfItems);
        return "showAverageStock";
    }

    @GetMapping("/webshop/most-expensive")
    public String showMostExpensive(Model model) {
        List<ShopItem> mostExpensiveItems = webShop.getItems().stream()
                .sorted(Comparator.comparing(ShopItem::getPrice).reversed())
                .collect(Collectors.toList());
        List<ShopItem> mostExpensiveItem = new ArrayList<>();
        mostExpensiveItem.add(mostExpensiveItems.get(0));
        model.addAttribute("items", mostExpensiveItem);
        return "showAllItems";
    }

    @PostMapping("/webshop/search")
    public String search(@RequestParam String searchBar, Model model) {
        List<ShopItem> outputItems = webShop.getItems().stream()
                .filter(item -> item.getName().toLowerCase().contains(searchBar.toLowerCase())
                || item.getDescription().toLowerCase().contains(searchBar.toLowerCase()))
                .collect(Collectors.toList());
        model.addAttribute("items", outputItems);
        return "showAllItems";
    }
}
