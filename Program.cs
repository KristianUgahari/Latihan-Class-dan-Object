using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengeset properties objek saya dan kamu
            saya.Nim = "18.11.2296";
            saya.Nama = "Kristian Ugahari Dwipa";
            saya.Ipk = 4.00;

            kamu.Nim = "18.11.2436";
            kamu.Nama = "Paijo";
            kamu.Ipk = 4.00;

            //memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
