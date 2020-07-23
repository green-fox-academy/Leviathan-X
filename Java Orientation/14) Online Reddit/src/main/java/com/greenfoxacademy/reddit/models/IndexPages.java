package com.greenfoxacademy.reddit.models;

import java.util.List;

public class IndexPages {

    private List<Post> pageList;
    private int pages;

    public IndexPages(List<Post> pageList, int pages) {
        this.pageList = pageList;
        this.pages = pages;
    }

    public List<Post> getPageList() { return pageList; }
    public void setPageList(List<Post> pageList) { this.pageList = pageList; }

    public int getPages() { return pages; }
    public void setPages(int pages) { this.pages = pages; }
}
