using System;
namespace Kalıtım
{
    public class Bitkiler:Canlilar
    {
        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }

    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Boşaltım();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalan()
        {
            Console.WriteLine("Tohumlu Bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
        }
        public void TohumsuzCogalan()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
       
}

