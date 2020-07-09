package com.greenfoxacademy.programmerfoxclub.controllers;

import com.greenfoxacademy.programmerfoxclub.models.Fox;
import com.greenfoxacademy.programmerfoxclub.models.Foxes;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import java.util.List;

@Controller
public class MainController {
    Foxes foxes;

    @Autowired
    public MainController(Foxes foxes) {
        this.foxes = foxes;
    }

    @GetMapping("/")
    public String indexPage(Model model) {
        List<Fox> foxList = foxes.getList();
        Fox foxOutput = null;
        for (Fox fox : foxList) {
            if(fox.getName().equals("Mr. Green")) foxOutput = fox;
        }

        model.addAttribute("fox", foxOutput);
        model.addAttribute("tricksCount", foxOutput.getTricks().size());
        return "index";
    }
}
