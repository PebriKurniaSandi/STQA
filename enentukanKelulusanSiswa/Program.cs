using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenentukanKelulusanSiswa
{
    /// <summary>
    /// main class
    /// </summary>
    class NilaiAkhirSiswa
    {
        /// <summary>
        /// menentukan untuk pembagian public doubel dan void
        /// </summary>
        public double Nkehad, Nus, Nunbk, Nprak;
        public string Nswa, Alfabet, Predikat;
        public void Input()
        {
            /*menentukan nilai yang akan digunakan untuk menghitung nilai akhir dan mencari rata-rata*/
            Console.Write("Nama  Siswa = ");
            Nswa = Convert.ToString(Console.ReadLine());
            Console.Write("Nilai Kehadiran = ");
            Nkehad = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai US = ");
            Nus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai UNBK = ");
            Nunbk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai Praktek = ");
            Nprak = Convert.ToDouble(Console.ReadLine());
        }
        public double Akhir(double Nkehadiran, double Nus, double Nunbk, double Nprak)
        {
            /*menentukan presentase nilai yang akan di jumlahkan*/
            return (Nkehadiran * 0.1) + (Nus * 0.3) + (Nunbk * 0.4) + (Nprak * 0.2);
        }
        public void Keterangan()
        {
            /*keterangan lulus  atau tidaknya mahasiawa/i*/
            
            if (Akhir(Nkehad, Nus, Nunbk, Nprak) >= 65)
            {
                Alfabet = "L";
                Predikat = "Lulus";
            }
            else
            {
                Alfabet = "TL";
                Predikat = "Tidak Lulus";
            }
        }
        public void Tampilan()
        {
            /*untuk menampilkan hasil akhir*/
            Console.WriteLine("Nilai Akhir = {0} \nAlfabet = {1} \nPredikat = {2}", Akhir(Nkehad, Nus, Nunbk, Nprak), Alfabet, Predikat);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            NilaiAkhirSiswa NA = new NilaiAkhirSiswa();
            NA.Input();
            NA.Keterangan();
            NA.Tampilan();
        }
    }
}