namespace KelompokBuahSemangka;

// `Semangka` adalah class base atau parent (class yang original)
class Semangka
{
    // Deklarasi method virtual digunakan hanya utk parent / base class
    public virtual string BentukSajian()
    {
        return "Buah Semangka";
    }
}

// `Jus` adalah class baru yang "mengrelate" atau mengereferensi dengan class base tadi yaitu `Semangka`
// Artinya `Jus` adalah anak dari class `Semangka`
class Jus : Semangka
{
    // Deklarasi method override digunakan utk child / anak class
    public override string BentukSajian()
    {
        return "Jus Semangka";
    }
}

// `Es` adalah class baru yang "mengrelate" atau mengereferensi dengan class base tadi yaitu `Semangka`
// Artinya `Jus` adalah anak dari class `Semangka`
class Es : Semangka
{
    // Deklarasi method override digunakan utk child / anak class
    public override string BentukSajian()
    {
        return "Es Semangka";
    }
}

class Program
{ 
    static void Main(string[] args)
    {
        while (true)
        {
            // Membuat objek baru dengan nama `semangka1` `semangka2` dan `semangka3` dengan tipe objek `Semangka` 
            // Pada new (membuat objek baru) kita panggil class `Semangka` (base), `Jus`, `Es` (anak)
            Semangka semangka1 = new Semangka();
            Semangka semangka2 = new Jus();
            Semangka semangka3 = new Es();

            Console.WriteLine("Pilih sajian semangka yang anda mau (semangka, jus, es) : ");
            string pilihan = Console.ReadLine();

            if (pilihan == "semangka")
            {
                // Memanggil method menggunakan variabel yg kita deklarasikan. Method" tersebut ada pada
                // class-class yang kita buat tadi
                Console.WriteLine($"Bentuk Sajian semangka1 adalah: {semangka1.BentukSajian()}");
                break;
            }
            else if (pilihan == "jus")
            {
                // Memanggil method menggunakan variabel yg kita deklarasikan. Method" tersebut ada pada
                // class-class yang kita buat tadi
                Console.WriteLine($"Bentuk Sajian semangka2 adalah: {semangka2.BentukSajian()}");
                break;
            }
            else if (pilihan == "es")
            {
                // Memanggil method menggunakan variabel yg kita deklarasikan. Method" tersebut ada pada
                // class-class yang kita buat tadi
                Console.WriteLine($"Bentuk Sajian semangka3 adalah: {semangka3.BentukSajian()}");
                break;
            }
            else
            {
                Console.WriteLine("Anda tidak mau semangka");
            }
        }
    }
}