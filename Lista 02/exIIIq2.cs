using System;

class MainClass{
  public static void Main(){
    Frete x = new Frete(123, 20);

    Console.WriteLine(x.CalcFrete());
    Console.WriteLine(x.ToString());

  }
}

class Frete{
  private double d, p;

  public Frete(double distancia, double peso){
    if(distancia>0) d = distancia;
    if(peso>0) p = peso;
  }

  public void SetDistancia(double distancia){
    if(distancia>0) d = distancia;
  }

  public double GetDistancia(){
    return d;
  }

  public void SetPeso(double peso){
    if(peso>0) p = peso;
  }

  public double GetPeso(){
    return p;
  }

  public double CalcFrete(){
    return 0.01*p*d;
  }

  public override string ToString(){
    return $"Peso = {p} e Distância = {d}";
  }
}