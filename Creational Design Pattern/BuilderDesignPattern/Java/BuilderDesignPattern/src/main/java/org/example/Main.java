package org.example;

import org.example.concrete_builder.CarBuilder;
import org.example.concrete_builder.CarSchemaBuilder;
import org.example.product_with_builder.CarManual;

public class Main {
    public static void main(String[] args) {
        Director director = new Director();

        CarBuilder builder = new CarBuilder();
        director.buildBugatti(builder);
        builder.model("Chiron");
        System.out.println(builder.build());

        CarSchemaBuilder schemaBuilder = new CarSchemaBuilder();
        director.buildLambo(schemaBuilder);
        schemaBuilder.engine("90").nbrOfDoors(3);
        System.out.println(schemaBuilder.build());

        CarManual alien = director.buildAlien();
        System.out.println(alien);
    }
}