package com.example.BloggingApp.post;

import com.example.BloggingApp.comment.Comment;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface PostRepository extends JpaRepository<Post, Integer> {
    @Query("SELECT p FROM Post p WHERE p.user.id = :userId AND p.published = true")
    List<Post> findPublishedPostsByUserId(@Param("userId") int userId);
}
