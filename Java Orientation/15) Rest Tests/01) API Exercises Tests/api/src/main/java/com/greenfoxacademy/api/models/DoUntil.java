package com.greenfoxacademy.api.models;

public class DoUntil {
    private Integer until;

    public DoUntil() { }

    public DoUntil(Integer until) {
        this.until = until;
    }

    public Integer sum() {
        int sumo2 = until;
        int sumo = sumo2;
        for (int i = 1; i < until; i++) {
            sumo += i;
            sumo2 = sumo;
        }
        return sumo;
    }

    public Integer factor() {
        int facto2 = until;
        int facto = facto2;
        for (int i = 1; i < until; i++) {
            facto *= i;
            facto2 = facto;
        }
        return facto;
    }

    public Integer getUntil() { return until; }
    public void setUntil(Integer until) { this.until = until; }
}
