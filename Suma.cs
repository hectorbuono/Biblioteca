using System;
using System.Collections.Generic;
using System.Text;
 
namespace Proyecto1
{
 class Program
 {
    static void Main(string[] args)
 {
    int suma=0; int contar = 0;
    
    while (contar < 10)
 {
    contar=contar+1;
    suma = suma + contar;
    
 }
    Console.WriteLine(suma);     
 } //fin Main
 } 
} 