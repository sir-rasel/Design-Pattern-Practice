package org.example.visitor;

import org.example.visitor.models.*;

import java.util.List;

public class InsuranceMessagingVisitor implements Visitor {

    public void sendInsuranceMails(List<Client> clients) {
        for (Client client : clients) {
            client.accept(this);
        }
    }

    public void visit(Bank bank) {
        System.out.println("Sending mail about theft insurance to " + bank.getName());
    }

    public void visit(Company company) {
        System.out.println("Sending employees and equipment insurance mail to " + company.getName());
    }

    public void visit(Resident resident) {
        System.out.println("Sending mail about medical insurance to " + resident.getName());
    }

    public void visit(Restaurant restaurant) {
        System.out.println("Sending mail about fire and food insurance to " + restaurant.getName());
    }
}

