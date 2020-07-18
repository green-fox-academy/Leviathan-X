package com.greenfoxacademy.reddit.models;

import javax.persistence.*;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@Entity
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private String username;
    private String email;
    private String password;
    @ElementCollection
    Map<Long, Boolean> votes;

    @OneToMany(mappedBy = "user")
    private List<Post> posts;

    public User() {
        votes = new HashMap<>();
    }

    public User(String username, String email, String password) {
        this.username = username;
        this.email = email;
        this.password = password;
        votes = new HashMap<>();
    }

    public Long getId() { return id; }

    public String getUsername() { return username; }
    public void setUsername(String username) { this.username = username; }

    public String getPassword() { return password; }
    public void setPassword(String password) { this.password = password; }

    public String getEmail() { return email; }
    public void setEmail(String email) { this.email = email; }

    public List<Post> getPosts() { return posts; }

    public Map<Long, Boolean> getVotes() { return votes; }
    public void setVotes(Map<Long, Boolean> votes) { this.votes = votes; }

}
