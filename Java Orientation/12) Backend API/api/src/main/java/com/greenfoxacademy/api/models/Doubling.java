package com.greenfoxacademy.api.models;

import java.util.HashMap;
import java.util.Map;

public class Doubling {
    private Integer input;

    public Doubling(Integer input) {
        this.input = input;
    }

    public int getInput() { return input; }

    public Map<String, Object> getOutput() {
        Map<String, Object> output = new HashMap<>();

        if (input == null) {
            output.put("error", "Please provide an input!");
        }
        else {
            output.put("received", input);
            output.put("result", input * 2);
        }
        return output;
    }
}
