package org.example.visitor.models.*;

import org.example.visitor.Visitor;
import lombok.Getter;

@Getter
public class Restaurant extends Client {

    public final boolean availableAbroad;

    public Restaurant(String name, String address, String number, boolean availableAbroad) {
        super(name, address, number);
        this.availableAbroad = availableAbroad;
    }

    @Override
    public void accept(Visitor visitor) {
        visitor.visit(this);
    }
}

