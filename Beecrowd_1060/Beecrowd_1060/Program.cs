namespace Beecrowd1060 {
    public class Program {
        public static void Main(string[] args) {

            int x = 0;
            double[] vetor = new double[6];
            
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = double.Parse(Console.ReadLine());
                if (vetor[i] > 0) {
                    x++;

                }
            }

            Console.WriteLine($"{x} valores positivos");

        }
    }
}