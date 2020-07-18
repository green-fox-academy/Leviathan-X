package com.greenfoxacademy.reddit.services;

import com.greenfoxacademy.reddit.models.User;
import com.greenfoxacademy.reddit.repositories.PostRepository;
import com.greenfoxacademy.reddit.repositories.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Map;

@Service
public class UserServiceImpl implements UserService {

    private UserRepository userRepository;
    private PostRepository postRepository;
    private PostService postService;

    @Autowired
    public UserServiceImpl(UserRepository userRepository, PostRepository postRepository,
                           PostService postService) {
        this.userRepository = userRepository;
        this.postRepository = postRepository;
        this.postService = postService;
    }

    @Override
    public List<User> getAll() {
        return userRepository.findAll();
    }

    @Override
    public User getUser(Long id) {
        return userRepository.getOne(id);
    }
    @Override
    public User getUserByUsername(String username) { return userRepository.findUserByUsername(username); }
    @Override
    public User getUserByEmail(String email) { return userRepository.findUserByEmail(email); }

    @Override
    public void createNew(String username, String email, String password) {
        userRepository.save(new User(username, email, password));
    }

    @Override
    public boolean checkMatch(String password, String passwordCheck) {
        if (password.equals(passwordCheck)) return true;
        else return false;
    }

    @Override
    public void upvotePost(Long id, String username) {
        User user = userRepository.findUserByUsername(username);
        Map<Long, Boolean> votes = user.getVotes();
        if (votes.containsKey(id) && votes.get(id) == false) {
            postService.upvote(id);
            votes.put(id, true);
        }
        if (!votes.containsKey(id)) {
            votes.put(id, true);
            postService.upvote(id);
        }
        user.setVotes(votes);
        userRepository.save(user);
    }

    @Override
    public void downvotePost(Long id, String username) {
        User user = userRepository.findUserByUsername(username);
        Map<Long, Boolean> votes = user.getVotes();
        if (votes.containsKey(id) && votes.get(id) == true) {
            postService.downvote(id);
            votes.put(id, false);
        }
        if (!votes.containsKey(id)) {
            votes.put(id, false);
            postService.downvote(id);
        }
        user.setVotes(votes);
        userRepository.save(user);
    }
}
