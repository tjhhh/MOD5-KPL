// See https://aka.ms/new-console-template for more information
using System;
using jurnalmod5_103022300065;
class program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Masukkan input pertama");
        double input1 = 12.0;
        Console.WriteLine(input1);
        Console.WriteLine("Masukkan input kedua");
        double input2 = 34.0;
        Console.WriteLine(input2);
        Console.WriteLine("Masukkan input ketiga");
        double input3 = 56.0;
        Console.WriteLine(input3);
        PemrosesanData proses = new PemrosesanData();
        proses.DapatkanNilaiTerbesar(input1, input2, input3);

        SimpleDataBase<double> simpan = new SimpleDataBase<double>();
        simpan.addNewData(input1);
        simpan.addNewData(input2);
        simpan.addNewData(input3);
        simpan.PrintAllData();

    }
}
