using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilation_1_Chapter_4_51
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Длина конверта(мм): ");
                    double envelopeLength = double.Parse(Console.ReadLine());

                    Console.Write("Ширина конверта(мм): ");
                    double envelopeWidth = double.Parse(Console.ReadLine());

                    Console.Write("\nДлина открытки(мм): ");
                    double postcardLength = double.Parse(Console.ReadLine());

                    Console.Write("Ширина открытки(мм): ");
                    double postcardWidth = double.Parse(Console.ReadLine());

                    Envelope envelope = new Envelope(envelopeLength, envelopeWidth);
                    Postcard postcard = new Postcard(postcardLength, postcardWidth);

                    Console.Clear();
                    Console.WriteLine(CapacityCheck(envelope, postcard)); ;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }

        static string CapacityCheck(Envelope envelope, Postcard postcard)
        {
            if (envelope.Lenght - postcard.Lenght >= 1 && envelope.Width - postcard.Width >= 1)
            {
                return "Открытка входит в конверт\n";
            }
            else
            {
                return "Открытка не входит в конверт\n";
            }
        }
    }
}