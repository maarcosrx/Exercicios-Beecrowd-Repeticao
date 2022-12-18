namespace Beecrowd1118 {
    public class Program {
        public static void Main(string[] args) {

            //double opcao = 1;
            //int x = 0;
            //double temp = 0;
            //double media = 0;

            //while (opcao != 2 && opcao > 0) {
            //    x = 0;
            //    temp = 0;
            //    media = 0;
            //    while (x < 2) {
            //        double notas = double.Parse(Console.ReadLine());
            //        if (notas < 0 || notas > 10) {
            //            Console.WriteLine("nota invalida");
            //        } else {
            //            temp += notas;
            //            x++;
            //        }
            //    }

            //    media = (temp) / 2;
            //    Console.WriteLine($"media = {media:F2}");
            //    Console.WriteLine("novo calculo (1-sim 2-nao)");
            //    opcao = int.Parse(Console.ReadLine());                
            //    if (opcao == 2) {
            //        break;
            //    } while (opcao != 1) {
            //        Console.WriteLine("novo calculo (1-sim 2-nao)");
            //        opcao = double.Parse(Console.ReadLine());
            //    }
            int continua = 0;
            double n1 = 0;
            double n2 = 0;
            double media = 0;
            do {

                double nota1 = double.Parse(Console.ReadLine());

                if (nota1 >= 0 && nota1 <= 10) {
                    n1 = nota1;
                } else { Console.WriteLine("nota invalida"); }

                double nota2 = double.Parse(Console.ReadLine());
                if (nota2 >= 0 && nota2 <= 10) {
                    n2 = nota2;
                } else { Console.WriteLine("nota invalida"); }

                media = (n1 + n2) / 2;

                Console.WriteLine($"media = {media}");

                Console.WriteLine("Novo calculo (1-sim 2-nao)");
                continua = int.Parse(Console.ReadLine());

            } while (continua == 1);
        }
        
    }
}