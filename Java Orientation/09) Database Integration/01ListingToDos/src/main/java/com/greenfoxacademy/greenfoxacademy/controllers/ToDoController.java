package com.greenfoxacademy.greenfoxacademy.controllers;

import com.greenfoxacademy.greenfoxacademy.models.ToDo;
import com.greenfoxacademy.greenfoxacademy.repositories.ToDoRepository;
import com.greenfoxacademy.greenfoxacademy.services.ToDoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Controller
@RequestMapping("/todos")
public class ToDoController {

    private ToDoService toDoService;

    @Autowired
    public ToDoController(ToDoService toDoService) {
        this.toDoService = toDoService;
    }

    @GetMapping({"/"})  // @GetMapping({"/", "/list"})
    public String listRedirect() {
        return "redirect:/todos/list?show=";
    }

    @GetMapping({"/list"})
    public String list(Model model, @RequestParam(required = false) String show) {
        // List<toDu> list = new ArrayList<>();
        // toDoRepository.findAll().forEach(list::add);
        // List<ToDu> list = toDoRepository.findAll();

        if (show.equals("undone")) {
            List<ToDo> input = toDoService.getAll();
            List<ToDo> unDoneList = input.stream()
                    .filter(todo -> todo.isDone() == false)
                    .collect(Collectors.toList());
            model.addAttribute("todos", unDoneList);
        }
        else if (show.equals("done")) {
            List<ToDo> input = toDoService.getAll();
            List<ToDo> doneList = input.stream()
                    .filter(todo -> todo.isDone() == true)
                    .collect(Collectors.toList());
            model.addAttribute("todos", doneList);
        }
        else model.addAttribute("todos", toDoService.getAll());
        return "todolist";
    }

    @GetMapping("/add-todo")
    public String addToDoGET() {
        return "add-todo";
    }

    @PostMapping("/add-todo")
    public String addToDoPOST(@ModelAttribute("todo") ToDo todo) {
        toDoService.createToDo(todo.getTitle(), todo.getUrgent(), todo.isDone());
        return "redirect:/todos/";
    }

    @GetMapping("/delete-todo/{id}")
    public String deleteToDo(Model model, @PathVariable long id) {
        toDoService.deleteToDo(id);
        return "redirect:/todos/";
    }

    @GetMapping("/edit-todo/{id}")
    public String editToDoGET(Model model, @PathVariable long id) {
        model.addAttribute("todo", toDoService.getTodo(id));
        return "edit-todo";
    }

    @PostMapping("/edit-todo")
    public String editToDoPOST(@ModelAttribute("task") ToDo toDo,
                               @RequestParam(value = "id") long id) {

        return "redirect:/todos/";
    }
}
