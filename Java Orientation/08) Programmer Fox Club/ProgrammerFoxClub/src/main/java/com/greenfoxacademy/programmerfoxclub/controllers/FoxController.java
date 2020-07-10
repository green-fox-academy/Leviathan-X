package com.greenfoxacademy.programmerfoxclub.controllers;

import com.greenfoxacademy.programmerfoxclub.models.Fox;
import com.greenfoxacademy.programmerfoxclub.models.Foxes;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.List;

@Controller
public class FoxController {
    Foxes foxes;


    @Autowired
    public FoxController(Foxes foxes) {
        this.foxes = foxes;
    }

    @GetMapping("/nutritionStore")
    public String storePage(Model model, @RequestParam String name) {
        if (name == null) return "redirect:/login";
        if (!foxes.searchListForInput(name)) return "redirect:/login";

        Fox foxOutput = foxes.getFox(name);
        model.addAttribute("fox", foxOutput);
        model.addAttribute("tricksCount", foxOutput.getTricks().size());
        return "store";
    }

    @PostMapping("/nutritionStore")
    public String storeSend(Model model,
                            @RequestParam String name, @RequestParam String food, @RequestParam String drink) {
        if (name == null) return "redirect:/login";
        if (!foxes.searchListForInput(name)) return "redirect:/login";
        Fox fox = foxes.getFox(name);
        fox.setFood(food);
        fox.setDrink(drink);

        model.addAttribute("fox", fox);
        return "redirect:/?name=" + name;
    }

    @GetMapping("/trickCenter")
    public String trickCenterPage(Model model, @RequestParam String name) {
        if (name == null) return "redirect:/login";
        if (!foxes.searchListForInput(name)) return "redirect:/login";

        Fox foxOutput = foxes.getFox(name);
        model.addAttribute("fox", foxOutput);
        return "trickCenter";
    }

    @PostMapping("/trickCenter")
    public String trickCenterSend(Model model,
                                  @RequestParam String name, @RequestParam String trick) {
        if (name == null) return "redirect:/login";
        if (!foxes.searchListForInput(name)) return "redirect:/login";
        Fox fox = foxes.getFox(name);

        if (!fox.searchForTrick(trick)) fox.addTrick(trick);

        model.addAttribute("fox", fox);
        return "redirect:/?name=" + name;
    }

    @GetMapping("/actionHistory")
    public String actionHistoryPage(Model model, @RequestParam String name) {
        if (name == null) return "redirect:/login";
        if (!foxes.searchListForInput(name)) return "redirect:/login";
        Fox fox = foxes.getFox(name);

        model.addAttribute("fox", fox);
        return "actionHistory";
    }
}
