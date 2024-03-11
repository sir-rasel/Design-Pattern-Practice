package org.example.flyweight;

import java.util.List;
import java.util.Random;

public class MainApp {

    private static final int BOOK_TYPES = 2;
    private static final int BOOKS_TO_INSERT = 10_000_000;

    public static void main(String[] args) {

        Store store = new Store();
        for (int i = 0; i < BOOKS_TO_INSERT / BOOK_TYPES; i++) {
            store.storeBook(getRandomName(), getRandomPrice(), "Action", "Follett", "Stuff");
            store.storeBook(getRandomName(), getRandomPrice(), "Fantasy", "Ingram", "Extra");
        }
//        store.displayBooks();
        System.out.println(BOOKS_TO_INSERT + " Books Inserted");
        System.out.println("==========================================");
        System.out.println("Memory Usage: ");
        System.out.println("Book Size (20 bytes) * " + BOOKS_TO_INSERT + " + BookTypes Size (30 bytes) * " + BOOK_TYPES + "");
        System.out.println("==========================================");
        System.out.println("Total: " + ((BOOKS_TO_INSERT * 20 + BOOK_TYPES * 30) / 1024 / 1024) + "MB (instead of " + ((BOOKS_TO_INSERT * 50) / 1024 / 1024) + "MB)");
        // Tip: Try to comment out the @ToString annotation in the BookType class and check that indeed the same two objects are being referenced by all our books!

    }

    private static String getRandomName() {
        List<String> books = List.of("book_1", "book_2", "book_3", "book_4", "book_5", "book_6", "book_7", "book_8", "book_9", "book_10");
        return books.get(new Random().nextInt(books.size()));
    }

    private static double getRandomPrice() {
        return new Random().nextDouble(10, 200);
    }
}
