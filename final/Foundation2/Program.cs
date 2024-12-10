using System;

class Program
{
    static void Main(string[] args)
    {
        Address coryAddress = new Address("58a Monk Street", "Saint Leon-Red", "Wurtenburgs Bath", "Germany");
        Address leviAddress = new Address ("1st E Second N", "Rexburg", "Idaho", "United States");

        Customer coryTillett = new Customer("Cory Tillett", coryAddress);
        Customer leviCellophane = new Customer("Levi Cellophane III", leviAddress);

        Product pilotG2Pen = new Product("Pilot G2 Pens - .32 mm Black ink", 50, 4.27, 0);
        Product webcam = new Product("Logitech 1080p USB Webcam", 1, 75, 1);
        Product legalPadMini = new Product("Stapels Legal Pad mini - White 5*8 inches", 25, 1.2, 1);
        Product postIts = new Product("Post-It's Sticky notes - Pink", 5, 2.12, 3);
        Product paperclips = new Product("Stapels paperclips - box of 100", 3, 2.67, 4);

        List<Product> coryProducts = new List<Product>{pilotG2Pen, legalPadMini, paperclips};
        List<Product> leviProducts = new List<Product>{webcam, postIts};

        Order coryOrder = new Order(coryTillett, coryProducts);
        Order leviOrder = new Order(leviCellophane, leviProducts);

        coryOrder.PrintPackingLabel();
        Console.WriteLine(coryOrder.CalculateFinalPrice());
        coryOrder.PrintShippingLabel();
        

        leviOrder.PrintPackingLabel();
        Console.WriteLine(leviOrder.CalculateFinalPrice());
        leviOrder.PrintShippingLabel();
    }
}