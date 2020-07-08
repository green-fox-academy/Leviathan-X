package com.greenfoxacademy.helloworld;

import org.springframework.stereotype.Service;

//@Service
public class ColorRed implements MyColor{

    @Override
    public String printColor() {
        return " in Red color";
    }
}
