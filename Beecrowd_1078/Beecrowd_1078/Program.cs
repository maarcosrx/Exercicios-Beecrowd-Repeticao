namespace Beecrowd1078 {
    public class Program {
        public static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int x = 0;

            for (int cont = 0; cont < 10; cont++) {
                x++;
                int multi = x * N;
                Console.WriteLine($"{x} x {N} = {multi}");
            }
        }
    }
}