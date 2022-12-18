using System.Globalization;

namespace Beecrowd1064 {
    public class Program {
        public static void Main(string[] args) {

            double somaTotal = 0;
            int temp = 0;

            for (int i = 0; i < 6; i++) {
                double x = double.Parse(Console.ReadLine());
                if (x > 0) {
                    temp++;
                    somaTotal += x;
                }
            }

            double media = somaTotal / temp;
            Console.WriteLine($"{temp} valores positivos");
            Console.WriteLine($"{media:F1}");
                        
        }
    }
}