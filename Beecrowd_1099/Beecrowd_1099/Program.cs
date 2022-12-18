namespace Beecrowd1099 {
    public class Program {
        public static void Main(string[] args) {
            
            int soma = 0;
            int N = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < N; cont++) {
                cont = 0;
                string[] xy = Console.ReadLine().Split(' ');
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                if (y < x) {
                    int aux = x;
                    x = y;
                    y = aux;
                } 
                soma = 0;
                
                for (int z = x + 1; z < y; z++) {                    
                    if (z % 2 != 0) {                        
                        soma += z;
                    }
                }
                Console.WriteLine(soma);
            }
        }

    }
}


