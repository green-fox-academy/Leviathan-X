package com.greenfoxacademy.greenfoxacademy.services;

import com.greenfoxacademy.greenfoxacademy.models.ToDo;
import com.greenfoxacademy.greenfoxacademy.repositories.ToDoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class ToDoServiceImpl implements ToDoService {

    ToDoRepository toDoRepository;

    @Autowired
    public ToDoServiceImpl(ToDoRepository toDoRepository) {
        this.toDoRepository = toDoRepository;
    }

    @Override
    public List<ToDo> getAll() {
        return this.toDoRepository.findAll();
    }

    @Override
    public void createToDo(String title, boolean urgent, boolean done) {
        ToDo todo = new ToDo(title, urgent, done);
        this.toDoRepository.save(todo);
    }

    @Override
    public List<ToDo> getAllUndone() {
        return this.toDoRepository.findAll().stream()
                .filter(toDo -> toDo.isDone() == false)
                .collect(Collectors.toList());
    }
    @Override
    public List<ToDo> getAllDone() {
        return this.toDoRepository.findAll().stream()
                .filter(toDo -> toDo.isDone())
                .collect(Collectors.toList());
    }

    @Override
    public void deleteToDo(long id) {
        this.toDoRepository.deleteById(id);
    }

    @Override
    public ToDo getTodo(long id) {
        return this.toDoRepository.getOne(id);
    }

    @Override
    public void updateToDo(long id, String title, boolean urgent, boolean done) {
        ToDo toDo = new ToDo(title, urgent, done);
        toDo.setId(id);
        this.toDoRepository.save(toDo);
    }

    @Override
    public List<ToDo> search(String title) {
        List<ToDo> output = toDoRepository.findAll().stream()
                .filter(toDo -> toDo.getTitle().contains(title))
                .collect(Collectors.toList());
        return output;
    }
}
