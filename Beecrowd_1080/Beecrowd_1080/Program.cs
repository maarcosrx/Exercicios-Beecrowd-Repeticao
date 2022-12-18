namespace Beecrowd1080 {
    public class Program {
        public static void Main(string[] args) {

            int x = 0;
            int y = 0;
            int z = 0;

            for (int cont = 1; cont < 101; cont++) {
                x = int.Parse(Console.ReadLine());

                if (x > y) {
                    y = x;
                    z = cont;

                }
            }
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}