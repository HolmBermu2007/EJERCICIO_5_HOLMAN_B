using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_5_HOLMAN_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album alb = new Album(1, "variado", 12345, new List<Foto>());



            alb.AniadirFoto(new Foto(1, 10, 2020, "pandemia"));
            alb.AniadirFoto(new Foto(2, 20, 2022, "animales"));
            alb.AniadirFoto(new Foto(3, 10, 2023, "relieve"));

            alb.Mostar();
            alb.TamanoAlbum();
            Console.ReadKey();
        }
    }
}
