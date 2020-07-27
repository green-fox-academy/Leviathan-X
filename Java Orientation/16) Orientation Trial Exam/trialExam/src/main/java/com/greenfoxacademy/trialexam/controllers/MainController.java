package com.greenfoxacademy.trialexam.controllers;

import com.greenfoxacademy.trialexam.models.Link;
import com.greenfoxacademy.trialexam.services.LinkService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.view.RedirectView;

import javax.servlet.http.HttpServletResponse;
import java.util.List;

@Controller
public class MainController {

    private LinkService linkService;

    @Autowired
    public MainController(LinkService linkService) {
        this.linkService = linkService;
    }

    @GetMapping("/")
    public String mainPageGET(Model model,
                              @RequestParam(required = false) String match) {
        model.addAttribute("match", match);
        return "mainPage";
    }

    @PostMapping("/save-link")
    public String mainPagePOST(Model model,
                               @ModelAttribute("link") Link link) {
        if (linkService.getLinkByAlias(link.getAlias()) != null) {
            model.addAttribute("match", "true");
            return "mainPage";
        }
        else {
            linkService.createNew(link);
            model.addAttribute("match", "false");
            model.addAttribute("alias", linkService.getLinkByAlias(link.getAlias()).getAlias());
            model.addAttribute("code", linkService.getLinkByAlias(link.getAlias()).getCode());
            return "mainPage";
        }
    }

    @GetMapping("/a/{alias}")
    public ModelAndView getByAliasGET(@PathVariable String alias,
                                      HttpServletResponse httpServletResponse) {
        if (linkService.getLinkByAlias(alias) != null) {
            linkService.hitCountUp(alias);
            return new ModelAndView("redirect:https://" + linkService.getLinkByAlias(alias).getUrl());
        }
        else {
            httpServletResponse.setStatus(HttpServletResponse.SC_NOT_FOUND);
            return null;
        }
    }

    @GetMapping("/api/links")
    public ResponseEntity<?> bodyGET() {
        return ResponseEntity.ok().body(linkService.getAllLinksHideCode());
    }

    @DeleteMapping("api/links/{id}")
    public ResponseEntity<?> deleteByCode(@PathVariable Long id,
                             @RequestBody Link link) {
        if (this.linkService.getLink(id) == null) {
            return new ResponseEntity<>(new String("Not found!"), HttpStatus.NOT_FOUND);
        }
        else if (this.linkService.getLink(id) == null &&
                !this.linkService.getLink(id).getCode().equals(link.getCode())) {
            return new ResponseEntity<>("Forbidden!", HttpStatus.FORBIDDEN);
        }
        else if (this.linkService.getLink(id) == null &&
                this.linkService.getLink(id).getCode().equals(link.getCode())) {
            this.linkService.deleteById(id);
            return new ResponseEntity<>("Done", HttpStatus.NO_CONTENT);
        }
        return new ResponseEntity<>("Error!", HttpStatus.BAD_REQUEST);
    }
}
