using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_ORNEK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DERS GEÇTİ-KALDI BULAN PROGRAM");
            Console.WriteLine("---------------------");
            Console.Write("VİZE NOTUNUZU GİRİNİZ : ");
            double v = Convert.ToInt32(Console.ReadLine());
            Console.Write("FİNAL NOTUNUZU GİRİNİZ : ");
            int f = Convert.ToInt32(Console.ReadLine());
            double o = (v * 0.4) + (f * 0.6);
            if (o>=50 && f>=50) Console.WriteLine("ORTALAMA: {0}",o +"  GEÇTİNİZ");
            else
            {
                Console.Write("BÜTÜNLEME NOTUNUZU GİRİNİZ : ");
                int b = Convert.ToInt32(Console.ReadLine());
                double yo = (v * 0.4) + (b * 0.6);
                if (yo>=50 && b>=50) Console.WriteLine("ORTALAMA: {0}", yo + "  GEÇTİNİZ");
                else Console.WriteLine("ORTALAMA: {0}", yo + "  KALDINIZ");
            }
            Console.ReadLine();
        }
    }
}
