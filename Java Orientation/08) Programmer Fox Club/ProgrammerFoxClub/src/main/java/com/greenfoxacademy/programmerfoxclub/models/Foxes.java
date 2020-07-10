package com.greenfoxacademy.programmerfoxclub.models;

import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

@Component
public class Foxes {
    List<Fox> foxes;

    public Foxes() {
        foxes = new ArrayList<>();
        foxes.add(new Fox("Arnold", "schnitzel", "almdudler",
                new ArrayList<String>(Arrays.asList("terminating", "coming back"))));
        foxes.add(new Fox("Mr. Green", "salad", "water", new ArrayList<String>()));
    }

    public List<Fox> getList() {
        return foxes;
    }

    public void addToList(Fox fox) {
        foxes.add(fox);
    }

    public boolean searchListForInput(String input) {
        for (Fox fox : foxes) {
            if (fox.getName().equals(input)) return true;
        }
        return false;
    }

    public Fox getFox(String name) {
        Fox foxOutput = null;
        for (Fox fox : foxes) {
            if(fox.getName().equals(name)) foxOutput = fox;
        }
        return foxOutput;
    }
}
