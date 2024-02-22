package org.example.bridge;

import org.example.bridge.abstractions.AmericanRestaurant;
import org.example.bridge.abstractions.ItalianRestaurant;
import org.example.bridge.abstractions.Restaurant;
import org.example.bridge.implementations.PepperoniPizza;
import org.example.bridge.implementations.VeggiePizza;

public class MainApp {

    public static void main(String[] args) {

        Restaurant americanRestaurant = new AmericanRestaurant(new PepperoniPizza());
        americanRestaurant.deliver();

        System.out.println("==========================================");

        Restaurant italianRestaurant = new ItalianRestaurant(new VeggiePizza());
        italianRestaurant.deliver();

    }

}
