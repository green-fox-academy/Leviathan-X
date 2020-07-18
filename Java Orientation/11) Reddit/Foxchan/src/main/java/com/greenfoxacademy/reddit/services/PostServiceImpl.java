package com.greenfoxacademy.reddit.services;

import com.greenfoxacademy.reddit.models.Post;
import com.greenfoxacademy.reddit.models.User;
import com.greenfoxacademy.reddit.repositories.PostRepository;
import com.greenfoxacademy.reddit.repositories.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class PostServiceImpl implements PostService {

    private PostRepository postRepository;
    private UserRepository userRepository;

    @Autowired
    public PostServiceImpl(PostRepository postRepository, UserRepository userRepository) {
        this.postRepository = postRepository;
        this.userRepository = userRepository;
    }

    @Override
    public List<Post> getAll() {
        return this.postRepository.findByOrderByVotesDesc();
    }

    @Override
    public List<Post> getAllSorted() {
        return this.postRepository.findByOrderByVotesDesc();
    }

    @Override
    public Post getPost(Long id) {
        return this.postRepository.findById(id).orElse(null);
    }

    @Override
    public void createNew(String title, String text, String username) {
        User user = userRepository.findUserByUsername(username);
        this.postRepository.save(new Post(title, text, user));
    }

    @Override
    public void upvote(Long id, boolean votedStatus) {
        Post post = this.postRepository.findById(id).orElse(null);
        if (votedStatus) post.setVotes(post.getVotes() + 2);
        else post.setVotes(post.getVotes() + 1);
        this.postRepository.save(post);
    }

    @Override
    public void downvote(Long id, boolean votedStatus) {
        Post post = this.postRepository.findById(id).orElse(null);

        if (votedStatus) post.setVotes(post.getVotes() - 2);
        else post.setVotes(post.getVotes() - 1);
        this.postRepository.save(post);
    }
}
