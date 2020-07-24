package com.greenfoxacademy.api;

import com.greenfoxacademy.api.controllers.APIController;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.WebMvcTest;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
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


//@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
//@AutoConfigureMockMvc
@RunWith(SpringRunner.class)
@WebMvcTest(APIController.class)
public class GreeterTest {

    @Autowired
    private MockMvc mockMvc;

    @MockBean
    private APIController apiController;

    @Test
    public void doublingRequest_withParameters() throws Exception {
        mockMvc.perform(get("/doubling?input=5")
                .contentType(MediaType.APPLICATION_JSON))
                .andExpect(status().isOk())
                .andExpect(jsonPath("$.result", is(10)))
                .andReturn();
    }

    //@Test
    //public void greeterRequest_withParameters() throws Exception {
    //    mockMvc.perform(get("/greeter?name=Igor&title=student")
    //            .contentType(MediaType.APPLICATION_JSON))
    //            .andExpect(status().isOk())
    //            .andExpect(jsonPath("$.name", is("Igor")))
    //            .andExpect(jsonPath("$.title", is("student")))
    //            .andReturn();
    //}
}
