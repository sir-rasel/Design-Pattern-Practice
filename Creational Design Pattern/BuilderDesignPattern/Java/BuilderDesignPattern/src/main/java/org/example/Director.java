package org.example;

import org.example.builder.Builder;
import org.example.product_with_builder.CarManual;

public class Director {
    public void buildBugatti(Builder builder) {
        builder.brand("Bugatti")
                .color("Blue")
                .nbrOfDoors(2)
                .engine("8L")
                .height(115);
    }

    public void buildLambo(Builder builder) {
        builder.brand("Lamborghini")
                .model("Aventador")
                .color("Yellow")
                .height(120);
    }

    public CarManual buildAlien() {
        return new CarManual.Builder()
                .id(1)
                .color("red")
                .engine("en")
                .brand("alien")
                .Build();
    }
}