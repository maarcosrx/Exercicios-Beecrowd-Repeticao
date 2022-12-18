namespace Beecrowd1115 {
    public class Program {
        public static void Main(string[] args) {

            int x = 0;

            for(int cont = 0; cont < 10; cont++) {
                string[] entrada = Console.ReadLine().Split(' ');
                int valor1 = int.Parse(entrada[0]);
                int valor2 = int.Parse(entrada[1]);
                if(valor1 > 0 && valor2 > 0) {
                    x++;
                    Console.WriteLine("primeiro");                    
                }else if(valor1 < 0 && valor2 > 0) {
                    x++;
                    Console.WriteLine("segundo");
                }else if(valor1 < 0 && valor2 < 0) {
                    x++;
                    Console.WriteLine("terceiro");
                }else if(valor1 > 0 && valor2 < 0) {

                    Console.WriteLine("quarto");
                }
            }


        }
    }
}