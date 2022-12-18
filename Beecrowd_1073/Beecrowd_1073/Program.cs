namespace Beecrowd1073 {
    public class Program {
        public static void Main(string[] args) {

            int x = 0;
            int N = int.Parse(Console.ReadLine());            

            for(int cont = 0; cont < N; cont++) {                
                if (cont % 2 == 0) {
                    x += 2;
                    double potencia = Math.Pow(x, 2);
                    Console.WriteLine($"{x}^2 = {potencia}");
                }                
            }
            


        }
    }
}