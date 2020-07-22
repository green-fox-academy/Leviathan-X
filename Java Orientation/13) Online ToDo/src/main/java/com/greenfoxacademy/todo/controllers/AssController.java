package com.greenfoxacademy.todo.controllers;

import com.greenfoxacademy.todo.models.Assignee;
import com.greenfoxacademy.todo.services.AssService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@RequestMapping(value = "/assignees")
public class AssController {

    private AssService assService;

    @Autowired
    public AssController(AssService assService) {
        this.assService = assService;
    }

    @GetMapping("/")
    public String listRedirect() {
        return "redirect:/assignees/list";
    }

    @GetMapping({"/list"})
    public String list(Model model) {
        List<Assignee> assignees = assService.getAll();
        model.addAttribute("assignees", assignees);
        return "asslist";
    }

    @GetMapping("/add-assignee")
    public String addAssigneeGET() {
        return "add-assignee";
    }

    @PostMapping("/add-assignee")
    public String addAssigneePOST(@ModelAttribute("assignee") Assignee assignee) {
        assService.createAssignee(assignee.getName(), assignee.getEmail());
        return "redirect:/assignees/";
    }

    @GetMapping("/delete-assignee/{id}")
    public String deleteAssignee(Model model, @PathVariable long id) {
        assService.deleteAssignee(id);
        return "redirect:/assignees/";
    }

    @GetMapping("/edit-assignee/{id}")
    public String editAssigneeGET(Model model, @PathVariable long id) {
        model.addAttribute("assignee", assService.getAssignee(id));
        return "edit-assignee";
    }

    @PostMapping("/edit-assignee")
    public String editAssigneePOST(@ModelAttribute("assignee") Assignee assignee,
                                   @RequestParam(value = "id") long id) {
        assService.updateAssignee(id, assignee.getName(), assignee.getEmail());
        return "redirect:/assignees/";
    }

    @GetMapping("/search")
    public String search(Model model, @RequestParam String name) {
        if (name != null) {
            model.addAttribute("assignees", assService.search(name));
            return "asslist";
        }
        else return "redirect:/assignees/";
    }

    @GetMapping("/{id}")
    public String assignee(Model model, @PathVariable long id) {
        model.addAttribute("assignee", assService.getAssignee(id));
        return "asstodos";
    }
}