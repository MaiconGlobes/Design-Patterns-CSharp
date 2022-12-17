namespace Builder.Src
{
  internal class Exercito
  {
    public void ConstruirSoldado(CriadorDeSoldado criadorDeSoldado)
    {
      criadorDeSoldado.Arma();
      criadorDeSoldado.Transporte();
      criadorDeSoldado.Foco();
    }
  }
}
