package com.greenfoxacademy.greenfoxacademy.models;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Assignee {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    private String name;
    private String email;

    public Assignee() {}

    public Assignee(long id) {
        this.id = id;
        name = "unknown";
        email = "unknown";
    }
    public Assignee(String name, String email) {
        this.name = name;
        this.email = email;
    }
    public Assignee(String name) {
        this.name = name;
    }
    public Assignee(long id, String name, String email) {
        this.id = id;
        this.name = name;
        this.email = email;
    }

    public long getId() { return id; }
    public void setId(long id) { this.id = id; }

    public String getName() { return name; }
    public void setName(String name) { this.name = name; }

    public String getEmail() { return email; }
    public void setEmail(String email) { this.email = email; }

}
