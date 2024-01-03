/**
 * Assignment 4, use arrays to build
 * a histogram of dice roll results.
 * @author Ahmed Nakhuda, 000878456
 */

import java.util.Scanner;
public class Main {
    public static void main(String[] args) {

        //Get the number of dice
        Scanner input = new Scanner (System.in);
        System.out.print("Enter the number of dice: ");
        int numDice = input.nextInt();

        // Create an array to hold the number of sides for each die.
        int[] sides = new int[numDice];
        for (int i = 0; i < numDice; i++) { // Iterate over each die in the collection.
            System.out.print("Enter the number of sides for die " + (i + 1) + ": "); //Get user input.
            sides[i] = input.nextInt();
        }

        // Create and print dice collection.
        DiceCollection collection = new DiceCollection(sides);
        collection.rollAll();
        System.out.println(collection);

        //Select a choice
        while (true) {
            System.out.println("\nSelect a choice:");
            System.out.println("1. Roll once");
            System.out.println("2. Roll 100,000 times");
            System.out.println("3. Exit");
            int choice = input.nextInt();

            if (choice == 1) {
                // Roll all dice once and print dice collection.
                collection.rollAll();
                System.out.println(collection);
            } else if (choice == 2) {
                // Create a histogram of 100000 rolls for the dice collection.
                int[] histogram = collection.histogram(100000);
                // Iterate over each element in the histogram array.
                for (int i = 0; i < histogram.length; i++) {
                    // If the value is equal to 0 then don't print.
                    if (histogram[i] != 0) {
                        // Print the sum and the number of times that sum appears.
                        System.out.println((i+1) + ": " + histogram[i]);
                    }
                }
                // Print the dice collection
                System.out.println(collection);
            } else {
                break;
            }
        }
        System.out.println("BYE! ! !");
    }
}


