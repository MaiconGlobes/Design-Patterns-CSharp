using Design_Pattern__Factory_Method.Src.Interfaces;
using System;

namespace Design_Pattern__Factory_Method.Src.Classes
{
   internal class Scorpion : IPersonagem
   {
      public void Escolhido()
      {
         Console.Write("Scorpion");
      }
   }
}
