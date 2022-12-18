namespace Beecrowd1072 {
    public class Program {
        public static void Main(string[] args) {

            int x = 0;
            int y = 0;
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];

            for (int cont = 0; cont < vetor.Length; cont++) {
                vetor[cont] = int.Parse(Console.ReadLine());
                if (vetor[cont] >= 10 && vetor[cont] <= 20) {
                    x++;
                } else {
                    y++;
                }
            }
            Console.WriteLine($"{x} in");
            Console.WriteLine($"{y} out");
        }
    }
}