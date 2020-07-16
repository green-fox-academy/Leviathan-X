package com.greenfoxacademy.reddit.services;

import com.greenfoxacademy.reddit.models.Post;
import com.greenfoxacademy.reddit.repositories.PostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class PostServiceImpl implements PostService {

    private PostRepository postRepository;

    @Autowired
    public PostServiceImpl(PostRepository postRepository) {
        this.postRepository = postRepository;
    }

    @Override
    public List<Post> getAll() {
        return this.postRepository.findAll();
    }

    @Override
    public List<Post> getAllSorted() {
        return this.postRepository.findByOrderByVotesDesc();
    }

    @Override
    public Post getPost(Long id) {
        return this.postRepository.getOne(id);
    }

    @Override
    public void createNew(String title, String text) {
        this.postRepository.save(new Post(title, text));
    }

    @Override
    public void upvote(Long id) {
        Post post = this.getPost(id);
        post.setVotes(post.getVotes() + 1);
        this.postRepository.save(post);
    }

    @Override
    public void downvote(Long id) {
        Post post = this.postRepository.getOne(id);
        post.setVotes(post.getVotes() - 1);
        this.postRepository.save(post);
    }
}
