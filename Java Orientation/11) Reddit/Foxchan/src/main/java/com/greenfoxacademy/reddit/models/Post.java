package com.greenfoxacademy.reddit.models;

import javax.persistence.*;
import java.text.SimpleDateFormat;
import java.util.Date;

@Entity
public class Post {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private int votes;
    private String title;
    private String text;
    private String date;

    @ManyToOne
    private User user;

    public Post() { this.date = new SimpleDateFormat("dd-MM-yyyy HH:mm").format(new Date()); }

    public Post(String title, String text, User user) {
        votes = 0;
        this.title = title;
        this.text = text;
        this.date = new SimpleDateFormat("HH:mm:ss dd-MM-yyyy").format(new Date());
        this.user = user;
    }
    public Post(long id, String title, String text, User user) {
        this.id = id;
        votes = 0;
        this.title = title;
        this.text = text;
        this.date = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss").format(new Date());
        this.user = user;
    }

    public Long getId() { return id; }

    public int getVotes() { return votes; }
    public void setVotes(int votes) { this.votes = votes; }

    public String getTitle() { return title; }
    public void setTitle(String title) { this.title = title; }

    public String getText() { return text; }
    public void setText(String text) { this.text = text; }

    public String getDate() { return date; }

    public User getUser() { return user; }
}
