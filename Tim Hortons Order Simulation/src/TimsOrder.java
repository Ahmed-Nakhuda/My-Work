/**
 * Creates the orders for the customers
 * @author Ahmed Nakhuda, 000878456
 */

import java.util.Scanner;

public class TimsOrder {
    /** Customers name */
    private String name;
    /** Array to hold the products the customers order */
    private TimsProduct[] products;

    /**
     * Constructor for TimsOrder
     * @param name name of the customer
     * @param products products user orders
     */
    private TimsOrder(String name, TimsProduct[] products) {
        this.name = name;
        this.products = products;
    }

    /**
     * Creates the order by getting the user's input
     * @return TimsOrder
     */
    public static TimsOrder create() {
        Scanner sc = new Scanner(System.in);

        // Get the name
        System.out.println("Welcome to Tim Hortons, What is your name?");
        String name = sc.nextLine();

        // Get how many items the user wants to order and store it in numItems
        System.out.println("How many items would you like to order?");
        int numItems = sc.nextInt();

        // Create a new array called products
        TimsProduct[] products = new TimsProduct[numItems];
        for (int i = 0; i < numItems; i++) { // Keep on prompting the user until they have ordered all their items

            // Prompt the user for the type of product they want to order
            System.out.println("Choose one of the following items: Coffee/Donut/Mug/Thermos (enter in lowercase):");

            // Create the object based on what the user picked
            String option = sc.next();
            if (option.equals("mug")) {
                products[i] = Mug.create();
            } else if (option.equals("donut")) {
                products[i] = Donut.create();
            } else if (option.equals("thermos")) {
                products[i] = Thermos.create();
            } else if (option.equals("coffee")) {
                products[i] = Coffee.create();
            } else {
                System.out.println("Please choose one of the items listed above");
            }
        }

        return new TimsOrder(name, products);
    }

    /**
     * Calculates the amount due for the order by adding the retail prices of the items
     * @return the amount due for the order
     */
    public double getAmountDue() {
        double amountDue = 0;
        for (TimsProduct product : products) {
            amountDue += product.getRetailPrice();
        }
        return amountDue;
    }

    /**
     * Create a string with the customer's name and call the toString method
     * for each product and adds it to the string
     * @return TimsOrder toString
     */
    @Override
    public String toString() {
        String str = "Order for " + name + ":\n";
        for (TimsProduct product : products) {
            str += product.toString() + "\n";
        }
        return str;
    }
}
