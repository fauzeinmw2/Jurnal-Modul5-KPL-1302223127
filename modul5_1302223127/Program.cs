internal class Program
{
    public class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;
            T hasil = tempA + tempB + tempC;
            Console.WriteLine($"Hasil Penjumlahan : {hasil}"); 
        }
    }
    private static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
    }
}