package com.greenfoxacademy.springstart.controllers;

public class Greeting {
    private long id;
    private String content;

    public Greeting() {
        id = 1;
        content = "Greetings!";
    }
    public Greeting(String Content) {
        id = 1;
        content = Content;
    }
    public Greeting(String Content, long ID) {
        id = ID;
        content = Content;
    }

    public long getID() {
        return id;
    }

    public String getContent() {
        return content;
    }
}
