namespace Beecrowd1075 {
    public class Program {
        public static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());           

            for(int cont = 1; cont < 10000; cont++) {                
                if (cont % n == 1) {                    
                    cont++;
                    Console.WriteLine(cont);
                }
            }
            
        }
    }
}