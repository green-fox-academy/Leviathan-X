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
public class MainController {
    FoxService foxService;

    @Autowired
    public MainController(FoxService foxService) {
        this.foxService = foxService;
    }

    @GetMapping("/")
    public String indexPage(Model model, @RequestParam(required = false) String name) {
        if (name == null) return "redirect:/login";
        if (!foxService.searchListForInput(name)) return "redirect:/login";
        if (name.equals("")) return "redirect:/login";

        model.addAttribute("fox", foxService.getFox(name));
        model.addAttribute("tricksCount", foxService.getFox(name).getTricks().size());
        model.addAttribute("lastFive", foxService.getFox(name).getActionsLastFive());
        return "index";
    }

    @GetMapping("/login")
    public String loginPage() {
        return "login";
    }

    @PostMapping("/login")
    public String loginPost(@RequestParam String name) {
        if (!foxService.searchListForInput(name)) foxService.addToList(new Fox(name));

        return "redirect:/?name=" + name;
    }
}
