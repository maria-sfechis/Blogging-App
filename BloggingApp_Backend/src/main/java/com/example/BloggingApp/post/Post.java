package com.example.BloggingApp.post;

import com.example.BloggingApp.user.User;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.Getter;
import lombok.NoArgsConstructor;
import org.hibernate.annotations.CreationTimestamp;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import java.util.Date;

@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Post {

    @Getter
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @Column(nullable = false)
    private String title;

    @Column(nullable = false, length = 1000)
    private String content;

    @ManyToOne
    @JoinColumn(name = "user_id", nullable = false)
    @JsonIgnoreProperties({"name", "email", "password", "username"}) // Ignoră câmpurile inutile
    private User user;

    @CreationTimestamp
    @Column(updatable = false, nullable = false)
    private Date date;

    private boolean published;

    private long CreatedAt;

    private long UpdatedAt;

    public Post(String title, String content, boolean published) {
        this.title = title;
        this.content = content;
        this.published = published;
    }

}
