package com.greenfoxacademy.gfa;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.List;
import java.util.stream.Collectors;

@Controller
public class GFAController {
    StudentService studentService;

    @Autowired
    public GFAController(StudentService studentService) {
        this.studentService = studentService;
    }

    @GetMapping("/gfa")
    public String mainPage(Model model) {
        List<String> students = studentService.findAll();
        int count = students.size();
        model.addAttribute("count", count);
        return "gfaMain";
    }

    @GetMapping("/gfa/list")
    public String listedStudents(Model model) {
        List<String> students = studentService.findAll();
        students = students.stream().sorted().collect(Collectors.toList());
        model.addAttribute("students", students);
        return "gfaList";
    }

    @GetMapping("/gfa/add")
    public String addStudent(Model model) {
        return "gfaAdd";
    }

    @PostMapping("/gfa/save")
    public String saveStudent(@RequestParam String name) {
        studentService.save(name);
        return "redirect:/gfa";
    }

    @GetMapping()
    public String studentCount(Model model) {
        List<String> students = studentService.findAll();
        int count = students.size();
        model.addAttribute("count", count);
        return "gfaFragments";
    }

    @GetMapping("/gfa/check")
    public String checkStudent(Model model, String name) {
        return "gfaCheck";
    }

    @PostMapping("/gfa/check")
    public String checkStudentInput(Model model, @RequestParam String name) {
        List<String> students = studentService.findAll();
        model.addAttribute("name", name);
        if(students.contains(name)) model.addAttribute("nameCheck",
                " is a student of this class.");
        else model.addAttribute("nameCheck",
                " is not a student of this class.");

        return "gfaCheck";
    }
}
