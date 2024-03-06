// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.



// IMPORTANTE:

// Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;


  using System;

  class Program1
  {
      static void Main()
      {
           Console.Write("Informe um número para verificar na sequência de Fibonacci: ");
          int numeroInformado = Convert.ToInt32(Console.ReadLine());

          bool pertence = VerificarSePertenceASequencia(numeroInformado);

          if (pertence)
          {
              Console.WriteLine($"{numeroInformado} pertence à sequência de Fibonacci.");
          }
          else
          {
              Console.WriteLine($"{numeroInformado} não pertence à sequência de Fibonacci.");
          }
      }

      static bool VerificarSePertenceASequencia(int numero)
      {
          if (numero == 0)
          {
              return true;
          }

          int a = 0;
          int b = 1;

          while (b <= numero)
          {
              if (b == numero)
              {
                  return true;
              }

              int temp = a + b;
              a = b;
              b = temp;
          }

          return false;
      }
  }
