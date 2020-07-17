package com.greenfoxacademy.reddit.controllers;

import com.greenfoxacademy.reddit.models.Post;
import com.greenfoxacademy.reddit.repositories.PostRepository;
import com.greenfoxacademy.reddit.services.PostService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping(value = "/foxchan")
public class PostController {

    private PostService postService;
    private PostRepository postRepository;

    @Autowired
    public PostController(PostService postService, PostRepository postRepository) {
        this.postService = postService;
        this.postRepository = postRepository;
    }

    @GetMapping({"", "/"})
    public String homePage(Model model) {
        model.addAttribute("posts", postService.getAllSorted());
        return "index";
    }

    @GetMapping("/submit")
    public String submitPostGET() {
        return "add-post";
    }

    @PostMapping("/add-post")
    public String submitPostPOST(@ModelAttribute("post") Post post) {
        postService.createNew(post.getTitle(), post.getText());
        return "redirect:/foxchan/";
    }

    @GetMapping("/post/{id}")
    public String postDetails(Model model, @PathVariable long id) {
        model.addAttribute("post", postService.getPost(id));
        return "postDetails";
    }

    @GetMapping("/post/upvote/{id}")
    public String postUpvote(@PathVariable long id) {
        postService.upvote(id);
        return "redirect:/foxchan/";
    }

    @GetMapping("/post/downvote/{id}")
    public String postDownvote(@PathVariable long id) {
        postService.downvote(id);
        return "redirect:/foxchan/";
    }

}
