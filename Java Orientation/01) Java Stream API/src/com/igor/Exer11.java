package com.igor;

// Find a random Wikipedia article and copy the contents to a txt file.
// Create a Stream expression which reads all text from this file, and
// prints the 100 most common words in descending order. Keep in mind that the text
// contains punctuation characters which should be ignored. The result should be something like this:

// the: 131
// of: 74
// and: 48
// to: 45
// a: 43
// in: 43
// was: 30
// as: 21
// German: 18
// for: 16
// his: 15
// by: 13
// he: 11
// that: 11

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Collections;
import java.util.Map;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class Exer11 {

    public static void run() {
        System.out.println();

        Path sourceFile = Paths.get("src/text.txt");
        String input = "";

        try {
            input = Files.readString(sourceFile);
        } catch (Exception e) {
            System.out.println("\nError! \n" + e);
        }

        //Map<String, Long> output = Stream.of(input.split(" "))
    }
}
