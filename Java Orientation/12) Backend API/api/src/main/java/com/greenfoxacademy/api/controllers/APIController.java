package com.greenfoxacademy.api.controllers;

import com.greenfoxacademy.api.models.RequestDouble;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.Map;

@RestController
public class APIController {
    @GetMapping("/doubling")
    public Map<String, Object> doublingPage(@RequestParam(value = "input", required = false) Integer input) {
        return new RequestDouble(input).getOutput();
    }
}
