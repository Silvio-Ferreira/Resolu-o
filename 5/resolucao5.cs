// 5) Escreva um programa que inverta os caracteres de um string.


// IMPORTANTE:

// a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

// b) Evite usar funções prontas, como, por exemplo, reverse;

 using System;

 class Program5
 {
     static void Main()
     {
         Console.Write("Informe uma string para inverter: ");
         string original = Console.ReadLine();

         string resultado = InverterString(original);

         Console.WriteLine($"String original: {original}");
         Console.WriteLine($"String invertida: {resultado}");
     }

     static string InverterString(string input)
     {
         char[] caracteres = input.ToCharArray();
         int inicio = 0;
         int fim = input.Length - 1;

         while (inicio < fim)
         {
             char temp = caracteres[inicio];
             caracteres[inicio] = caracteres[fim];
             caracteres[fim] = temp;

             inicio++;
             fim--;
         }

         return new string(caracteres);
     }
 }
