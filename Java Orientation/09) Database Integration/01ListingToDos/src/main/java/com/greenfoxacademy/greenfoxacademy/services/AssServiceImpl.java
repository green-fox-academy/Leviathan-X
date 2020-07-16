package com.greenfoxacademy.greenfoxacademy.services;

import com.greenfoxacademy.greenfoxacademy.models.Assignee;
import com.greenfoxacademy.greenfoxacademy.repositories.AssRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class AssServiceImpl implements AssService {

    AssRepository assRepository;

    @Autowired
    public AssServiceImpl(AssRepository assRepository) {
        this.assRepository = assRepository;
    }

    @Override
    public List<Assignee> getAll() {
        return this.assRepository.findAll();
    }

    @Override
    public void createAssignee(String name, String email) {
        Assignee assignee = new Assignee(name, email);
        this.assRepository.save(assignee);
    }

    @Override
    public void deleteAssignee(long id) {
        this.assRepository.deleteById(id);
    }

    @Override
    public Assignee getAssignee(long id) {
        return this.assRepository.getOne(id);
    }

    @Override
    public void updateAssignee(long id, String name, String email) {
        Assignee assignee = new Assignee(id, name, email);
        assignee.setId(id);
        this.assRepository.save(assignee);
    }

    @Override
    public List<Assignee> search(String name) {
        return this.assRepository.findAll().stream()
                .filter(toDo -> toDo.getName().toLowerCase().contains(name.toLowerCase()))
                .collect(Collectors.toList());
    }
}
