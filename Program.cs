using Design_Pattern__Factory_Method.Src;
using System;

namespace Design_Pattern__Factory_Method
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("1-Liu Kang | 2-SubZero | 3-Scorpion");
         Console.WriteLine();
         Console.Write("Escolha seu Personagem:	");

         byte escolha = Convert.ToByte(Console.ReadLine());

         FactoryMethod classeFabrica = new FactoryMethod();

         IPersonagem personagem = classeFabrica.EscolherPersonagem(escolha);

         Console.WriteLine();
         Console.Write("Você vai jogar com ");

         personagem.Escolhido();

         Console.ReadKey();
      }
   }
}
