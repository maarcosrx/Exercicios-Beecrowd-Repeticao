namespace Beecrowd {
    public class Program {
        public static void Main(string[] args) {
            
            bool continuar = true;
            do {
                int aux = 0;
                int soma = 0;
                string[] nm = Console.ReadLine().Split();
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
              
                if (n <= 0 || m <= 0) {
                    break;
                }
                if (n > m) {
                    for (int i = m; i <= n; i++) {
                        soma += i;
                        Console.Write($"{i} ");
                    }
                } else if (n < m) {
                    for (int i = n; i <= m; i++) {
                        soma += i;
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine($"Sum={soma}");

            } while (continuar);
            


        }
    }
}