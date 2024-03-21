package org.example.visitor;

import org.example.visitor.models.*;

import java.util.List;

public class MainApp {

    public static void main(String[] args) {

        List<Client> clients = List.of(
                new Bank("bank_name", "bank_address", "bank_number", 10),
                new Resident("resident_name", "resident_address", "resident_number", "A"),
                new Company("company_name", "company_address", "company_number", 1000),
                new Restaurant("resto_name", "resto_address", "resto_number", true)
        );

        InsuranceMessagingVisitor visitor = new InsuranceMessagingVisitor();
        visitor.sendInsuranceMails(clients);

    }
}
