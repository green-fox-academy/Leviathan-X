package com.greenfoxacademy.api;

import static org.assertj.core.api.Assertions.assertThat;

import com.greenfoxacademy.api.controllers.APIController;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
public class GreeterTest {

    @Autowired
    private APIController apiController;

    @Test
    public void apiControllerNotNull() {
        assertThat(apiController).isNotNull();
    }
}
