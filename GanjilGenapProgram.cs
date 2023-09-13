using System;
namespace GanjilGenapProgram
{
    public class Program
    {
        // Tampilan MENU UTAMA program.
        static void Menu()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("                 MENU GANJIL GENAP");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1. Cek Ganjil Genap");
            Console.WriteLine("2. Print Ganjil/Genap (dengan Limit)");
            Console.WriteLine("3. Exit");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }


        // MENU 1 - Mengecek apakah bilangan yang diinput adalah ganjil atau genap menggunakan Decision.
        static string CekGanjilGenap(int input)     // Deklarasi method CekGanjilGenap yang mengembalikan nilai string, dengan parameter `input` bertipe `int`. 
        {
            return (input < 1) ? "(!)Input tidak valid. Silakan pilih lagi.(!)" : (input % 2 == 0) ? "Genap" : "Ganjil";

            /* Baris kode di atas menggunakan operator ternary `?:`. Pertama akan memeriksa apakah input < 1. Jika benar, maka ekspresi pertama setelah tanda `?`
             * akan dikembalikan, yaitu string bahwa input tidak valid. Jika input < 1 salah, maka ekspresi setelah tanda `:` yaitu `input % 2 == 0` akan dievaluasi 
             * dan diperiksa. Jika benar, maka string "Genap" akan dikembalikan sebagai hasil. Jika salah, maka string "Ganjil" akan dikembalikan sebagai hasil. */
        }


        // MENU 2 - Mencetak bilangan ganjil atau genap dengan batas limit yang ditentukan menggunakan Decision.

        static void PrintGanjilGenap(string pilihan)     /* Method `PrintGanjilGenap` dengan bentuk statis, serta void yang berarti tidak mengembalikan nilai apapun.
                                                         * Method ini menerima satu parameter bertipe string dengan nama "pilihan", untuk menentukan
                                                         * apa yang harus dicetak (Ganjil atau Genap). */
        {
            Console.Write("Masukkan limit: ");

            if (int.TryParse(Console.ReadLine(), out int limit) && limit >= 1)
            /* `Console.ReadLine()` : membaca input dari pengguna melalui konsol, akan mengambil input berupa teks dan mengembalikannya sebagai string.
             * `int.TryParse(Console.ReadLine(), out int limit)` : mengkonversi string yang dibaca dari Console.ReadLine() menjadi integer. Jika konversi berhasil,
             * nilai integer yang dikonversi akan disimpan dalam variabel `limit`. Jika gagal, maka `limit` akan diisi dengan nilai default dari tipe data integer, yaitu 0. */

            {
                Console.Write($"Print bilangan 1 - {limit}: ");     // Mencetak teks yang diikuti dengan nilai yg diinput pada variabel `limit`.

                    for (int i = 1; i <= limit; i++)        /* variabel `i` ditetapkan dengan nilai 1. Perulangan akan terus berlanjut selama nilai `i` kurang dari
                                                             * atau sama dengan nilai `limit`. Saat `i` mencapai nilai limit, perulangan akan berhenti. Dan setiap kali
                                                             * perulangan selesai, nilai `i` akan ditingkatkan sebesar 1 (i++) sehingga dapat melakukan perulangan
                                                             * melalui bilangan bulat dari 1 hingga limit. */
                    {
                        if ((pilihan == "Ganjil" && i % 2 != 0) || (pilihan == "Genap" && i % 2 == 0))      /* `pilihan == "Ganjil" && i % 2 != 0` : memeriksa nilai variabel `pilihan`
                                                                                                             * sama dengan "Ganjil" dan juga apakah nilai variabel `i` memiliki sisa
                                                                                                             * pembagian yang tidak sama dengan 0. Jika kedua kondisi benar, maka akan
                                                                                                             * menghasilkan nilai "true".
                                                                                                             * `pilihan == "Genap" && i % 2 == 0` : jika variabel `pilihan` sama dengan
                                                                                                             * "Genap" dan nilai variabel `i` memiliki sisa pembagian yang sama dengan 0,
                                                                                                             * maka kedua kondisi benar dan menghasilkan nilai "true".
                                                                                                             * Kedua bagian ini digabungkan menggunakan operator logika OR `||`, akan
                                                                                                             * menghasilkan nilai "true" jika salah satunya menghasilkan nilai "true". */
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    Console.WriteLine();
            }
            else        // Jika kondisi di atas tidak terpenuhi, maka akan mencetak pesan input tidak valid.
                {
                    Console.WriteLine("(!)Input tidak valid. Silakan pilih lagi.(!)");
                }
        }



        // Fungsi utama program.
        public static void Main()
        {
            bool exit = false;     /* Variabel untuk mengontrol apakah program akan keluar atau tidak. Jika nilai variabel `exit` bukan `true`,
                                    * maka loop akan terus berjalan. Loop akan berhenti saat variabel `exit` bernilai `true`. */

            while (!exit)       // Loop utama program, selama kondisi "exit" tidak terpenuhi, maka block code yang ada di dalam loop akan terus dijalankan.
            {
                Menu();     // Memanggil fungsi Menu() untuk menampilkan menu utama.
                Console.Write("Pilih menu (1/2/3): ");
                string pilihmenu = Console.ReadLine();      // Membaca input menu. Input ini akan disimpan dalam variabel `pilihmenu` sebagai string.

                switch (pilihmenu)
                {
                    case "1":
                        Console.Write("Masukkan bilangan yang ingin dicek: ");
                        int input = int.Parse(Console.ReadLine());      /* Membaca input pengguna dengan `Console.ReadLine()` dan mengkonversinya ke tipe data int
                                                                         * menggunakan `int.Parse()`. Hasilnya disimpan dalam variabel input.
                                                                         * `int.Parse()` digunakan untuk memastikan bahwa input yang dimasukkan adalah bilangan bulat. */

                        Console.WriteLine(CekGanjilGenap(input));       // Memeriksa apakah bilangan tersebut genap atau ganjil dengan memanggil fungsi `CekGanjilGenap()`.
                        break;
                    case "2":
                        Console.Write("Pilih (Ganjil/Genap): ");
                        string jenis = Console.ReadLine();              // Membaca input pengguna dengan Console.ReadLine(), input disimpan dalam variabel `jenis` sebagai string.
                        if (jenis == "Ganjil" || jenis == "Genap")      // Memeriksa nilai input dalam `jenis` sama dengan "Ganjil" atau "Genap", jika benar maka input adalah valid.
                        {
                            PrintGanjilGenap(jenis);    // Memanggil fungsi `PrintGanjilGenap` untuk mencetak bilangan ganjil/genap.
                        }
                        else                            // Jika kondisi tidak terpenuhi (input bukan "Ganjil"/"Genap"), program akan memberi tahu bahwa input tidak valid.
                        {
                            Console.WriteLine();
                            Console.WriteLine("(!)Input tidak valid. Silakan pilih lagi.(!)");
                            Console.WriteLine();
                            Console.WriteLine("====================================================");
                        }
                        break;
                    case "3":
                        exit = true;        // Keluar dari program jika memilih pilihan 3, sehingga nilai variabel `exit` menjadi `true`.
                        Console.WriteLine("Keluar dari program.");
                        break;
                    default:                // Pilihan default dijalankan ketika tidak ada `case` yang cocok dengan input yang dimasukkan, sehingga mencetak pesan input tidak valid.
                        Console.WriteLine();
                        Console.WriteLine("(!)Input pilihan tidak valid. Silakan pilih lagi.(!)");
                        Console.WriteLine();
                        Console.WriteLine("====================================================");
                        break;
                }
            }
        }
    }
}