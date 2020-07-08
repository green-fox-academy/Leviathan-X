package com.greenfoxacademy.helloworld;

import org.springframework.stereotype.Service;

@Service
public class ColorGold implements MyColor {

    @Override
    public String printColor() {
        return " in Gold color";
    }
}
