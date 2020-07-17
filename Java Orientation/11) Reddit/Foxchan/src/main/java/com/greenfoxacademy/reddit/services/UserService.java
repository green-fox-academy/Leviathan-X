package com.greenfoxacademy.reddit.services;

import com.greenfoxacademy.reddit.models.User;

import java.util.List;

public interface UserService {

    List<User> getAll();

    User getUser(Long id);

    void createNew(String username, String email, String password);

    boolean checkMatch(String password, String passwordCheck);
}
