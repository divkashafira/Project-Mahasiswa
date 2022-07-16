using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        Mahasiswa mahasiswa = new Mahasiswa();
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
            Console.WriteLine();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Mahasiswa mahasiswa = new Mahasiswa();

            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();
            Console.Write("NIM: ");
            mahasiswa.NIM = Console.ReadLine();
            Console.Write("Nama: ");
            mahasiswa.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            mahasiswa.Kelamin = Console.ReadLine();
            if (mahasiswa.Kelamin == "L")
            {
                mahasiswa.Kelamin = "Laki-Laki";
            }
            else if (mahasiswa.Kelamin == "P")
            {
                mahasiswa.Kelamin = "Perempuan";
            }
            Console.Write("IPK : ");
            mahasiswa.IPK = Console.ReadLine();

            daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Data Mahasiswa");
            Console.WriteLine();
            int no = 1;

            Console.WriteLine("No\tNIM\t\tNama \t\tJenis Kelamin\tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.Kelamin, mahasiswa.IPK);
                no++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
