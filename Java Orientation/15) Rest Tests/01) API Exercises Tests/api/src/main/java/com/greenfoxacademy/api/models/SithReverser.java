package com.greenfoxacademy.api.models;

import com.fasterxml.jackson.annotation.JsonInclude;

@JsonInclude(JsonInclude.Include.NON_NULL)
public class SithReverser {
    private String text;
    private String sithText;

    public SithReverser() {}

    public SithReverser(String text) {
        this.text = text;
    }

    public String getText() { return text; }
    public void setText(String text) { this.text = text; }

    public String getSithText() { return sithText; }
    public void setSithText(String sithText) { this.sithText = sithText; }
}
