package com.example.BloggingApp.comment;

import com.example.BloggingApp.post.Post;
import com.example.BloggingApp.post.PostService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/comment")
@CrossOrigin
public class CommentController {

    @Autowired
    private CommentService commentService;

    @PostMapping
    public Comment createComment(@PathVariable int postId, @RequestBody Comment comment) {
        return commentService.createComment(postId, comment);
    }

    @GetMapping
    public List<Comment> getAllComments(@PathVariable int postId) {
        return commentService.getAllCommentsForPost(postId);
    }

    @PutMapping("/{commentId}")
    public Comment updateComment(@PathVariable int postId, @PathVariable int commentId, @RequestBody Comment updatedComment) {
        return commentService.updateComment(commentId, updatedComment);
    }

    @DeleteMapping("/{commentId}")
    public void deleteComment(@PathVariable int commentId) {
        commentService.deleteComment(commentId);
    }

    @GetMapping("/post/{postId}")
    public List<Comment> getAllCommentsForPost(@PathVariable int postId) {
        return commentService.getAllCommentsForPost(postId);
    }

}