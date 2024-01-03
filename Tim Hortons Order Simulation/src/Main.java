/**
 * Lets the user take their order
 * @author Ahmed Nakhuda, 000878546
 */
public class Main {
    public static void main(String[] args) {
        TimsOrder t = TimsOrder.create();
        System.out.println(t);
        System.out.printf("Your final total is: $%.2f\n", t.getAmountDue());
    }
}