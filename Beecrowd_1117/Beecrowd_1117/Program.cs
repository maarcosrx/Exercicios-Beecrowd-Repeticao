namespace Beecrowd1117 {
    public class Program {
        public static void Main(string[] args) {
            int x = 0;
            double mediaTemp = 0;
            string entrada;


            for (int i = 0; x < 2; i++) {
                double nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 10) {
                    mediaTemp = mediaTemp + nota;
                    x++;
                } else {
                    Console.WriteLine("nota invalida");
                }
            }
            double media = mediaTemp / 2;
            Console.WriteLine($"media = {media:F2}");

        }
    }
}
