namespace Beecrowd1095 {
    public class Program {
        public static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double total = 0.0, x = 0.0, coelho = 0.0, rato = 0.0, sapo = 0.0, cont = 0.0, num = 0.0;
            
            for(cont = 1; cont <= N; cont++) {
                string[] entrada = Console.ReadLine().Split();
                num = int.Parse(entrada[0]);
                string animal = (entrada[1]);               
                total += num;

                if (animal == "C") {
                    coelho += num;
                } else if (animal == "R") {
                    rato += num;
                } else if (animal == "S") {
                    sapo += num;
                }

            }

            double percentCoelho, percentRato, percentSapo;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");            
            percentCoelho = ((100 * coelho) / total);
            percentRato = ((100 * rato) / total);
            percentSapo = ((100 * sapo) / total);
            Console.WriteLine($"Percentual de coelhos: {percentCoelho:F2} %");
            Console.WriteLine($"Percentual de ratos: {percentRato:F2} %");
            Console.WriteLine($"Percentual de sapos: {percentSapo:F2} %");


        }
    }
}