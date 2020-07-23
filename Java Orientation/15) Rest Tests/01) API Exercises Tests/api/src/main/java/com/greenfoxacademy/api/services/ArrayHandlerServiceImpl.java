package com.greenfoxacademy.api.services;

import com.greenfoxacademy.api.models.ArrayHandler;
import org.springframework.stereotype.Service;

@Service
public class ArrayHandlerServiceImpl implements ArrayHandlerService{

    @Override
    public ArrayHandler run(ArrayHandler arrayHandler) {
        if (arrayHandler.getWhat().equals("sum")) {
            int sum = 0;
            for (int number : arrayHandler.getNumbers()) {
                sum += number;
            }
            arrayHandler.setResult(sum);
            arrayHandler.setWhat(null);
            arrayHandler.setNumbers(null);
            return arrayHandler;
        }
        else if (arrayHandler.getWhat().equals("multiply")) {
            int sum = 1;
            for (int number : arrayHandler.getNumbers()) {
                sum *= number;
            }
            arrayHandler.setResult(sum);
            arrayHandler.setWhat(null);
            arrayHandler.setNumbers(null);
            return arrayHandler;
        }
        else if (arrayHandler.getWhat().equals("double")) {
            int[] output = arrayHandler.getNumbers();
            for (int i = 0; i < output.length; i++) {
                output[i] *= 2;
            }
            // arrayHandler.setResults(null);
            arrayHandler.setResult(output);
            arrayHandler.setWhat(null);
            arrayHandler.setNumbers(null);
            return arrayHandler;
        }
        return arrayHandler;
    }
}
