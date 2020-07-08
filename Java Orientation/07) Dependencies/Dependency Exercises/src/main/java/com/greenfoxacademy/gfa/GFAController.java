package com.greenfoxacademy.gfa;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class GFAController {

    @GetMapping("/gfa")
    public String mainPage(Model model) {
        return "gfaMain";
    }
}
