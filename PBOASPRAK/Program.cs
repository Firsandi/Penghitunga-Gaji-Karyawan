using System;


class Karyawan
{
    private string Nama;
    private string ID;
    private double Gajipokok;

    public string dapatNama()
    {
        return Nama;
    }

    public void ambilNama(string nama)
    {
        Nama = nama;
    }

    public string dapatID()
    {
        return ID;
    }

    public void ambilID(string Id)
    {
        ID = Id;
    }

    public double dapatGaji()
    {
        return Gajipokok;
    }

    public void ambilGaji(double Gaji)
    {
        Gajipokok = Gaji;
    }

    public Karyawan(string Nama, string ID, double Gajipokok)
    {
        this.Nama = Nama;
        this.ID = ID;
        this.Gajipokok = Gajipokok;
    }

    public virtual double hitungGaji()
    {
        return Gajipokok;
    }
}

class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string Nama, string ID, double Gajipokok) : base(Nama, ID, Gajipokok)
    {
    }

    public override double hitungGaji()
    {
        return base.hitungGaji() + 500000;

    }
}

class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string Nama, string ID, double Gajipokok) : base(Nama, ID, Gajipokok)
    {
    }
    public override double hitungGaji()
    {
        return base.hitungGaji() - 200000;
    }
}

class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string Nama, string ID, double Gajipokok) : base(Nama, ID, Gajipokok)
    {
    }
    public override double hitungGaji()
    {
        return base.hitungGaji();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Selamat Datang Di Sistem HitungGaji");
        Console.WriteLine("Masukkan Status Karyawan anda :");
        Console.WriteLine("1. Karyawan Tetap");
        Console.WriteLine("2. Karyawan Kontrak");
        Console.WriteLine("3. Karyawan Magang");
        Console.WriteLine("4. Keluar");
        Console.Write("Masukkan Pilihan Anda : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());
      
        switch (pilihan)
        {
            case 1:
                {
                    Console.Write("Masukkan Nama Anda : ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan Nomor ID Anda : ");
                    string Id = Console.ReadLine();
                    Console.Write("Masukkan Gaji Pokok Anda : ");
                    double Gaji = Convert.ToDouble(Console.ReadLine());
                    KaryawanTetap Kartap = new KaryawanTetap(nama, Id, Gaji);
                    //Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine($"Nama anda adalah : {nama}\n" +
                        $"Nomor ID anda adalah : {Id}\n" +
                        $"Total Gaji Anda adalah : " + Kartap.hitungGaji());
                    break;
                }
            case 2:
                {
                    Console.Write("Masukkan Nama Anda : ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan Nomor ID Anda : ");
                    string Id = Console.ReadLine();
                    Console.Write("Masukkan Gaji Pokok Anda : ");
                    double Gaji = Convert.ToDouble(Console.ReadLine());
                    KaryawanKontrak Kartak = new KaryawanKontrak(nama, Id, Gaji);
                    Console.WriteLine("");
                    Console.WriteLine($"Nama anda adalah : {nama}\n" +
                        $"Nomor ID anda adalah : {Id}\n" +
                        $"Total Gaji Anda adalah : " + Kartak.hitungGaji());
                    break;
                }
                
            case 3:
                {
                    Console.Write("Masukkan Nama Anda : ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan Nomor ID Anda : ");
                    string Id = Console.ReadLine();
                    Console.Write("Masukkan Gaji Pokok Anda : ");
                    double Gaji = Convert.ToDouble(Console.ReadLine());
                    KaryawanMagang Kargang = new KaryawanMagang(nama, Id, Gaji);
                    Console.WriteLine("");
                    Console.WriteLine($"Nama anda adalah : {nama}\n" +
                        $"Nomor ID anda adalah : {Id}\n" +
                        $"Total Gaji Anda adalah : " + Kargang.hitungGaji());
                    break;
                }
            case 4:
                Console.Clear();
                Console.WriteLine("Terima Kasih sudah menggunakan sistem ini :)");
                break;
        }
    }
}