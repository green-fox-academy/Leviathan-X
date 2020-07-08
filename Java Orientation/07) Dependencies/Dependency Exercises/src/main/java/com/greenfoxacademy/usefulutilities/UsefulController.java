package com.greenfoxacademy.usefulutilities;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class UsefulController {
    UtilityService utilityService;

    @Autowired
    public UsefulController(UtilityService utilityService) {
        this.utilityService = utilityService;
    }

    @GetMapping("/useful")
    public String mainPage(Model model) {
        return "showAllUtilities";
    }

    @GetMapping("/useful/colored")
    public String coloredPage(Model model) {
        model.addAttribute("randomColor", utilityService.randomColor());
        return "randomBackground";
    }

    @GetMapping("/useful/email")
    public String emailPage(Model model, @RequestParam String email) {
        model.addAttribute("emailColor", utilityService.emailValidator(email));
        return "showAllUtilities";
    }

    @GetMapping("/useful/caesar/encode")
    public String encode(Model model, @RequestParam String text, @RequestParam int number) {
        model.addAttribute("encode", utilityService.caesar(text, number));
        return "showAllUtilities";
    }

    @GetMapping("/useful/caesar/decode")
    public String decode(Model model, @RequestParam String text, @RequestParam int number) {
        model.addAttribute("decode", utilityService.caesar(text, number));
        return "showAllUtilities";
    }
}
