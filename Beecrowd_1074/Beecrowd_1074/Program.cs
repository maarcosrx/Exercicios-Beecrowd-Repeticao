namespace Beecrowd1074 {
    public class Program { 
        public static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int x = 0;
            int entrada = 0;

            for(int cont = 0; cont < N; cont++) {                
                x = int.Parse(Console.ReadLine());
                if(x == 0) {
                    x++;
                    Console.WriteLine("NULL");                    
                }else if(x % 2 != 0 && x < 0) {
                    x++;
                    Console.WriteLine("ODD NEGATIVE");
                }else if(x % 2 != 0 && x > 0) {
                    x++;
                    Console.WriteLine("ODD POSITIVE");
                }else if(x % 2 == 0 && x < 0) {
                    x++;
                    Console.WriteLine("EVEN NEGATIVE");
                } else {
                    x++;
                    Console.WriteLine("EVE POSITIVE");
                }
            }

        }

    }
}