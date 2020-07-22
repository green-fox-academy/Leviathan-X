package com.greenfoxacademy.todo.controllers;

import com.greenfoxacademy.todo.models.ToDo;
import com.greenfoxacademy.todo.repositories.ToDoRepository;
import com.greenfoxacademy.todo.services.AssService;
import com.greenfoxacademy.todo.services.ToDoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@RequestMapping("/todos")
public class ToDoController {

    private ToDoService toDoService;
    private AssService assService;

    @Autowired
    public ToDoController(ToDoService toDoService, AssService assService) {
        this.toDoService = toDoService;
        this.assService = assService;
    }

    @GetMapping({"/"})
    public String listRedirect() {
        return "redirect:/todos/list?show=";
    }

    @GetMapping({"/list"})
    public String list(Model model, @RequestParam(required = false) String show) {

        if (show == null) return "redirect:/todos/list?show=";
        if (show.equals("undone")) {
            List<ToDo> unDoneList = toDoService.getAllUndone();
            model.addAttribute("todos", unDoneList);
        }
        else if (show.equals("done")) {
            List<ToDo> doneList = toDoService.getAllDone();
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
        model.addAttribute("assignees", assService.getAll());
        return "edit-todo";
    }

    @PostMapping("/edit-todo")
    public String editToDoPOST(@ModelAttribute("todo") ToDo toDo,
                               @RequestParam(value = "id") long id,
                               @RequestParam(required = false, value = "idAss") Long idAss) {

        if(idAss == null) toDoService.updateToDo(id, null, toDo.getTitle(), toDo.getUrgent(), toDo.isDone());
        else toDoService.updateToDo(id, idAss, toDo.getTitle(), toDo.getUrgent(), toDo.isDone());
        return "redirect:/todos/";
    }

    @GetMapping("/search")
    public String search(Model model, @RequestParam String title) {
        if (title != null) {
            model.addAttribute("todos", toDoService.search(title));
            return "todolist";
        }
        else return "redirect:/todos/";
    }
}
