package org.example.flyweight;

import java.util.HashMap;
import java.util.Map;

public class BookFactory {

    private static final Map<String, BookType> bookTypes = new HashMap<>();

    public static BookType getBookType(String type, String distributor, String otherData) {
        if (bookTypes.get(type) == null) {
            bookTypes.put(type, new BookType(type, distributor, otherData));
        }
        return bookTypes.get(type);
    }
}

