namespace Beecrowd1098 {
    public class Program {
        public static void Main(string[] args) {
            
            for(double i = 0; i <=2; i = i + 0.2) {
                if(i == 0 || i == 1 || i == 2) {
                    for(double j = 1 + i; j <= 3 + i; j++) {
                        Console.WriteLine($"I={i} J={j}");
                    }
                } else if (i != 0 || i != 1 || i != 2) {
                    for (double j = 1 + i; j <= 3 + i; j++) {
                        Console.WriteLine($"I={Math.Round(i,1)} J={Math.Round(j,1)}");
                    }
                }
            }






        }
    }
}