package com.greenfoxacademy.greenfoxacademy;

import com.greenfoxacademy.greenfoxacademy.models.ToDo;
import com.greenfoxacademy.greenfoxacademy.repositories.ToDoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class GreenfoxacademyApplication implements CommandLineRunner {

    ToDoRepository toDoRepository;

    @Autowired
    public GreenfoxacademyApplication(ToDoRepository toDoRepository) {
        this.toDoRepository = toDoRepository;
    }

    public static void main(String[] args) {
        SpringApplication.run(GreenfoxacademyApplication.class, args); }

    @Override
    public void run(String... args) throws Exception {
        //toDoRepository.save(new ToDo(null, "Walk the dog"));
        //toDoRepository.save(new ToDo(null, "Wash your butt"));
    }
}
