package com.greenfoxacademy.api.models;

import java.util.HashMap;
import java.util.Map;

public class RequestDouble {
    private Integer input;

    public RequestDouble(Integer input) {
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
            input = input * 2;
            output.put("result", new RequestDouble(input).getInput());
        }
        return output;
    }
}
