public class BonAppetit {

    public static void bonAppetit(List<int> bill, int k, int b){

        var annaCharged = b;
        int costBeforeSplit = 0;

        for(int i = 0; i < bill.Count; i++) {
            
            if(i != k) {

                var item = bill[i];

                costBeforeSplit += item;

            }
        }

        int annaActualCost = costBeforeSplit / 2;

        var overCharge = annaCharged - annaActualCost;

        if(overCharge == 0) {

            Console.WriteLine("Bon Appetit");

        }
        else {

            Console.WriteLine(overCharge);

        }
    }

}