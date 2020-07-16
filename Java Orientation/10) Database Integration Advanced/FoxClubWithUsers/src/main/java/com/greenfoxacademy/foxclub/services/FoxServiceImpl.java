package com.greenfoxacademy.foxclub.services;

import com.greenfoxacademy.foxclub.models.Fox;
import com.greenfoxacademy.foxclub.repositories.FoxRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class FoxServiceImpl implements FoxService {
    FoxRepository foxRepository;

    @Autowired
    public FoxServiceImpl(FoxRepository foxRepository) {
        this.foxRepository = foxRepository;
    }

    public List<Fox> getList() {
        return foxRepository.findAll();
    }

    public Fox getFox(String name) {
        return foxRepository.findAll().stream()
                .filter(fox -> fox.getName().equals(name))
                .findFirst().orElse(null);
    }
    public Fox getFox(long id) {
        return foxRepository.findAll().stream()
                .filter(fox -> fox.getId() == id)
                .findFirst().orElse(null);
    }

    public void addToList(Fox fox) {
        foxRepository.save(fox);
    }

    public boolean searchListForInput(String input) {
        for (Fox fox : foxRepository.findAll()) {
            if (fox.getName().equals(input)) return true;
        }
        return false;
    }

    @Override
    public void setNutrition(String name, String food, String drink) {

    }
}
