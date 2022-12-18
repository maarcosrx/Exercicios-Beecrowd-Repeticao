namespace Beecrowd1079 {
    public class Program {
        public static void Main(string[] args) {
            //int N = int.Parse(Console.ReadLine());
            //double nota1;
            //double nota2;
            //double nota3;
            //double med;


            //for (int cont = 0; cont < N; cont++) {
            //    string[] notas = Console.ReadLine().Split(' ');
            //    nota1 = double.Parse(notas[0]);
            //    nota2 = double.Parse(notas[1]);
            //    nota3 = double.Parse(notas[2]);

            //    med = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;
            //    Console.WriteLine($"{med:F1}");
            //}

            double nota1 = 0, nota2 = 0, nota3 = 0;
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; ++i) {
                string[] values = Console.ReadLine().Split();
                nota1 = double.Parse(values[0]);
                nota2 = double.Parse(values[1]);
                nota3 = double.Parse(values[2]);
                
                double med = ((nota1*2) + (nota2*3) + (nota3*5)) / 10;
                Console.WriteLine($"{med:F1}");

//                3
//6,5 4,3 6,2
//12,4
//5,1 4,2 8,1
//16,2
//8,0 9,0 10,0
//20

            }
            
        }
    }
}