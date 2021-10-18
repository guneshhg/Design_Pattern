using System;

namespace Factory
{
    public abstract class Oyun
    {
        public abstract void Platform();
    }
   

    public class Atari : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun Atari platformunda çalışmaktadır.");
        }
    }

    public class PC : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun PC platformunda çalışmaktadır.");
        }
    }

    public class PS : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun PS platformunda çalışmaktadır");
        }
    }

    public enum Oyunlar
    {
        Atari,
        PC,
        PS
    }


    public class Creater
    {
        public Oyun FactoryMethod(Oyunlar OyunTipi)
        {
            Oyun oyun = null;
            switch (OyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
                case Oyunlar.PS:
                    oyun = new PS();
                    break;
            }

            return oyun;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Oyun atariOyunu = creater.FactoryMethod(Oyunlar.Atari);
            Oyun pcOyunu = creater.FactoryMethod(Oyunlar.PC);
            Oyun psOyunu = creater.FactoryMethod(Oyunlar.PS);

            atariOyunu.Platform();
            pcOyunu.Platform();
            psOyunu.Platform();

        }
    }
}
