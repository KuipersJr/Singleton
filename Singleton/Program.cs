using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton gamer_1 = Singleton.GetInstancia;
            gamer_1.Mensagem("Bola");

            Singleton gamer_2 = Singleton.GetInstancia;
            gamer_2.Mensagem("Bola 2");

            Singleton gamer_3 = Singleton.GetInstancia;
            gamer_3.Mensagem("bola 3");

            Console.ReadKey();
        }
    }
}
