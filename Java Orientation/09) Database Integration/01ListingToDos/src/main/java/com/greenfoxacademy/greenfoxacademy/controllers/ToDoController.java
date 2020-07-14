package com.greenfoxacademy.greenfoxacademy.controllers;

import com.greenfoxacademy.greenfoxacademy.models.ToDo;
import com.greenfoxacademy.greenfoxacademy.repositories.ToDoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.ArrayList;
import java.util.List;

@Controller
@RequestMapping("/todos")
public class ToDoController {

    private ToDoRepository toDoRepository;

    @Autowired
    public ToDoController(ToDoRepository toDoRepository) {
        this.toDoRepository = toDoRepository;
    }

    @GetMapping({"/", "/list"})
    public String list(Model model) {
        // List<toDu> list = new ArrayList<>();
        // toDoRepository.findAll().forEach(list::add);
        List<ToDo> list = toDoRepository.findAll();

        model.addAttribute("todos", toDoRepository.findAll());
        return "todolist";
    }
}
