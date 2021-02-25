using System;

class MainClass{
  public static void Main(){
    Retangulo x = new Retangulo(2, 3);
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(x.CalcDiagonal());
    Console.WriteLine(x.ToString());
  }
}

class Retangulo{
  private double b, h;

  public Retangulo(double bas, double altura){
    if(bas>0) b = bas;
    if(altura>0) h = altura;
  }

  public void SetBase(double bas){
    if(bas>0) b = bas;
  }

  public double GetBase(){
    return b;
  }

  public void SetAltura(double altura){
    if(altura>0) h = altura;
  }

  public double GetAltura(){
    return h;
  }

  public double CalcArea(){
    return b*h;
  }

  public double CalcDiagonal(){
    double diagonal;
    diagonal = Math.Sqrt(b*b + h*h);
    return diagonal;
  }

  public override string ToString(){
    return $"Base = {b} e Altura = {h}";
  }

}