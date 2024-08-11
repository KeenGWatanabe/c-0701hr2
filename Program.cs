public class Program
{
    static float vat = 19f; // for scope of the class Program

    public static void Main() // <- method
    {
        float vat =15; // for the scope of the method

        Console.WriteLine("Total vat is " + vat);
    }

    public static void Calculate()
    {
        Console.WriteLine("Vat is  " + vat);
    }
}
