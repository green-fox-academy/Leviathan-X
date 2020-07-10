package com.greenfoxacademy.programmerfoxclub.controllers;

import com.greenfoxacademy.programmerfoxclub.models.Fox;
import com.greenfoxacademy.programmerfoxclub.models.Foxes;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;


@Controller
public class MainController {
    Foxes foxes;

    @Autowired
    public MainController(Foxes foxes) {
        this.foxes = foxes;
    }

    @GetMapping("/")
    public String indexPage(Model model, @RequestParam(required = false) String name) {
        if (name == null) return "redirect:/login";
        if (!foxes.searchListForInput(name)) return "redirect:/login";

        Fox foxOutput = foxes.getFox(name);

        model.addAttribute("fox", foxOutput);
        model.addAttribute("tricksCount", foxOutput.getTricks().size());
        return "index";
    }

    @GetMapping("/login")
    public String loginPage() {
        return "login";
    }

    @PostMapping("/login")
    public String loginPost(@RequestParam String name) {
        if (!foxes.searchListForInput(name)) foxes.addToList(new Fox(name));

        return "redirect:/?name=" + name;
    }
}
