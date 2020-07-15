package com.greenfoxacademy.greenfoxacademy.repositories;

import com.greenfoxacademy.greenfoxacademy.models.Assignee;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface AssRepository extends JpaRepository<Assignee, Long> { }
