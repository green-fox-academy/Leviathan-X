package com.greenfoxacademy.trialexam.models;

import com.fasterxml.jackson.annotation.JsonInclude;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
@JsonInclude(JsonInclude.Include.NON_NULL)
public class Link {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private String url;
    private String alias;
    private Integer code;
    private int hitCount;

    public Link() {
        hitCount = 0;
    }

    public Link(Integer code) {
        this.code = code;
    }

    public Link(String url, String alias) {
        this.url = url;
        this.alias = alias;
        hitCount = 0;
    }

    public Link(String url, String alias, int code) {
        this.url = url;
        this.alias = alias;
        this.code = code;
        hitCount = 0;
    }

    public Long getId() { return id; }
    public void setId(Long id) { this.id = id; }

    public String getUrl() { return url; }
    public void setUrl(String url) { this.url = url; }

    public String getAlias() { return alias; }
    public void setAlias(String alias) { this.alias = alias; }

    public Integer getCode() { return code; }
    public void setCode(Integer code) { this.code = code; }

    public int getHitCount() { return hitCount; }
    public void setHitCount(int hitCount) { this.hitCount = hitCount; }
}
