package com.greenfoxacademy.bankofsimba.models;

import java.util.ArrayList;

public class Bank {
    private ArrayList<BankAccount> accounts;

    public Bank() {
        accounts = new ArrayList<>();
        BankAccount simba = new BankAccount("Simba", 2000.00, "Lion", false, Morality.GOOD);
        accounts.add(simba);
        BankAccount mufasa = new BankAccount("Mufasa", 40000.00, "Lion", true, Morality.GOOD);
        accounts.add(mufasa);
        BankAccount rafiki = new BankAccount("Rafiki", 20000.00, "Monkey", false, Morality.GOOD);
        accounts.add(rafiki);
        BankAccount pumbaa = new BankAccount("Pumbaa", 15000.00, "Boar", false, Morality.GOOD);
        accounts.add(pumbaa);
        BankAccount scar = new BankAccount("Scar", 25000.00, "Lion", false, Morality.BAD);
        accounts.add(scar);
    }

    public ArrayList<BankAccount> getAccounts() {
        return accounts;
    }

    public void addAccount(BankAccount newAccount) {
        accounts.add(newAccount);
    }
}
