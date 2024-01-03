/**
 * Gets the calorie count and consumption method
 * @author Ahmed Nakhuda, 0000878456
 */
public interface Consumable {
    /**
     * Gets the calorie count
     * @return calorie count
     */
    public abstract int getCalorieCount();

    /**
     * Gets the consumption method
     * @return consumption method
     */
    public abstract String getConsumptionMethod();
}
