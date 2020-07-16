package com.greenfoxacademy.reddit.services;

import com.greenfoxacademy.reddit.models.Post;

import java.util.List;

public interface PostService {

    List<Post> getAll();

    Post getPost(Long id);

    void createNew(String title, String text);

    void upvote(Long id);
    void downvote(Long id);
}
