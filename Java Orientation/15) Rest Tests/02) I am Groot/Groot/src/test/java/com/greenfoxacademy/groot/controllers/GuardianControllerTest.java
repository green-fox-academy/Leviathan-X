package com.greenfoxacademy.groot.controllers;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.WebMvcTest;
import org.springframework.http.MediaType;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.test.web.servlet.MockMvc;

import static org.junit.Assert.*;

import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.post;
import static org.springframework.test.web.servlet.result.MockMvcResultHandlers.print;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.*;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.*;
import static org.hamcrest.Matchers.is;

@RunWith(SpringRunner.class)
@WebMvcTest(GuardianController.class)
public class GuardianControllerTest {

    @Autowired
    private MockMvc mockMvc;

    @Test
    public void grootMessageGET_withParameter() throws Exception {
        mockMvc.perform(get("/groot?message=Yoyoyo")
                .contentType(MediaType.APPLICATION_JSON))
                .andExpect(status().isOk())
                .andExpect(jsonPath("$.received", is("Yoyoyo")))
                .andExpect(jsonPath("$.translated", is("I am Groot!")))
                .andReturn();
    }

    @Test
    public void grootMessageGET_withoutParameter() throws Exception {
        mockMvc.perform(get("/groot")
                .contentType(MediaType.APPLICATION_JSON))
                .andExpect(status().isBadRequest())
                .andExpect(jsonPath("$.error", is("I am Groot!")))
                .andReturn();
    }

    @Test
    public void yonduArrowGET_withParameters() throws Exception {
        mockMvc.perform(get("/yondu?distance=100.0&time=10.0")
                .content(String.valueOf(MediaType.APPLICATION_JSON)))
                .andExpect(status().isOk())
                .andExpect(jsonPath("$.distance", is(100.0)))
                .andExpect(jsonPath("$.time", is(10.0)))
                .andExpect(jsonPath("$.speed", is(10.0)))
                .andReturn();
    }

    @Test
    public void yonduArrowGET_withParametersWithTimeAsZero() throws Exception {
        mockMvc.perform(get("/yondu?distance=100.0&time=0.0")
                .content(String.valueOf(MediaType.APPLICATION_JSON)))
                .andExpect(status().isOk())
                .andExpect(jsonPath("$.distance", is(100.0)))
                .andExpect(jsonPath("$.time", is(0.0)))
                .andExpect(jsonPath("$.speed", is("Infinity")))
                .andReturn();
    }

    @Test
    public void yonduArrowGET_withoutParameters() throws Exception {
        mockMvc.perform(get("/yondu")
                .content(String.valueOf(MediaType.APPLICATION_JSON)))
                .andExpect(status().isBadRequest())
                .andExpect(jsonPath("$.error", is("Fuck!")))
                .andReturn();
    }
}