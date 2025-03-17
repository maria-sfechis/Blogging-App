package com.example.BloggingApp.comment;

import com.example.BloggingApp.post.Post;
import com.example.BloggingApp.user.User;
import jakarta.persistence.*;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;

import java.util.Date;

@Entity
public class Comment {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @Setter
    @ManyToOne
    @JoinColumn(name = "post_id", nullable = false)
    private Post post;

    private String content;

    @ManyToOne
    @JoinColumn(name = "user_id", nullable = false)
    private User user;

    @CreationTimestamp
    @Column(updatable = false, nullable = false)
    private Date date;

    public String getText() {
        return content; // Getter for text
    }

    public void setText(String content) {
        this.content = content;
    }


}
