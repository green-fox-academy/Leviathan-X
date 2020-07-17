package com.greenfoxacademy.reddit.controllers;

import com.greenfoxacademy.reddit.models.User;
import com.greenfoxacademy.reddit.repositories.PostRepository;
import com.greenfoxacademy.reddit.repositories.UserRepository;
import com.greenfoxacademy.reddit.services.PostService;
import com.greenfoxacademy.reddit.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class UserController {

    private PostService postService;
    private PostRepository postRepository;
    private UserService userService;
    private UserRepository userRepository;

    @Autowired
    public UserController(PostService postService, PostRepository postRepository,
                          UserService userService, UserRepository userRepository) {
        this.postService = postService;
        this.postRepository = postRepository;
        this.userService = userService;
        this.userRepository = userRepository;
    }

    @GetMapping({"", "/"})
    public String homePage(Model model) {
        return "homePage";
    }

    @GetMapping("/register")
    public String registerGET(Model model, @RequestParam(required = false) String match) {
        model.addAttribute("match", match);
        return "register";
    }

    @PostMapping("/register")
    public String registerPOST(Model model, @ModelAttribute("user") User user,
                               @RequestParam(value = "passwordCheck") String passwordCheck) {
        if (userService.checkMatch(user.getPassword(), passwordCheck)) {
            model.addAttribute("match", "true");
            userService.createNew(user.getUsername(), user.getEmail(), user.getPassword());
        }
        else model.addAttribute("match", "false");
        return "register";
    }
}
