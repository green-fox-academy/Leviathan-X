package com.greenfoxacademy.helloworld;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import java.time.LocalDateTime;

@Service
public class Printer {
    MyColor color;

    @Autowired
    public Printer(MyColor color) {
        this.color = color;
    }

    public void log(String message) {
        System.out.println(LocalDateTime.now() + " MY PRINTER SAYS --- \"" + message + "\"" + color.printColor());
    }
}