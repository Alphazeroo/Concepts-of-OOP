using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste liste = new Liste();
            Console.WriteLine("1.Clio\n2.Cayman\n3.Polo");
            Console.Write("Lütfen Bir Değer Giriniz: ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            if (sayi == 1)
            {
                liste.Araba = new Clio();
                liste.Getir();
            }
            else if (sayi == 2)
            {
                liste.Araba = new Cayman();
                liste.Getir();
            }
            else if (sayi == 3)
            {
                liste.Araba = new Polo();
                liste.Getir();
            }
            

            
        }
    }

    public class Liste
    {
        public Araba Araba { get; set; }

        public double FiyatHesapla()
        {
            return Araba.KDV();
        }

        public void Getir()
        {
            Console.WriteLine("Özellikler");
            
            if(Araba is Clio)
            {
                Console.WriteLine(Araba.Marka);
                Console.WriteLine(Araba.Weight);
                Console.WriteLine(Araba.BeygirGücü);
                Console.WriteLine(Araba.Fiyat + "Dolar");
            }
            else if(Araba is Cayman)
            {
                Console.WriteLine(Araba.Marka);
                Console.WriteLine(Araba.Weight);
                Console.WriteLine(Araba.BeygirGücü);
                Console.WriteLine(Araba.Fiyat + "Dolar");
            }
            else if(Araba is Polo)
            {
                Console.WriteLine(Araba.Marka);
                Console.WriteLine(Araba.Weight);
                Console.WriteLine(Araba.BeygirGücü);
                Console.WriteLine(Araba.Fiyat + "Dolar");
            }
            if (Araba is SporModu)
            {
                SporModu sporModu = (SporModu)Araba;
                sporModu.SP();
            }
            if (Araba is KoltukIsıtma)
            {
                KoltukIsıtma koltukIsıtma = (KoltukIsıtma)Araba;
                koltukIsıtma.KI();
            }
        }
    }

    public abstract class Araba
    {
        public Markalar Marka { get; set; }
        public Weight Weight { get; set; }
        public BeygirGücü BeygirGücü { get; set; }
        public double Fiyat { get; set; }
        public virtual double KDV()
        {
            return Fiyat * 1.08;
        }
    }

    public class Clio : Araba, KoltukIsıtma
    {
        
        public Clio()
        {
            
            this.Marka = Markalar.Clio;
            this.Weight = Weight.ikiton;
            this.BeygirGücü = BeygirGücü.b55;
            this.Fiyat = 5641;
            
        }
        
        public void KI()
        {
            Console.WriteLine("Koltuk Isıtma var");
        }
        public override double KDV()
        {
            return base.KDV();
        }

    }

    public class Cayman : Araba, SporModu
    {
        public Cayman()
        {

            this.Marka = Markalar.Cayman;
            this.Weight = Weight.üçton;
            this.BeygirGücü = BeygirGücü.b300;
            this.Fiyat = 65465465143;

        }
        public void SP()
        {
            Console.WriteLine("Spor Modu var");
        }
        public override double KDV()
        {
            return this.Fiyat * 1.99;
        }
    }
    public class Polo : Araba, KoltukIsıtma
    {
        public Polo()
        {

            this.Marka = Markalar.Polo;
            this.Weight = Weight.ikibuçukton;
            this.BeygirGücü = BeygirGücü.b80;
            this.Fiyat = 4654541;

        }
        public void KI()
        {
            Console.WriteLine("Koltuk Isıtma var");
        }
        public override double KDV()
        {
            return base.KDV();
        }
    }

    public interface SporModu
    {
        void SP();   
    }
    
    public interface KoltukIsıtma
    {
        void KI();
    }
}
