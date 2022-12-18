namespace Beecrowd1065 {
    public class Program {
        public static void Main(string[] args) {
            int x = 0; 
            int[] vetor = new int[5];

            for(int i = 0; i < vetor.Length; i++) {
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] % 2 == 0) {
                    x++;
                    
                }
            }
            Console.WriteLine($"{x} valores pares");

        }
    }
}