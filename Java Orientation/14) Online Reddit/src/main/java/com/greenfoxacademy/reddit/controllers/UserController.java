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
    public String registerPOST(Model model, @RequestParam(value = "passwordCheck") String passwordCheck,
                               @ModelAttribute("user") User user) {
        if (userService.getUserByUsername(user.getUsername()) != null) {
            model.addAttribute("match", "userNameExists");
            return "register";
        }
        else if (userService.getUserByEmail(user.getEmail()) != null) {
            model.addAttribute("match", "emailExists");
            return "register";
        }

        if (userService.checkMatch(user.getPassword(), passwordCheck)) {
            model.addAttribute("match", "true");
            userService.createNew(user.getUsername(), user.getEmail(), user.getPassword());
        }
        else model.addAttribute("match", "false");
        return "register";
    }

    @GetMapping("/login")
    public String loginGet(Model model, @RequestParam(required = false, value = "loginAttempt") String loginAttempt) {
        model.addAttribute("loginAttempt", loginAttempt);
        return "login";
    }

    @PostMapping("/login")
    public String loginPOST(Model model, @ModelAttribute("user") User user) {
        if (userService.getUserByUsername(user.getUsername()) == null) {
            model.addAttribute("loginAttempt", "usernameFail");
            return "login";
        }
        else if (!userService.getUserByUsername(user.getUsername()).getPassword().equals(user.getPassword())) {
            model.addAttribute("loginAttempt", "passwordFail");
            return "login";
        }
        else model.addAttribute("username", user.getUsername());
        return "redirect:/foxchan/" + user.getUsername() + "/index";
    }
}
