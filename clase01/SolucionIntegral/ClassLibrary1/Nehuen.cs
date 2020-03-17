using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Nehuen : IProgramador
    {
        public void Come()
        {
            Console.WriteLine("se come a rodry");
        }

        public void Programa()
        {
            throw new NotImplementedException();
        }
    }
}
