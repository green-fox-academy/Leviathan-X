package com.greenfoxacademy.greenfoxacademy.services;

import com.greenfoxacademy.greenfoxacademy.models.ToDo;

import java.util.List;

public interface ToDoService {
    List<ToDo> getAll();

    void createToDo(String title, boolean urgent, boolean done);

    List<ToDo> getAllActive();

    void deleteToDo(long id);

    ToDo getTodo(long id);

    void updateToDo(long id, String title, boolean urgent, boolean done);
}
