/**
 * Create a donut item
 * @author Ahmed Nakhuda, 000878546
 */

import java.util.Scanner;

public class Donut extends TimsProduct implements Consumable {
    /** Donut description */
    private String description;
    /** amount of calories  */
    private int calorieCount;

    /**
     * Donut constructor
     * @param name name of donut
     * @param cost production cost
     * @param price retail price
     * @param description donut description
     * @param calorieCount amount of calories
     */
    public Donut(String name, double cost, double price, String description, int calorieCount) {
        super(name, cost, price);
        this.description = description;
        this.calorieCount = calorieCount;
    }

    /**
     * Creates a donut item
     * @return Donut object
     */
    public static Donut create() {
        Scanner sc = new Scanner(System.in);

        System.out.println("What type of donut would you like to order?");
        String name = sc.nextLine();

        System.out.println("What is the production cost of " + name + "?");
        double cost = sc.nextDouble();

        System.out.println("What is the retail price of " + name + "?");
        double price = sc.nextDouble();

        sc.nextLine();

        System.out.println("What is the description of " + name + "?");
        String description = sc.nextLine();

        System.out.println("What is the calorie count of " + name + "?");
        int calorieCount = sc.nextInt();

        return new Donut(name, cost, price, description, calorieCount );
    }

    /**
     * Get donut description
     * @return donut description
     */
    public String getDescription() {
        return description;
    }

    /**
     * Get amount of calories in donut
     * @return amount of calories
     */
    @Override
    public int getCalorieCount() {
        return calorieCount;
    }

    /**
     * Consumption method for donut
     * @return eat it
     */
    @Override
    public String getConsumptionMethod() {
        return "Eat it";
    }

    /**
     * Donut toString
     * @return Donut toString
     */
    @Override
    public String toString() {
        return "Donut{" +
                "name='" + getName() + '\'' +
                ", production cost=" + getProductionCost() +
                ", price=" + getRetailPrice() +
                ", description='" + getDescription() +
                ", calorieCount=" + getCalorieCount() +
                ", Consumption method=" + getConsumptionMethod() +
                '}';
    }
}
