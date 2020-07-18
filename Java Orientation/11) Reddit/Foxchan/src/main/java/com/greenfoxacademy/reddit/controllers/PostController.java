package com.greenfoxacademy.reddit.controllers;

import com.greenfoxacademy.reddit.models.Post;
import com.greenfoxacademy.reddit.models.User;
import com.greenfoxacademy.reddit.repositories.PostRepository;
import com.greenfoxacademy.reddit.services.PostService;
import com.greenfoxacademy.reddit.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping(value = "/foxchan")
public class PostController {

    private PostService postService;
    private PostRepository postRepository;
    private UserController userController;
    private UserService userService;

    @Autowired
    public PostController(PostService postService, PostRepository postRepository,
                          UserController userController, UserService userService) {
        this.postService = postService;
        this.postRepository = postRepository;
        this.userController = userController;
        this.userService = userService;
    }

    @GetMapping("/{username}/index")
    public String indexPage(Model model, @PathVariable String username) {
        if (username.equals(null)) return "redirect:/";
        if (userService.getUserByUsername(username) == null) return "redirect:/";

        model.addAttribute("posts", postService.getAllSorted());
        model.addAttribute("username", username);
        return "index";
    }

    @GetMapping("/{username}/submit")
    public String submitPostGET(Model model, @PathVariable String username) {
        if (username.equals(null)) return "redirect:/";
        if (userService.getUserByUsername(username) == null) return "redirect:/";
        model.addAttribute("username", username);
        return "/add-post";
    }

    @PostMapping("/{username}/submit/add-post")
    public String submitPostPOST(@ModelAttribute("post") Post post,
                                 @PathVariable String username) {
        postService.createNew(post.getTitle(), post.getText(), username);
        return "redirect:/" + username + "/index";
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
