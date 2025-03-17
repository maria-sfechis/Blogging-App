package com.example.BloggingApp.comment;

import com.example.BloggingApp.post.Post;
import com.example.BloggingApp.post.PostService;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CommentService {

    @Autowired
    private CommentRepository commentRepository;

    @Autowired
    private PostService postService;

    // CREATE
    @Transactional
    public Comment createComment(int postId, Comment comment) {
        Post post = postService.getPostById(postId);
        if (post != null) {
            comment.setPost(post);
            return commentRepository.save(comment);
        }
        return null;
    }

    //READ
    public List<Comment> getAllCommentsForPost(int postId) {
        return commentRepository.getAllCommentsForPost(postId);
    }

    // UPDATE
    @Transactional
    public Comment updateComment(int commentId, Comment updatedComment) {
        Optional<Comment> existingCommentOpt = commentRepository.findById(commentId);
        if (existingCommentOpt.isPresent()) {
            Comment existingComment = existingCommentOpt.get();
            existingComment.setText(updatedComment.getText()); // Update the text field
            // existingComment.setPost(updatedComment.getPost());
            return commentRepository.save(existingComment);
        }
        return null;
        // Handle case where the comment does not exist
        // Throw exception
    }

    //DELETE
    public void deleteComment(int commentId) {
        commentRepository.deleteById(commentId);
    }

}
