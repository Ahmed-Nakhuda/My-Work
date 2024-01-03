/**
 * Create a coffee item
 * @author Ahmed Nakhuda, 000878546
 */

import java.util.Scanner;

public class Coffee extends TimsProduct implements Consumable {
    /** Amount of calories in coffee */
    private int calorieCount;

    /**
     * Coffee constructor
     * @param name type of coffee
     * @param cost production cost
     * @param price retail price
     * @param calorieCount amount of calories
     */
    public Coffee(String name, double cost, double price, int calorieCount) {
        super(name, cost, price);
        this.calorieCount=calorieCount;
    }

    /**
     * Creates a coffee item
     * @return Coffee object
     */
    public static Coffee create() {
        Scanner sc = new Scanner(System.in);

        System.out.println("What type of coffee would you like?");
        String name = sc.nextLine();

        System.out.println("What is the production cost of " + name + "?");
        double cost = sc.nextDouble();

        System.out.println("What is the retail price of " + name + "?");
        double price = sc.nextDouble();

        System.out.println("What is the calorie count of " + name + "?");
        int calorieCount = sc.nextInt();

        return new Coffee(name, cost, price, calorieCount);
    }

    /**
     * Get amount of calories
     * @return amount of calories
     */
    @Override
    public int getCalorieCount() {
        return calorieCount;
    }

    /**
     * Method of consuming
     * @return drink it
     */
    @Override
    public String getConsumptionMethod() {
        return "Drink it";
    }

    /**
     * Coffee toString
     * @return Coffee toString
     */
    @Override
    public String toString() {
        return "Coffee{" +
                "name='" + getName() + '\'' +
                ", production cost=" + getProductionCost() +
                ", price=" + getRetailPrice() +
                ", calorieCount=" + getCalorieCount() +
                ", Consumption method=" + getConsumptionMethod() +
                '}';
    }
}
