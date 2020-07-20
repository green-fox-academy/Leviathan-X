package com.greenfoxacademy.api.models;

import javax.servlet.http.HttpServletResponse;
import java.util.HashMap;
import java.util.Map;

public class AppendA {
    private String appendable;

    public AppendA(String appendable) {
        this.appendable = appendable;
    }

    public Map<String, String> getOutput(HttpServletResponse response) {
        Map<String, String> output = new HashMap<>();

        if (appendable == null) {
            response.setStatus(HttpServletResponse.SC_BAD_REQUEST);
            output.put("error", "fuck!");
            return output;
        }
        else {
            response.setStatus(HttpServletResponse.SC_OK);
            output.put("appended", appendable + "a");
            return output;
        }
    }
}
