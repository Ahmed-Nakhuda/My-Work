/**
 * Die class, get number of sides,
 * current side, and roll once
 * @author Ahmed Nakhuda, 000878456
 */
public class Die {
    /** Number of sides */
    private int numSides;
    /** Current side */
    private int currentSide;

    /**
     * Set numSides to sides and set current side
     * @param sides how many sides
     */
    public Die(int sides) {
        numSides = sides;
        currentSide = 1;
    }

    /**
     * Return current side
     */
    public int getCurrentSide() {
        return currentSide;
    }

    /**
     * Roll dice and get random side
     */
    // Generate a random value for the die and multiply the result by the number of sides on the die.
    public void roll() {
        currentSide = (int) (Math.random() * numSides +1); //+1 to make inclusive.
    }

    /**
     * To String method prints number of sides and current side on a die
     */
    public String toString() {
        return "Die with " + numSides + " sides, is showing " + currentSide;
    }
}
