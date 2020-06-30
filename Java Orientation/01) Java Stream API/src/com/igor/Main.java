package com.igor;

import java.util.*;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {

        // Write a Stream Expression to get the even numbers from the following list:
        List<Integer> n1 = Arrays.asList(1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14);

        System.out.println();
        n1.stream().filter(n -> n % 2 == 0).forEach(System.out::println);


        // Write a Stream Expression to get the squared value of the positive numbers from the following list:
        List<Integer> n2 = Arrays.asList(1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14);

        System.out.println();
        n2.stream()
                .filter(n -> n > 0)
                .map(n -> (int) Math.pow(n, 2))
                .forEach(System.out::println);


        // Write a Stream Expression to find which number squared value is more than 20 from the following list:
        List<Integer> n3 = Arrays.asList(3, 9, 2, 8, 6, 5);

        System.out.println();
        n3.stream()
                .filter(n -> (int) Math.pow(n, 2) > 20)
                .forEach(System.out::println);


        // Write a Stream Expression to get the average value of the odd numbers from the following list:
        List<Integer> n4 = Arrays.asList(1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14);

        double averageN4 =  n4.stream()
                .mapToDouble(x -> x)
                .filter(n -> n % 2 != 0)
                .average()
                .orElse(0);
        System.out.println("\n" + averageN4);

        // Write a Stream Expression to get the sum of the odd numbers in the following list:
        List<Integer> n5 = Arrays.asList(5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2);

        int sumN5 = n5.stream()
                .mapToInt(x -> x)
                .filter(n -> n % 2 != 0)
                .sum();

        System.out.println("\n" + sumN5);


        // Write a Stream Expression to find the uppercase characters in a string!
        String n6 = "Abraham \"Gangsta Killa\" Lincoln";

        System.out.println();
        List<Character> upperCases = n6.chars()
                .mapToObj(letter -> (char) letter)
                .filter(Character::isUpperCase)
                .collect(Collectors.toList());
        upperCases.stream()
                .forEach(System.out::println);


        // Write a Stream Expression to find the strings which starts with a given letter(as parameter),
        // in the following list:
        List<String> n7 = Arrays.asList("ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI",
                "AMSTERDAM", "ABU DHABI", "PARIS");

        System.out.println();
        String parameter = "a";
        n7.stream()
                .filter(city -> city.startsWith(parameter.toUpperCase()))
                .forEach(System.out::println);


        // Write a Stream Expression to concatenate a Character list to a string!
        String n8 = "I like to move it, move it, I like TA.. ";
        List<Character> charList1 = Arrays.asList('M', 'O', 'V', 'E', ' ', 'I', 'T', '!');

        String newString = n8 + charList1.stream()
                .map(String::valueOf)   // .map(letter -> letter.toString())
                .collect(Collectors.joining());

        System.out.println("\n" + newString);


        // Write a Stream Expression to find the frequency of characters in a given string!
        String n9 = "Aveeeeee Mariiiiiiiiiiia";

        n9 = n9.replaceAll(" ", "");
        List<Character> charList2 = n9.chars()
                .map(Character::toLowerCase)
                .mapToObj(ch -> (char) ch)
                .collect(Collectors.toList());

        Map<Character, Long> frequencyOfChars = charList2.stream()
                .collect(Collectors.groupingBy(ch -> ch, Collectors.counting()));

        System.out.println();
        frequencyOfChars.entrySet().stream()
                .forEach(System.out::println);


        // Create a Fox class with 3 properties: name, color and age Fill a list with at least 5 foxes and:
        System.out.println();

        class Fox {
            private String name;
            private String color;
            private int age;

            public Fox() {
                name = "Dumbass";
                color = "Red";
                age = 4;
            }
            public Fox(String Name) {
                name = Name;
                color = "Red";
                age = 4;
            }
            public Fox(String Name, String Color) {
                name = Name;
                color = Color;
                age = 4;
            }
            public Fox(String Name, String Color, int Age) {
                name = Name;
                color = Color;
                age = Age;
            }

            public String getName() {
                return name;
            }
            public String getColor() {
                return color;
            }
            public int getAge() {
                return age;
            }

            @Override
            public String toString() {
                return String.format("%s %s", color, name);
            }
        }

        List<Fox> foxes = new ArrayList<>();
        Fox dumbass = new Fox();
        foxes.add(dumbass);
        Fox ray = new Fox("Ray", "Green");
        foxes.add(ray);
        Fox zebra = new Fox("Zebra", "White",7);
        foxes.add(zebra);
        Fox ripper = new Fox("Ripper", "Green", 6);
        foxes.add(ripper);
        Fox zoro = new Fox("Zoro", "Black", 4);
        foxes.add(zoro);

        // Write a Stream Expression to find the foxes with green color!
        foxes.stream()
                .filter(fox -> fox.getColor().equals("Green"))
                .forEach(System.out::println);

        // Write a Stream Expression to find the foxes with green color, and age less then 5 years!
        System.out.println();
        foxes.stream()
                .filter(fox -> fox.getColor().equals("Green") && fox.getAge() < 5)
                .forEach(System.out::println);

        // Write a Stream Expression to find the frequency of foxes by color!
        Map<String, Long> frequencyOfFoxes = foxes.stream()
                .collect(Collectors.groupingBy(Fox::getColor, Collectors.counting()));
        System.out.println();
        frequencyOfFoxes.entrySet().stream()
                .forEach(System.out::println);


        // Exercise 11 Init:
        Exer11.run();
    }
}
