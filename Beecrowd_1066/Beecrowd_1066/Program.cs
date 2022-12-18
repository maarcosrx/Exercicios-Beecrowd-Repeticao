namespace Beecrowd1066 {
    public class Program {
        public static void Main(string[] args) {
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;
            int[] vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] % 2 == 0) {
                    par++;
                }if (vetor[i] % 2 != 0) {
                    impar++;
                }if (vetor[i] > 0) {
                    positivo++;
                }if (vetor[i] < 0) {
                    negativo++;
                }
            }              
            
            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");
            
        }
    }
}