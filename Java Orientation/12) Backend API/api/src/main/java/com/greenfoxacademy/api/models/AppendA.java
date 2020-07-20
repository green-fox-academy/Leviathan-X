package com.greenfoxacademy.api.models;

public class AppendA {
    private String appendable;

    public AppendA(String appendable) {
        this.appendable = appendable;
    }

    public String run() {
        return appendable + "a";
    }
}
