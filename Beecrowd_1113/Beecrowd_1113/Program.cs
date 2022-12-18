namespace Beecrowd1113 {
    public class Program {
        public static void Main(string[] args) {

            int x= 0;
            int y= 0;

            do {

                string[] entradas = Console.ReadLine().Split();
                 x = int.Parse(entradas[0]);
                 y = int.Parse(entradas[1]);

                if (x > y) {
                    Console.WriteLine("Decrescente");
                } else if (x < y) {
                    Console.WriteLine("Crescente");
                }
            } while (y != x);

        }
    }
}