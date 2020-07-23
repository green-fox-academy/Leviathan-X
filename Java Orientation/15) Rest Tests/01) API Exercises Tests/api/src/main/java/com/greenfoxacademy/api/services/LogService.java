package com.greenfoxacademy.api.services;

import com.greenfoxacademy.api.models.Log;

import java.util.List;

public interface LogService {
    List<Log> findAll();
    Log findById(Long id);
    void saveLog(Log log);
}
