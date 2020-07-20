package com.greenfoxacademy.api.models;

import java.util.HashMap;
import java.util.Map;

public class Greeter {
    private String name;
    private String title;

    public Greeter(String name, String title) {
        this.name = name;
        this.title = title;
    }

    public Map<String, String> getOutput() {
        Map<String, String> output = new HashMap<>();

        if (name == null && title == null) {
            output.put("error", "Please provide a name and a title!");
        }
        else if (name == null) {
            output.put("error", "Please provide a name!");
        }
        else if (title == null) {
            output.put("error", "Please provide a title!");
        }
        else {
            output.put("welcome_message", String.format("Oh, hi there %s, my dear %s!", name, title));
        }
        return output;
    }
}
