package com.greenfoxacademy.bankofsimba.models;

public class BankAccount {
    private String name;
    private double balance;
    private String animalType;
    private boolean kingStatus;
    private Morality morality;

    public BankAccount(String name, double balance, String animalType, Morality morality) {
        this.name = name;
        this.balance = balance;
        this.animalType = animalType;
        this.kingStatus = false;
        this.morality = Morality.GOOD;
    }

    public BankAccount(String name, double balance, String animalType, boolean kingStatus, Morality morality) {
        this.name = name;
        this.balance = balance;
        this.animalType = animalType;
        this.kingStatus = kingStatus;
        this.morality = morality;
    }

    public String getName() {
        return name;
    }

    public double getBalance() {
        return balance;
    }

    public String getAnimalType() {
        return animalType;
    }

    public boolean getKingStatus() {
        return kingStatus;
    }

    public String getMoralStatus() {
        // String moralityGet = morality.toString().toLowerCase();
        // String moralityOutput = moralityGet.substring(0, 1).toUpperCase() + moralityGet.substring(1) + " guy";
        // return moralityOutput;
        String moralityToString = morality.toString();
        return moralityToString;
    }

    public void donateToBalance() {
        if (kingStatus) balance += 100;
        else balance += 10;
    }
}
