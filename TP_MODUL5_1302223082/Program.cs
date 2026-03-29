using System;

namespace TP_MODUL5_1302223082
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Halo user {input}");
        }
    }

    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            string namaPanggilan = "Dzaky";
            halo.SapaUser(namaPanggilan);

            string nimPraktikan = "1302223082";
            DataGeneric<string> dataNim = new DataGeneric<string>(nimPraktikan);
            dataNim.PrintData();

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}