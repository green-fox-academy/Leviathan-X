package com.greenfoxacademy.foxclub.controllers;

import com.greenfoxacademy.foxclub.models.Fox;
import com.greenfoxacademy.foxclub.services.FoxService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class FoxController {
    FoxService foxService;

    @Autowired
    public FoxController(FoxService foxService) {
        this.foxService = foxService;
    }

    @GetMapping("/nutritionStore")
    public String storePage(Model model, @RequestParam String name) {
        if (name == null) return "redirect:/login";
        if (!foxService.searchListForInput(name)) return "redirect:/login";

        model.addAttribute("fox", foxService.getFox(name));
        model.addAttribute("tricksCount", foxService.getFox(name).getTricks().size());
        return "store";
    }

    @PostMapping("/nutritionStore")
    public String storeSend(Model model, @RequestParam String name,
                            @RequestParam String food, @RequestParam String drink) {
        if (name == null) return "redirect:/login";
        if (!foxService.searchListForInput(name)) return "redirect:/login";
        
        Fox fox = foxService.getFox(name);
        fox.setFood(food);
        fox.setDrink(drink);

        model.addAttribute("fox", fox);
        return "redirect:/?name=" + name;
    }

    @GetMapping("/trickCenter")
    public String trickCenterPage(Model model, @RequestParam String name) {
        if (name == null) return "redirect:/login";
        if (!foxService.searchListForInput(name)) return "redirect:/login";

        model.addAttribute("fox", foxService.getFox(name));
        return "trickCenter";
    }

    @PostMapping("/trickCenter")
    public String trickCenterSend(Model model,
                                  @RequestParam String name, @RequestParam String trick) {
        if (name == null) return "redirect:/login";
        if (!foxService.searchListForInput(name)) return "redirect:/login";
        Fox fox = foxService.getFox(name);

        if (!fox.searchForTrick(trick)) fox.addTrick(trick);

        model.addAttribute("fox", fox);
        return "redirect:/?name=" + name;
    }

    @GetMapping("/actionHistory")
    public String actionHistoryPage(Model model, @RequestParam String name) {
        if (name == null) return "redirect:/login";
        if (!foxService.searchListForInput(name)) return "redirect:/login";
        Fox fox = foxService.getFox(name);

        model.addAttribute("fox", fox);
        return "actionHistory";
    }
}
