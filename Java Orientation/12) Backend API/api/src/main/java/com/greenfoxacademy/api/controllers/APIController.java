package com.greenfoxacademy.api.controllers;

import com.greenfoxacademy.api.models.AppendA;
import com.greenfoxacademy.api.models.DoUntil;
import com.greenfoxacademy.api.models.Doubling;
import com.greenfoxacademy.api.models.Greeter;
import com.greenfoxacademy.api.services.ActionServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpServletResponse;
import java.util.Map;

@RestController
public class APIController {

    ActionServiceImpl actionServiceImpl;

    @Autowired
    public APIController(ActionServiceImpl actionServiceImpl) {
        this.actionServiceImpl = actionServiceImpl;
    }

    @GetMapping("/doubling")
    public Map<String, Object> doublingRequest(@RequestParam(value = "input", required = false) Integer input) {
        return new Doubling(input).getOutput();
    }

    @GetMapping("/greeter")
    public Map<String, String> greeterRequest(@RequestParam(value = "name", required = false) String name,
                                              @RequestParam(value = "title", required = false) String title,
                                              HttpServletResponse response) {
        return new Greeter(name, title).run(response);
    }

    @GetMapping("/appenda/{appendable}")
    public Map<String, String> appendARequest(@PathVariable(value = "appendable") String appendable,
                                              HttpServletResponse response) {
        return new AppendA(appendable).run(response);
    }

    @PostMapping("/dountil/{action}")
    public Map<String, Object> doUntilRequest(@PathVariable(value = "action") String action,
                                               @RequestBody(required = false) DoUntil doUntil,
                                               HttpServletResponse response) {
        return actionServiceImpl.runDoUntil(action, doUntil, response);
    }
}
