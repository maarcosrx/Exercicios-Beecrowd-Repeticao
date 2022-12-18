using System;

namespace Beecrowd1071 {
    public class Program {
        public static void Main(string[] args) {
            
            int x, y, menor, maior, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if( x > y ) {
                maior = x;
                menor = y;
            } else {
                maior = y;
                menor = x;
            }

            soma = 0;
            for(int i = menor + 1; i < maior; i++) {
                if(i % 2 != 0) {
                    soma = soma + i;
                    
                }
                
            }
            Console.WriteLine(soma);
        }


       
    }
}