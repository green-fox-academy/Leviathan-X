package com.greenfoxacademy.bankofsimba.controllers;

import com.greenfoxacademy.bankofsimba.models.Bank;
import com.greenfoxacademy.bankofsimba.models.BankAccount;
import com.greenfoxacademy.bankofsimba.models.Morality;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class BankController {
    private Bank bank;

    public BankController() {
        bank = new Bank();
    }

    @GetMapping("/showSimba")
    public String showOneAccount(Model model) {
        BankAccount simba = new BankAccount("Simba", 2000.00, "Lion", false, Morality.GOOD);
        model.addAttribute("simba", simba);
        return "show";
    }

    @GetMapping("/spam")
    public String spamString(Model model) {
        String spam = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
        model.addAttribute("spam", spam);
        return "spamString";
    }

    @GetMapping("/showAll")
    public String showAllAccounts(Model model) {
        model.addAttribute("accounts", bank.getAccounts());
        return "showAllAccounts";
    }

    @PostMapping("donate")
    public String donate(@RequestParam String animal) {
        for (BankAccount account : bank.getAccounts()) {
            if (account.getName().equals(animal)) account.donateToBalance();
        }
        return "redirect:/showAll";
    }

    @PostMapping("createNewAccount")
    public String addAccount(@RequestParam String inputName, @RequestParam int inputBalance,
                             @RequestParam String inputType, @RequestParam String inputMorality) {
        double convertedBalance = (double) inputBalance;
        Morality convertedMorality;
        if(inputMorality.equals("BAD")) convertedMorality = Morality.BAD;
        else convertedMorality = Morality.GOOD;

        String newInputName = inputName.toLowerCase();
        newInputName = inputName.substring(0, 1).toUpperCase() + inputName.substring(1);

        String newInputType = inputType.toLowerCase();
        newInputType = inputType.substring(0, 1).toUpperCase() + inputType.substring(1);

        bank.addAccount(new BankAccount(newInputName, convertedBalance, inputType, false, convertedMorality));
        return "redirect:/showAll";
    }
}
