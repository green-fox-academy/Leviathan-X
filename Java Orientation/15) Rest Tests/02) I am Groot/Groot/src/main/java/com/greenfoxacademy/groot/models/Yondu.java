package com.greenfoxacademy.groot.models;

import com.fasterxml.jackson.annotation.JsonInclude;

@JsonInclude(JsonInclude.Include.NON_NULL)
public class Yondu {

    private Double distance;
    private Double time;
    private Double speed;
    private String error;

    public Yondu(Double distance, Double time) {
        if (distance == null || time == null) {
            error = "Fuck!";
        }
        else {
            this.distance = distance;
            this.time = time;
            speed = distance / time;
        }
    }

    public Double getDistance() { return distance; }
    public void setDistance(Double distance) { this.distance = distance; }

    public Double getTime() { return time; }
    public void setTime(Double time) { this.time = time; }

    public Double getSpeed() { return speed; }
    public void setSpeed(Double speed) { this.speed = speed; }

    public String getError() { return error; }
    public void setError(String error) { this.error = error; }
}
