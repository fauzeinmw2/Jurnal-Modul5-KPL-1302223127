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

    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            Console.WriteLine("Isi Seluruh Data : ");
            for (int i = 0; i < this.storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi : {this.storedData[i]}, yang disimpan pada waktu UTC : {this.inputDates[i].ToString("dd/MM/yyyy hh:mm:ss tt")}");
            }
        }
    }
    private static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
        SimpleDataBase<int> objDB = new SimpleDataBase<int>();
        objDB.AddNewData(13);
        objDB.AddNewData(02);
        objDB.AddNewData(22);
        objDB.PrintAllData();
    }

}
