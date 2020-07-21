package com.greenfoxacademy.api.models;

import com.fasterxml.jackson.annotation.JsonInclude;

@JsonInclude(JsonInclude.Include.NON_NULL)
public class ArrayHandler {

    private String what;
    private int[] numbers;
    private Object result;
    // private int[] results;

    public ArrayHandler() { }

    public ArrayHandler(String what, int[] numbers) {
        this.what = what;
        this.numbers = numbers;
    }

    public String getWhat() { return what; }
    public void setWhat(String what) { this.what = what; }

    public int[] getNumbers() { return numbers; }
    public void setNumbers(int[] numbers) { this.numbers = numbers; }

    public Object getResult() { return result; }
    public void setResult(Object result) { this.result = result; }

    // public int[] getResults() { return results; }
    // public void setResults(int[] results) { this.results = results; }

    // public class ResultArray {
    //     private int[] result;
    //
    //     public ResultArray() { }
    //
    //     public ResultArray(int[] result) {
    //         this.result = result;
    //     }
    //
    //     public int[] getResult() { return result; }
    //     public void setResult(int[] result) { this.result = result; }
    // }
}
