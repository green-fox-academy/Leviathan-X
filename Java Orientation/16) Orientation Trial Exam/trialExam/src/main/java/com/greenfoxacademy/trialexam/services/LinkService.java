package com.greenfoxacademy.trialexam.services;

import com.greenfoxacademy.trialexam.models.Link;

import java.util.List;

public interface LinkService {

    List<Link> getAllLinks();
    List<Link> getAllLinksHideCode();

    Link getLink(Long id);
    Link getLinkByAlias(String alias);

    void createNew(Link link);

    Integer generateCode();

    void hitCountUp(String alias);

    void deleteByCode(Integer code);
    void deleteById(Long id);
}
