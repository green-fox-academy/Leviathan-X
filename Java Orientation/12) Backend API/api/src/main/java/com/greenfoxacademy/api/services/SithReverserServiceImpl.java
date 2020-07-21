package com.greenfoxacademy.api.services;

import com.greenfoxacademy.api.models.SithReverser;
import org.springframework.stereotype.Service;

@Service
public class SithReverserServiceImpl {

    public SithReverser run(SithReverser sithReverser) {
        String[] words = sithReverser.getText()
                .toLowerCase().replace(".", "").split("\\s+");

        String output = new String();
        int length = words.length - 1;
        if(words.length % 2 != 0) {
            length = words.length - 1;
        }

        for (int i = 0; i < length; i++) {
            output += words[i + 1] + " ";
            output += words[i] + " ";
            i++;
        }
        output += "Arrgh. Uhmmm.";

        sithReverser.setSithText(output);
        return sithReverser;
    }
}
