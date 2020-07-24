package com.greenfoxacademy.groot.controllers;

import com.greenfoxacademy.groot.models.Groot;
import com.greenfoxacademy.groot.models.Yondu;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GuardianController {

    @GetMapping("/groot")
    public ResponseEntity<?> grootMessageGET(@RequestParam(required = false) String message) {
        if (message == null) {
            return ResponseEntity.badRequest().body(new Groot(null));
        }
        else return ResponseEntity.ok().body(new Groot(message));
    }

    @GetMapping("/yondu")
    public ResponseEntity<?> yonduArrowGET(@RequestParam(required = false) Double distance,
                                           @RequestParam(required = false) Double time) {
        if (distance == null || time == null) {
            return ResponseEntity.badRequest().body(new Yondu(null, null));
        }
        else return ResponseEntity.ok().body(new Yondu(distance, time));
    }
}
