package com.greenfoxacademy.greenfoxacademy.models;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class ToDo {

    @Id
    @GeneratedValue(strategy = GenerationType.SEQUENCE)
    private Long id;
    private String title;
    private boolean urgent;
    private boolean done;

    public ToDo() {}

    public ToDo(Long id) {
        this.id = id;
        title = "unknown";
        urgent = false;
        done = false;
    }

    public ToDo(Long id, String title) {
        this.id = id;
        this.title = title;
        urgent = false;
        done = false;
    }

    public Long getId() {
        return id;
    }
    public void setId(Long id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }
    public void setTitle(String title) {
        this.title = title;
    }
}
