package com.greenfoxacademy.groot.controllers;

import com.greenfoxacademy.groot.models.Groot;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GuardianController {

    @GetMapping("/groot")
    public ResponseEntity<?> grootMessageGET(@RequestParam String message) {
        if (message == null) {
            return ResponseEntity.badRequest().body(new Groot(null));
        }
        else return ResponseEntity.ok().body(new Groot(message));
    }
}
