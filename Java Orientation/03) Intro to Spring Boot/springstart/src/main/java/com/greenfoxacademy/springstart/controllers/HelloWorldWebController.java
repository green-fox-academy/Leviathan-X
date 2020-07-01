package com.greenfoxacademy.springstart.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.HashMap;

@Controller
public class HelloWorldWebController {
    HashMap<String, String> hellos;

    public HelloWorldWebController() {
        hellos = new HashMap<String, String>() {
            {
                put("eng", "Hello");
                put("cze", "Smrdíš jako prase");
                put("rus", "Privyet");
                put("fre", "Bonjour");
            }
        };
    }

    @RequestMapping (value = "/web/greeting/lang")
    public String greeting(Model model, @RequestParam String input) {
        String lang = hellos.get(input);
        model.addAttribute("lang", lang);
        return "greetingLang";
    }
}
