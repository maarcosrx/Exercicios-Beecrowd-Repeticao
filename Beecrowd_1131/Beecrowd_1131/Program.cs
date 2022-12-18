namespace Beecrowd1131 {
    public class Program {
        public static void Main(string[] args) {

            int grenais = 0;
            int inter = 0;
            int gremio = 0;
            int empates = 0;
            int opcao = 1;
            int x = 0;

            while (opcao == 1) {
                
                string[] entradas = Console.ReadLine().Split();
                int entrada1 = int.Parse(entradas[0]);
                int entrada2 = int.Parse(entradas[1]);
                if(entrada1 > entrada2) {
                    inter++;
                    grenais++;
                }else if(entrada1 < entrada2) {
                    gremio++;
                    grenais++;
                } else {
                    empates++;
                    grenais++;
                }                
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
            }


            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{inter}");
            Console.WriteLine($"Gremio:{gremio}");
            Console.WriteLine($"Empates:{empates}");
            if(inter > gremio){
                Console.WriteLine("Inter venceu mais");
            } else if(gremio > inter){
                Console.WriteLine("Gremio Venceu mais");
            }else {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}