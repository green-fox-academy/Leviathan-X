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
}
