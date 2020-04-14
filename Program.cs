using System;

namespace ResponsiPemrograman2692
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan = new Karyawan(20202020, "Rizqaputra", 2000000);
            Karyawan karyawan2 = new Karyawan(10101010, "Junaidi", 1500000);

            Console.WriteLine("=============== [Gaji Normal] =================");
            Console.WriteLine("NIK\t\t Nama \t\t Gaji");
            Console.WriteLine("---------------------------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n============= [Kenaikan Gaji] ================");

            Console.WriteLine("NIK\t\t Nama\t\t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.kenaikangaji();
            karyawan2.kenaikangaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiRutin { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiRutin = 0;
            }
            else
            {
                this.gajiRutin = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiRutin);
        }

        public void kenaikangaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiRutin;
            gajiRutin += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiRutin);
        }
    }
}