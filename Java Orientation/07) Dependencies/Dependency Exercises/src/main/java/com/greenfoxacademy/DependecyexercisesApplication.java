package com.greenfoxacademy;

import com.greenfoxacademy.helloworld.Printer;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class DependecyexercisesApplication implements CommandLineRunner {
    Printer printer;

    @Autowired
    public DependecyexercisesApplication(Printer printer) {
        this.printer = printer;
    }

    public static void main(String[] args) {
        SpringApplication.run(DependecyexercisesApplication.class, args);
    }

    @Override
    public void run(String... args) throws Exception {
        printer.log("Whassup world");
    }
}
