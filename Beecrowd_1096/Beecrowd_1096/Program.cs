namespace Beecrowd1096 {
    public class Program {
        public static void Main(string[] args) {

            int[] vetor1 = { 7, 6, 5, 9, 8, 7, 11, 10, 9, 13, 12, 11, 15, 14, 13 };
            int[] vetor2 = new int[15];
            int j = 0;

            for (int i = 1; i < 10; i = i + 2) {
                
                vetor2[i] = i;

                Console.WriteLine($"I={vetor2[i]} J={vetor1[j]}");
                j++;
                Console.WriteLine($"I={vetor2[i]} J={vetor1[j]}");
                j++;
                Console.WriteLine($"I={vetor2[i]} J={vetor1[j]}");
                j++;
            }



            
        }
    }
}