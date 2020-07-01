package com.greenfoxacademy.springstart.controllers;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import java.util.concurrent.atomic.AtomicLong;

@RestController
public class HelloRESTController {
    private static AtomicLong greetCount;

    public HelloRESTController() {
        greetCount = new AtomicLong(1);
    }

    @ResponseBody
    @RequestMapping (value = "/greeting")
    public static String greeting(@RequestParam String name) {
        Greeting greet = new Greeting(name, greetCount.getAndIncrement());
        return "\"greetCount\" : " + greet.getID()
        + "</br>\"content\": Hello, " + greet.getContent() + "!";
    }
}
