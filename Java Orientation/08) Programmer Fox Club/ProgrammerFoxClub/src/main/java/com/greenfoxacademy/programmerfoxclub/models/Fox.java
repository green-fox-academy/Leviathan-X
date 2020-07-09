package com.greenfoxacademy.programmerfoxclub.models;

import java.util.List;

public class Fox {
    private String name;
    private List<String> tricks;
    private String food;
    private String drink;

    public Fox(String name, String food, String drink, List<String> tricks) {
        this.name = name;
        this.food = food;
        this.drink = drink;
        this.tricks = tricks;
    }

    public String getName() {
        return name;
    }
    public String getFood() {
        return food;
    }
    public String getDrink() {
        return drink;
    }
    public List<String> getTricks() {
        return tricks;
    }
}
