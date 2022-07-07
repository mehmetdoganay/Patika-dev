using System;
namespace Kalıtım
{
    public class Canlilar
    {
        
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum yapar.");
        }

        protected void Boşaltım()
        {
            Console.WriteLine("Canlılar Boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
    }
}

