/**
 * Dice Collection class, get min and max sum,
 * sum of all dice, roll all, and histogram.
 * @author Ahmed Nakhuda, 000878456
 */
public class DiceCollection {
    /** Die Array */
    private Die[] dice;
    /** Minimum sum */
    private int minSum;
    /** Maximum sum */
    private int maxSum;

    /**
     * Get minimum and maximum sums
     * @param sides number of sides
     */
    public DiceCollection(int[] sides) {
        dice = new Die[sides.length]; // Create an array to represent die object.
        minSum = 0; // Set initial value
        maxSum = 0; // Set initial value
        for (int i = 0; i < sides.length; i++) { // Iterate over the elements in the sides array.
            dice[i] = new Die(sides[i]); // Create die object with the number of sides specified in the sides array.
            minSum += 1; // Update minimum sum.
            maxSum += sides[i]; // Update maximum sum.
        }
    }

    /**
     * Get the sum of the dice
     * @return sum
     */
    public int getCurrentSum() {
        int sum = 0; // Set initial value
        for (int i = 0; i < dice.length; i++) { // Iterate over every dice in the collection.
            sum += dice[i].getCurrentSide(); // Add the value showing on the current die to the sum.
        }
        return sum;
    }

    /**
     * Roll all the dice
     */
    public void rollAll() {
        for (int i = 0; i < dice.length; i++) { // Iterate over the dice in the collection.
            dice[i].roll(); // Roll all the dice.
        }
    }

    /**
     * Count occurrences of each outcome
     * @param numRolls number of rolls
     * @return count
     */
    public int[] histogram(int numRolls) {
        // The number of elements in the array.
        int[] count = new int[maxSum - minSum + 1];
        // Roll all the dice in the collection numRolls times and update the count array.
        for (int i = 0; i < numRolls; i++) {
            // Roll all the dice.
            rollAll();
            // Get the current sum of the dice.
            int sum = getCurrentSum();
            // Increment the count of the current sum in the count array.
            count[sum - minSum]++;
        }
        return count;
    }

    /**
     * To String method prints the dice collection
     * @return output
     */
    public String toString() {
        // Create string named output.
        String output = "Dice collection:\n";
        // Iterate over each die in the collection and append it in a string representation.
        for (int i = 0; i < dice.length; i++) {
            output += dice[i].toString() + "\n";
        }
        // Append to the output string.
        output += "Minimum possible roll: " + minSum + "\n";
        output += "Maximum possible roll: " + maxSum + "\n";
        output += "Current sum: " + getCurrentSum();
        return output;
    }
}
