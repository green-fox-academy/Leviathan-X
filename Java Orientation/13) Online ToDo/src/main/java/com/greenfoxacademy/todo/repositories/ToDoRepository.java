package com.greenfoxacademy.todo.repositories;

import com.greenfoxacademy.todo.models.ToDo;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface ToDoRepository extends JpaRepository<ToDo, Long> { }
