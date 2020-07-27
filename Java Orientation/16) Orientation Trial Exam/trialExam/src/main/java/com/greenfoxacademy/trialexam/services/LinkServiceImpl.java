package com.greenfoxacademy.trialexam.services;

import com.greenfoxacademy.trialexam.models.Link;
import com.greenfoxacademy.trialexam.repositories.LinkRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Random;

@Service
public class LinkServiceImpl implements LinkService{

    private LinkRepository linkRepository;

    @Autowired
    public LinkServiceImpl(LinkRepository linkRepository) {
        this.linkRepository = linkRepository;
    }

    @Override
    public List<Link> getAllLinks() {
        return this.linkRepository.findAll();
    }

    @Override
    public List<Link> getAllLinksHideCode() {
        List<Link> output = this.linkRepository.findAll();
        for (Link link : output) {
            link.setCode(null);
        }
        return output;
    }

    @Override
    public Link getLink(Long id) {
        return this.linkRepository.getOne(id);
    }

    @Override
    public Link getLinkByAlias(String alias) {
        return this.linkRepository.findLinkByAlias(alias);
    }

    @Override
    public void createNew(Link link) {
        this.linkRepository.save(new Link(link.getUrl(), link.getAlias(), generateCode()));
    }

    @Override
    public Integer generateCode() {
        Random r = new Random();
        String randomNumber = String.format("%04d", r.nextInt(10000));
        int output = Integer.parseInt(randomNumber);
        return output;
    }

    @Override
    public void hitCountUp(String alias) {
        Link link = this.linkRepository.findLinkByAlias(alias);
        link.setHitCount(link.getHitCount() + 1);
        this.linkRepository.save(link);
    }

    @Override
    public void deleteByCode(Integer code) {
        // this.linkRepository.deleteLinkByCode(code);  // <-- why doesn't this work?
        List<Link> links = this.linkRepository.findAll();
        Link target = null;
        for (Link link : links) {
            if (link.getCode().equals(code))
                target = link;
        }
        this.linkRepository.delete(target);
    }

    @Override
    public void deleteById(Long id) {
        // this.linkRepository.deleteById(id);
        List<Link> links = this.linkRepository.findAll();
        Link target = null;
        for (Link link : links) {
            if (link.getId() == id)
                target = link;
        }
        this.linkRepository.delete(target);
    }
}
