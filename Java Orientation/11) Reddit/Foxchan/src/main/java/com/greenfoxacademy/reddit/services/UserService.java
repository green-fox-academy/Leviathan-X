package com.greenfoxacademy.reddit.services;

import com.greenfoxacademy.reddit.models.User;

import java.util.List;

public interface UserService {

    List<User> getAll();

    User getUser(Long id);
    User getUserByUsername(String username);
    User getUserByEmail(String email);

    void createNew(String username, String email, String password);

    boolean checkMatch(String password, String passwordCheck);

    void upvotePost(Long id, String username);
    void downvotePost(Long id, String username);
}
