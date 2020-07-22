package com.greenfoxacademy.todo.repositories;

import com.greenfoxacademy.todo.models.Assignee;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface AssRepository extends JpaRepository<Assignee, Long> { }
