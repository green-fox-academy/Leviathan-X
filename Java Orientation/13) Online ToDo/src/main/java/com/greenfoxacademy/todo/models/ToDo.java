package com.greenfoxacademy.todo.models;

import javax.persistence.*;

@Entity
public class ToDo {

    @Id
    @GeneratedValue(strategy = GenerationType.SEQUENCE)
    private Long id;
    private String title;
    private boolean urgent;
    private boolean done;

    @ManyToOne
    @JoinColumn()
    private Assignee assignee;

    public ToDo() {
    }

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

    public ToDo(String title, boolean urgent) {
        this.title = title;
        this.urgent = urgent;
        done = false;
    }

    public ToDo(String title, boolean urgent, boolean done) {
        this.title = title;
        this.urgent = urgent;
        this.done = done;
    }

    public ToDo(Long id, String title, boolean urgent, boolean done) {
        this.id = id;
        this.title = title;
        this.urgent = urgent;
        this.done = done;
    }

    public Long getId() { return id; }
    public void setId(Long id) { this.id = id; }

    public String getTitle() { return title; }
    public void setTitle(String title) { this.title = title; }

    public boolean getUrgent() { return urgent; }
    public void setUrgent(boolean urgent) { this.urgent = urgent; }

    public boolean isDone() { return done; }
    public void setDone(boolean done) { this.done = done; }

    public Assignee getAssignee() { return assignee; }
    public void setAssignee(Assignee assignee) { this.assignee = assignee; }
}
