namespace Beecrowd1095 {
    public class Program {
        public static void Main(string[] args) {

            int j = 60;
            int i = 1;
            // Jeito difícil:
            for ( j = 60, i = 1; j >= 0; j = j - 5, i = i + 3) {
                Console.WriteLine($"I={i} J={j}");
            }


            //Jeito fácil
             j = 60;
             i = 1;

            while (j >= 0 && i >= 0) {
                Console.WriteLine($"I={i} J={j}");
                j -= 5;
                i += 3;
            }

        }
    }
}