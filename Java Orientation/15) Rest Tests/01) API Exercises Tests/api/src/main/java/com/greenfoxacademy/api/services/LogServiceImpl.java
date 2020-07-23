package com.greenfoxacademy.api.services;

import com.greenfoxacademy.api.models.Log;
import com.greenfoxacademy.api.repositories.LogRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class LogServiceImpl implements LogService {

    private LogRepository logRepository;

    @Autowired
    public LogServiceImpl(LogRepository logRepository) {
        this.logRepository = logRepository;
    }

    @Override
    public List<Log> findAll() {
        return this.logRepository.findAll();
    }

    @Override
    public Log findById(Long id) {
        return this.logRepository.findById(id).orElse(null);
    }

    @Override
    public void saveLog(Log log) {
        this.logRepository.save(log);
    }
}
