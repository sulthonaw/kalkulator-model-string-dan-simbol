namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write(
                    "*Note\n(angka)(operasi)(angka)=" +
                    "\n(+, -, *, :)" +
                    "\n\nInput operasi : "
                );

                string input = Console.ReadLine();

                char[] simbol = { '+', '-', '*', ':' };

                int posisi = input.IndexOfAny(simbol);
                int posisiEquals = input.IndexOf('=');
                int x = input.Length - (posisi + 1) - 1;

                int pertama = Convert.ToInt32(input.Substring(0, posisi));
                int kedua = Convert.ToInt32(input.Substring(posisi + 1, x));

                char operasi = input[posisi];

                switch (operasi)
                {
                    case '+':
                        Console.WriteLine("\nHasil = " + Tambah(pertama, kedua));
                        break;
                    case '-':
                        Console.WriteLine("\nHasil = " + Kurang(pertama, kedua));
                        break;
                    case '*':
                        Console.WriteLine("\nHasil = " + Kali(pertama, kedua));
                        break;
                    case ':':
                        Console.WriteLine("\nHasil = " + Bagi(pertama, kedua));
                        break;
                    default:
                        Console.WriteLine("\nPilihan anda tidak tersedia");
                        break;
                }

                Console.Write("\napakah anda ingin melanjutkan? (y/n) ");
                char aksi = Convert.ToChar(Console.ReadLine());
                if (aksi == 'n') break;

            }
        }

        static int Tambah(int angka1, int angka2)
        {
            int hasil = angka1 + angka2;
            return hasil;
        }

        // function pengurangan
        static int Kurang(int angka1, int angka2)
        {
            int hasil = angka1 - angka2;
            return hasil;
        }

        // function perkalian
        static int Kali(int angka1, int angka2)
        {
            int hasil = angka1 * angka2;
            return hasil;
        }

        // function pembagian
        static int Bagi(int angka1, int angka2)
        {
            int hasil = angka1 / angka2;
            return hasil;
        }
    }
}