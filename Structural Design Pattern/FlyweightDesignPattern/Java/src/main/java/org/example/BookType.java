package org.example.flyweight;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.ToString;

@Getter
@ToString
@AllArgsConstructor
public class BookType {

    private final String type;
    private final String distributor;
    private final String otherData;
}

