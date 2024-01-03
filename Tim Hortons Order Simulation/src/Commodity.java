/**
 * Gets the production cost and retail price
 * @author Ahmed Nakhuda, 0000878456
 */
public interface Commodity {
    /**
     * Gets the production cost
     * @return production cost
     */
    public abstract double getProductionCost();

    /**
     * Gets the retail price
     * @return retail price
     */
    public abstract double getRetailPrice();
}
