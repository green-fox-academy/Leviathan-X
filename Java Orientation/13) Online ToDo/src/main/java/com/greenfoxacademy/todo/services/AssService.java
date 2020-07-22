package com.greenfoxacademy.todo.services;

import com.greenfoxacademy.todo.models.Assignee;

import java.util.List;

public interface AssService {
    List<Assignee> getAll();

    void createAssignee(String name, String email);

    void deleteAssignee(long id);

    Assignee getAssignee(long id);

    void updateAssignee(long id, String name, String email);

    List<Assignee> search(String name);
}
