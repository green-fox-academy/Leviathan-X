package com.greenfoxacademy.api;

import static org.assertj.core.api.Assertions.assertThat;

import com.greenfoxacademy.api.controllers.APIController;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;

import static org.mockito.Mockito.when;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;
import static org.springframework.test.web.servlet.result.MockMvcResultHandlers.print;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.content;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;
import org.springframework.test.web.servlet.MockMvc;

@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
@AutoConfigureMockMvc
public class GreeterTest {

    @Autowired
    private MockMvc mockMvc;

    @MockBean
    private APIController apiController;

    @Test
    public void apiControllerNotNull() {
        assertThat(apiController).isNotNull();
    }

    @Test
    public void whatever() {
        when(apiController)
    }
}
