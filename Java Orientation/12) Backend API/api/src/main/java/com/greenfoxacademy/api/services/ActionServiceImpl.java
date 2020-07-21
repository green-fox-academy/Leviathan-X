package com.greenfoxacademy.api.services;

import com.greenfoxacademy.api.models.DoUntil;
import org.springframework.stereotype.Service;

import javax.servlet.http.HttpServletResponse;
import java.util.HashMap;
import java.util.Map;

@Service
public class ActionServiceImpl implements ActionService {

    public ActionServiceImpl() { }

    public Map<String, Object> runDoUntil(String action, DoUntil doUntil,
                                          HttpServletResponse response) {
        Map<String, Object> output = new HashMap<>();
        int result;
        if (action.equals("sum")) {
            response.setStatus(200);
            result = doUntil.sum();
            output.put("result", result);
            return output;
        }
        else if (action.equals("factor")) {
            response.setStatus(200);
            result = doUntil.factor();
            output.put("result", result);
            return output;
        }
        else {
            response.setStatus(400);
            output.put("error", "Please provide a number!");
            return output;
        }
    }
}
