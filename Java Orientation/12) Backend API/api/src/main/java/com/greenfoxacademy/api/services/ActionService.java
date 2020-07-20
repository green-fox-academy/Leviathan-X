package com.greenfoxacademy.api.services;

import com.greenfoxacademy.api.models.DoUntil;

import javax.servlet.http.HttpServletResponse;
import java.util.Map;

public interface ActionService {

    public Map<String, Object> runDoUntil(String action, DoUntil doUntil,
                                          HttpServletResponse response);
}
