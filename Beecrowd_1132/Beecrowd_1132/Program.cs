namespace Beecrowd1132 {
    public class Program {
        public static void Main(string[] args) {
           
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = 0;
            int aux = 0;

            if(y < x) {
                aux = x;
                x = y;
                y = aux;
            }

            for (int cont = x; cont <= y; cont++) {
                if (cont % 13 != 0 ) {
                    soma += cont;                                      
                }                
            }
            Console.WriteLine(soma);
        }
    }
}