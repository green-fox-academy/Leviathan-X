package com.greenfoxacademy.api.models;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.text.SimpleDateFormat;
import java.util.Date;

@Entity
public class Log {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String createdAt;
    private String endpoint;
    private String data;

    public Log() {
        this.createdAt = new SimpleDateFormat("HH:mm:ss dd-MM-yyyy").format(new Date());
    }

    public Log(String endpoint, String data) {
        this.createdAt = new SimpleDateFormat("HH:mm:ss dd-MM-yyyy").format(new Date());
        this.endpoint = endpoint;
        this.data = data;
    }

    public Long getId() { return id; }
    public void setId(Long id) { this.id = id; }

    public String getCreatedAt() { return createdAt; }
    public void setCreatedAt(String createdAt) { this.createdAt = createdAt; }

    public String getEndpoint() { return endpoint; }
    public void setEndpoint(String endpoint) { this.endpoint = endpoint; }

    public String getData() { return data; }
    public void setData(String data) { this.data = data; }
}
