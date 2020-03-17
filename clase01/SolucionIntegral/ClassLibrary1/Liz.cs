using System;

namespace ClassLibrary1
{
    public class Liz : IProgramador
    {
        public void Come()
        {
            Console.WriteLine("se come facturas");
        }

        public void Programa()
        {
            throw new NotImplementedException();
        }

    }
}
