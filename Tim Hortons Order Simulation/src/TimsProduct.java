/**
 * Used to create the Tim Hortons order in the TimsOrder class
 * @author Ahmed Nakhuda, 000878456
 */
public class TimsProduct implements Commodity {
    /** Name of product */
    private String name;
    /** Production cost of product */
    private double cost;
    /** Price of product */
    private double price;

    /**
     * TimsProduct constructor
     * @param name product name
     * @param cost production cost
     * @param price retail cost
     */
    public TimsProduct(String name, double cost, double price) {
        this.name = name;
        this.cost = cost;
        this.price = price;
    }

    /**
     * Get product name
     * @return name
     */
    public String getName() {
        return name;
    }

    /**
     * Get production cost
     * @return cost
     */
    @Override
    public double getProductionCost() {
        return cost;
    }

    /**
     * Get retail price
     * @return price
     */
    @Override
    public double getRetailPrice() {
        return price;
    }

    /**
     * TimsProduct toString
     * @return TimsProduct toString
     */
    @Override
    public String toString() {
        return "TimsProduct{" +
                "name='" + name + '\'' +
                ", cost=" + cost +
                ", price=" + price +
                '}';
    }
}
