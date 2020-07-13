package com.greenfoxacademy.programmerfoxclub.models;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

public class Fox {
    private String name;
    private List<String> tricks;
    private String food;
    private String drink;
    private List<String> actions;

    public Fox(String name) {
        this.name = name;
        food = "salad";
        drink = "water";
        tricks = new ArrayList<>();
        actions = new ArrayList<>();
    }

    public Fox(String name, String food, String drink, List<String> tricks) {
        this.name = name;
        this.food = food;
        this.drink = drink;
        this.tricks = tricks;
        actions = new ArrayList<>();
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

    public void setFood(String food) {
        String oldfood = this.food;
        this.food = food;
        if (!oldfood.equals(food))
        actions.add(String.format(getTime() + " : Food has been changed from: %s to: %s",
                oldfood, food));
    }

    public void setDrink(String drink) {
        String olddrink = this.drink;
        this.drink = drink;
        if (!olddrink.equals(drink))
            actions.add(String.format(getTime() + " : Drink has been changed from: %s to: %s",
                    olddrink, drink));
    }

    public void addTrick(String trick) {
        tricks.add(trick);
        actions.add(String.format(getTime() + " : Learned to: %s", trick));
    }

    public boolean searchForTrick(String input) {
        for (String trick : tricks) {
            if (trick.equals(input)) return true;
        }
        return false;
    }

    public List<String> getActions() {
        return actions;
    }

    public List<String> getActionsLastFive() {
        List<String> lastFive;
        if (actions.size() > 5) {
            lastFive = actions.stream()
                    .skip(actions.size() - 5)
                    .collect(Collectors.toList());
        }
        else {
            lastFive = new ArrayList<>();
            lastFive.addAll(actions);
        }
        return lastFive;
    }

    public int getActionSize() {
        return actions.size();
    }

    public String getTime() {
        return new SimpleDateFormat("dd-MM-yyyy HH:mm:ss").format(new Date());
    }
}
