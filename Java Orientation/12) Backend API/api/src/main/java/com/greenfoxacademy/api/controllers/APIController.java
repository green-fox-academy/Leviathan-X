package com.greenfoxacademy.api.controllers;

import com.greenfoxacademy.api.models.*;
import com.greenfoxacademy.api.services.ActionServiceImpl;
import com.greenfoxacademy.api.services.ArrayHandlerService;
import com.greenfoxacademy.api.services.LogService;
import com.greenfoxacademy.api.services.SithReverserServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpServletResponse;
import java.util.Arrays;
import java.util.Map;

@RestController
public class APIController {

    private ActionServiceImpl actionServiceImpl;
    private ArrayHandlerService arrayHandlerService;
    private LogService logService;
    private SithReverserServiceImpl sithReverserService;

    @Autowired
    public APIController(ActionServiceImpl actionServiceImpl, ArrayHandlerService arrayHandlerService,
                         LogService logService, SithReverserServiceImpl sithReverserService) {
        this.actionServiceImpl = actionServiceImpl;
        this.arrayHandlerService = arrayHandlerService;
        this.logService = logService;
        this.sithReverserService = sithReverserService;
    }

    @GetMapping("/doubling")
    public ResponseEntity<?> doublingRequest(@RequestParam(value = "input", required = false) Integer input) {
        if (input != null) logService.saveLog(new Log("/doubling", "input=" + input.toString()));
        return new ResponseEntity<>(new Doubling(input).getOutput(), HttpStatus.OK);
    }

    @GetMapping("/greeter")
    public Map<String, String> greeterRequest(@RequestParam(value = "name", required = false) String name,
                                              @RequestParam(value = "title", required = false) String title,
                                              HttpServletResponse response) {
        if (name != null && title != null) logService.saveLog(new Log("greeter",
                String.format("name=%s, title=%s", name, title)));
        return new Greeter(name, title).run(response);
    }

    @GetMapping("/appenda/{appendable}")
    public Map<String, String> appendARequest(@PathVariable(value = "appendable") String appendable,
                                              HttpServletResponse response) {
        if (appendable != null) logService.saveLog(new Log("/appenda",
                String.format("appendable=%s", appendable)));
        return new AppendA(appendable).run(response);
    }

    @PostMapping("/dountil/{action}")
    public Map<String, Object> doUntilRequest(@PathVariable(value = "action") String action,
                                               @RequestBody DoUntil doUntil,
                                               HttpServletResponse response) {
        if (action != null && doUntil.getUntil() != null) logService.saveLog(new Log("/dountil",
                String.format("action=%s, until=%s", action, doUntil.getUntil().toString())));
        return actionServiceImpl.runDoUntil(action, doUntil, response);
    }

    @PostMapping("/arrays")
    public ResponseEntity<?> arrayHandlerRequest(@RequestBody ArrayHandler arrayHandler) {
        if (arrayHandler.getWhat() == null || arrayHandler.getNumbers() == null) {
            return new ResponseEntity<>(new ErrorMessage("Missing input!"), HttpStatus.BAD_REQUEST);
        }
        else {
            logService.saveLog(new Log("/arrays", String.format("what=%s, numbers=%s",
                    arrayHandler.getWhat(), Arrays.toString(arrayHandler.getNumbers()))));
            return new ResponseEntity<>(this.arrayHandlerService.run(arrayHandler), HttpStatus.OK);
        }
    }

    @GetMapping("/log")
    public ResponseEntity<?> logRequest() {
        if (this.logService.findAll().size() == 0)
            return new ResponseEntity<>(new ErrorMessage("No log entries!"), HttpStatus.BAD_REQUEST);
        return new ResponseEntity<>(this.logService.findAll(), HttpStatus.OK);
    }

    @PostMapping("/sith")
    public ResponseEntity<?> sithRequest(@RequestBody SithReverser sithReverser) {
        if (sithReverser.getText() == null) return new ResponseEntity<>(
                new ErrorMessage("Feed me some text you have to, padawan young you are. Hmmm."), HttpStatus.BAD_REQUEST);
        else return new ResponseEntity<>(sithReverserService.run(sithReverser), HttpStatus.OK);
    }
}
