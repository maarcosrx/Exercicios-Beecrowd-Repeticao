﻿using System;

namespace Beecrowd1070 {
    public class Program {
        public static void Main(string[] args) {

            int x;
            x = int.Parse(Console.ReadLine());
            
            
            if (x % 2 == 0) {
                x++;
                for (int i = 0; i < 6; i++) {
                    Console.WriteLine(x);
                    x += 2;
                }
            }else if(x % 2 != 0) {
                for(int i = 0; i < 6; i++) {
                    Console.WriteLine(x);
                    x += 2;
                }
            }
                        
        }
    }
}