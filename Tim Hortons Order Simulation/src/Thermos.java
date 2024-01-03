/**
 * Create a thermos item
 * @author Ahmed Nakhuda, 000878546
 */

import java.util.Scanner;

public class Thermos extends TimsProduct {
    /** Amount of ounces */
    private int ounces;

    /**
     * Thermos constructor
     * @param name name of thermos
     * @param cost production cost
     * @param price retail price
     * @param ounces amount of ounces
     */
    public Thermos(String name, double cost, double price, int ounces) {
        super(name, cost, price);
        this.ounces=ounces;
    }

    /**
     * Creates a thermos item
     * @return Thermos object
     */
    public static Thermos create() {
        Scanner sc = new Scanner(System.in);

        System.out.println("What is the name of the thermos you want?");
        String name = sc.nextLine();

        System.out.println("What is the production cost of " + name + "?");
        double cost = sc.nextDouble();

        System.out.println("What is the retail price of " + name + "?");
        double price = sc.nextDouble();

        System.out.println("How many ounces do you want " + name + " to be?");
        int ounces = sc.nextInt();

        return new Thermos(name, cost, price, ounces);
    }

    /**
     * Get amount of ounces
     * @return amount of ounces
     */
    public int getOunces() {
        return ounces;
    }

    /**
     * Thermos toString
     * @return Thermos toString
     */
    @Override
    public String toString() {
        return "Thermos{" +
                "name='" + getName() + '\'' +
                ", production cost=" + getProductionCost() +
                ", price=" + getRetailPrice() +
                ", ounces=" + getOunces() +
                '}';
    }
}