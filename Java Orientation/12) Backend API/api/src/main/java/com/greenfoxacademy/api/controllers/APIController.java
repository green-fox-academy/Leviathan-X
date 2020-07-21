package com.greenfoxacademy.api.controllers;

import com.greenfoxacademy.api.models.*;
import com.greenfoxacademy.api.services.ActionServiceImpl;
import com.greenfoxacademy.api.services.ArrayHandlerService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpServletResponse;
import java.util.Map;

@RestController
public class APIController {

    private ActionServiceImpl actionServiceImpl;
    private ArrayHandlerService arrayHandlerService;

    @Autowired
    public APIController(ActionServiceImpl actionServiceImpl, ArrayHandlerService arrayHandlerService) {
        this.actionServiceImpl = actionServiceImpl;
        this.arrayHandlerService = arrayHandlerService;
    }

    @GetMapping("/doubling")
    public ResponseEntity<?> doublingRequest(@RequestParam(value = "input", required = false) Integer input) {
        return new ResponseEntity<>(new Doubling(input).getOutput(), HttpStatus.OK);
    }

    @GetMapping("/greeter")
    public Map<String, String> greeterRequest(@RequestParam(value = "name", required = false) String name,
                                              @RequestParam(value = "title", required = false) String title,
                                              HttpServletResponse response) {
        return new Greeter(name, title).run(response);
    }

    @GetMapping("/appenda/{appendable}")
    public Map<String, String> appendARequest(@PathVariable(value = "appendable") String appendable,
                                              HttpServletResponse response) {
        return new AppendA(appendable).run(response);
    }

    @PostMapping("/dountil/{action}")
    public Map<String, Object> doUntilRequest(@PathVariable(value = "action") String action,
                                               @RequestBody DoUntil doUntil,
                                               HttpServletResponse response) {
        return actionServiceImpl.runDoUntil(action, doUntil, response);
    }

    @PostMapping("/arrays")
    public ResponseEntity<?> arrayHandlerRequest(@RequestBody ArrayHandler arrayHandler) {
        if (arrayHandler.getWhat() == null || arrayHandler.getNumbers() == null) {
            return new ResponseEntity<>(new ErrorMessage("Missing input!"), HttpStatus.BAD_REQUEST);
        }
        else return new ResponseEntity<>(this.arrayHandlerService.run(arrayHandler), HttpStatus.OK);
    }
}
