package com.greenfoxacademy.reddit.services;

import com.greenfoxacademy.reddit.models.Post;

import java.util.List;

public interface PostService {

    List<Post> getAll();
    List<Post> getAllSorted();

    Post getPost(Long id);

    void createNew(String title, String text, String username);

    void upvote(Long id, boolean votedStatus);
    void downvote(Long id, boolean votedStatus);
}
