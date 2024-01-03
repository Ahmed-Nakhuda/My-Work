/**
 * Create a mug item
 * @author Ahmed Nakhuda, 000878546
 */

import java.util.Scanner;

public class Mug extends TimsProduct {
    private String color;

    /**
     * Mug constructor
     * @param name name of mug
     * @param cost production cost
     * @param price retail price
     * @param color color of mug
     */
    public Mug(String name, double cost, double price, String color) {
        super(name, cost, price);
        this.color=color;
    }

    /**
     * Creates a mug item
     * @return Mug object
     */
    public static Mug create() {
        Scanner sc = new Scanner(System.in);
        System.out.println("What is the name of the mug you want?");
        String name = sc.nextLine();

        System.out.println("What is the production cost " + name + "?");
        double cost = sc.nextDouble();

        System.out.println("What is the retail price of " + name + "?");
        double price = sc.nextDouble();

        sc.nextLine();

        System.out.println("What color do you want " + name + " to be?");
        String color = sc.nextLine();

        return new Mug(name, cost, price, color);
    }

    /**
     * Get the color of the mug
     * @return color of the mug
     */
    public String getColor() {
        return color;
    }

    /**
     * Mug toString
     * @return Mug toString
     */
    @Override
    public String toString() {
        return "Mug{" +
                "name='" + getName() + '\'' +
                ", production cost=" + getProductionCost() +
                ", price=" + getRetailPrice() +
                ", color=" + getColor() +
                '}';
    }
}
