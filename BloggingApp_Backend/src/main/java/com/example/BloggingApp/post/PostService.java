package com.example.BloggingApp.post;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Service
public class PostService {

    @Autowired
    private PostRepository postRepository;
    //CRUD operations

    //CREATE
    @Transactional
    public Post createPost(Post post) {
        post.setCreatedAt(System.currentTimeMillis());
        post.setUpdatedAt(System.currentTimeMillis());

        return postRepository.save(post);
    }

    //READ
    public List<Post> getAllPosts() {
        return postRepository.findAll();
    }
    public List<Post> getAllPublishedPostsForUser(int userId) {
        //TO DO: IMPLEMENT SQL REQUEST
        return postRepository.findPublishedPostsByUserId(userId);
    }

    //FIND POST
    public Post getPostById(int postId) {
        return postRepository.findById(postId).orElse(null);
    }

    //UPDATE
    @Transactional
    public Post updatePost(int postId, Post updatedPost) {
        Optional<Post> existingPostOpt = postRepository.findById(postId);
        if (existingPostOpt.isPresent()) {
            Post existingPost = existingPostOpt.get();
            existingPost.setTitle(updatedPost.getTitle());
            existingPost.setContent(updatedPost.getContent());
            existingPost.setPublished(updatedPost.isPublished());
            return postRepository.save(existingPost);
        }
        return null; // or throw an exception
    }

    //DELETE
    public void deletePost(int postId) {
        postRepository.deleteById(postId);
    }
}
