namespace Beecrowd1116 {
    public class Program {
        public static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            
            for (int cont = 0; cont < N; cont++) {
                string[] entrada = Console.ReadLine().Split(' ');
                double entrada1 = double.Parse(entrada[0]);
                double entrada2 = double.Parse(entrada[1]);

                if (entrada2 != 0) {
                    double divisão = entrada1 / entrada2;                    
                    Console.WriteLine($"{divisão:f1}");
                } else {
                    Console.WriteLine("divisao impossivel");
                }
            }

        }
    }
}