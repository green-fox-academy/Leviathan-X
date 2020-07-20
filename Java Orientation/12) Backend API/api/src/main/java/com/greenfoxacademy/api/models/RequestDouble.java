package com.greenfoxacademy.api.models;

public class RequestDouble {
    private final int input;

    public RequestDouble(int input) {
        this.input = input*2;
    }

    public int getInput() { return input; }
}
