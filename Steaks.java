public class Steaks {

    public static void main (String[] args) {

        String[] Steaks = new String[10];
        Double[] prices = new Double[10];

        Steaks[0] = "Wagyu A5";
        Steaks[1] = "Brisket";
        Steaks[2] = "Ribs";

        prices[0] = 200.0;
        prices[1] = 149.99;
        prices[2] = 99.99;

        System.out.println("-----5kg Steaks-----");

        int sizeofSteaks = Steaks.length;

        for (int i = 0; i < sizeofSteaks; i++) {

            if (Steaks[i] == null) {

                break;
            }

            System.out.println("Steaks: " + Steaks[i] + " | Price: $" + prices[i]);
        }
    }
}