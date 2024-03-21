internal class Program
{

    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase() {
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
        SimpleDataBase<int> objDB = new SimpleDataBase<int>();
        objDB.AddNewData(13);
        objDB.AddNewData(02);
        objDB.AddNewData(22);
        objDB.PrintAllData();
    }
}