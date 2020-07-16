package com.greenfoxacademy.foxclub.services;

import com.greenfoxacademy.foxclub.models.Fox;

import java.util.List;

public interface FoxService {

    public List<Fox> getList();

    public Fox getFox(long id);

    public Fox getFox(String name);

    public void addToList(Fox fox);

    public boolean searchListForInput(String input);

    public void setNutrition(String name, String food, String drink);
}
