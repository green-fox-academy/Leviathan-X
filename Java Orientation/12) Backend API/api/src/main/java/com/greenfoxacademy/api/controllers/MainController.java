package com.greenfoxacademy.api.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

// @RestController
@Controller
public class MainController {

    @GetMapping("/")
    public String mainPage() {

        return "index";
    }
}
