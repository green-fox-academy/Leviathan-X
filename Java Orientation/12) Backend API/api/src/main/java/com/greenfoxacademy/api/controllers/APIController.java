package com.greenfoxacademy.api.controllers;

import com.greenfoxacademy.api.models.AppendA;
import com.greenfoxacademy.api.models.Doubling;
import com.greenfoxacademy.api.models.Greeter;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import javax.servlet.http.HttpServletResponse;
import java.util.HashMap;
import java.util.Map;

@RestController
public class APIController {

    @GetMapping("/doubling")
    public Map<String, Object> doublingRequest(@RequestParam(value = "input", required = false) Integer input) {
        return new Doubling(input).getOutput();
    }

    @GetMapping("/greeter")
    public Map<String, String> greeterRequest(@RequestParam(value = "name", required = false) String name,
                                              @RequestParam(value = "title", required = false) String title,
                                              HttpServletResponse response) {
        if (name == null && title == null) {
            return new Greeter(null, null).getOutput(response);
        }
        else if (name == null) {
            return new Greeter(null, title).getOutput(response);
        }
        else if (title == null) {
            return new Greeter(name, null).getOutput(response);
        }
        else {
            return new Greeter(name, title).getOutput(response);
        }
    }

    @GetMapping("/appenda/{appendable}")
    public Map<String, String> appendARequest(@PathVariable(value = "appendable") String appendable,
                                              HttpServletResponse response) {
        Map<String, String> output = new HashMap<>();

        if (appendable == null) {
            response.setStatus(HttpServletResponse.SC_BAD_REQUEST);
            output.put("error", "fuck!");
            return output;
        }
        else {
            response.setStatus(HttpServletResponse.SC_OK);
            output.put("appended", new AppendA(appendable).run());
            return output;
        }
    }
}
