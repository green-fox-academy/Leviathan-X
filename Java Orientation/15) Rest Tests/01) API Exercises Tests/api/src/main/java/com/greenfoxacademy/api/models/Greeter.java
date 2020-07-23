package com.greenfoxacademy.api.models;

import javax.servlet.http.HttpServletResponse;
import java.util.HashMap;
import java.util.Map;

public class Greeter {
    private String name;
    private String title;

    public Greeter(String name, String title) {
        this.name = name;
        this.title = title;
    }

    public Map<String, String> run(HttpServletResponse response) {
        Map<String, String> output = new HashMap<>();

        if (name == null && title == null) {
            response.setStatus(400);    // HttpServletResponse.SC_BAD_REQUEST
            output.put("error", "Please provide a name and a title!");
        }
        else if (name == null) {
            response.setStatus(400);
            output.put("error", "Please provide a name!");
        }
        else if (title == null) {
            response.setStatus(400);
            output.put("error", "Please provide a title!");
        }
        else {
            response.setStatus(200); // HttpServletResponse.SC_OK
            output.put("welcome_message", String.format("Oh, hi there %s, my dear %s!", name, title));
        }
        return output;
    }
}
