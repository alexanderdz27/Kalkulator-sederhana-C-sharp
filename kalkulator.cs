using System;

namespace kalkulator{
    class kalkulator
    {
        
        static void Main(String[] args)
        {
            Console.WriteLine("Kalkulator sederhana 2 bilangan");
            Console.WriteLine(" ");
            Console.WriteLine("1.Penjumlahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine(" ");
            Console.WriteLine("SIlahkan Pilih (1/2/3/4)");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukkan angka pertama:");
            Double angka1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("masukkan angka kedua:");
            Double angka2 = Convert.ToDouble(Console.ReadLine());
            double hasil = 0;
            switch (pilih){
                case 1:{
                    hasil = tambah(angka1, angka2);
                    break;
                }
                case 2:{
                    hasil = kurang(angka1, angka2);
                    break;
                }
                case 3:{
                    hasil = kali(angka1, angka2);
                    break;
                }
                case 4:{
                    hasil = bagi(angka1, angka2);
                    break;
                }
                default:
                    Console.WriteLine("pilihan tidak ada, silahkan coba lagi !!!");
                    break;
            }




            if (pilih == 1){
                Console.WriteLine("hasil dari penjumlahan "+angka1+" dan "+angka2+" adalah "+hasil);
            }

            else if (pilih == 2){
                Console.WriteLine("hasil dari pengurangan "+angka1+" dan "+angka2+" adalah "+hasil);
            }

            else if (pilih == 3){
                Console.WriteLine("hasil dari pembagian "+angka1+" dan "+angka2+" adalah "+hasil);
            }
            else if (pilih == 4){
                Console.WriteLine("hasil dari perkalian "+angka1+" dan "+angka2+" adalah "+hasil);
            }
            else
            {
                Console.WriteLine("inputan salah, silahkan coba lagi !!!");
            }
        }



        public static double tambah(double angka1, double angka2){
            double hasil = angka1 + angka2;
            return hasil;
        }
        public static double kurang(double angka1, double angka2){
            double hasil = angka1 - angka2;
            return hasil;
        }
        public static double kali(double angka1, double angka2){
            double hasil = angka1 * angka2;
            return hasil;
        }
        public static double bagi(double angka1, double angka2){
            double hasil = angka1 / angka2;
            return hasil;
        }
    }

}
