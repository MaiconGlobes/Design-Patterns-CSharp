namespace Design_Pattern__Factory_Method.Src
{
   internal class FactoryMethod
   {
      public IPersonagem EscolherPersonagem(byte personagem)
      {
         switch (personagem)
         {
            case 1:
               return new LiuKang();
            case 2:
               return new SubZero();
            case 3:
               return new Scorpion();
            default:
               return null;
         }
      }
   }
}
