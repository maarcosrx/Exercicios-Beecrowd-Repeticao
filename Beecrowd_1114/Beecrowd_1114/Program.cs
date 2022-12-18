namespace Beecrowd1114 {
    public class Program {
        public static void Main(string[] args) {

            int senha = 0;

            while (senha != 2002) {
                senha = int.Parse(Console.ReadLine());
                if (senha != 2002) {
                    Console.WriteLine("Senha Invalida");
                } else {
                    Console.WriteLine("Acesso permitido");
                }

            }
        }
    }
}