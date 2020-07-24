package com.greenfoxacademy.groot.models;

import com.fasterxml.jackson.annotation.JsonInclude;

@JsonInclude(JsonInclude.Include.NON_NULL)
public class Groot {

    String received;
    String translated;
    String error;

    public Groot() { }

    public Groot(String received) {
        if (received != null) {
            this.received = received;
            this.translated = "I am Groot!";
        }
        else this.error = "I am Groot!";
    }

    public String getReceived() { return received; }
    public void setReceived(String received) { this.received = received; }

    public String getTranslated() { return translated; }
    public void setTranslated(String translated) { this.translated = translated; }

    public String getError() { return error; }
    public void setError(String error) { this.error = error; }
}
