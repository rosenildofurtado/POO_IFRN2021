using System;

class MainClass{
  public static void Main(string[] args){
    Circulo x = new Circulo();
    x.setRaio(2);
    Console.WriteLine(x.areaCirculo());
    Console.WriteLine(x.areaCircunferencia());
  }
}

class Circulo{
  private double raio;

  public void setRaio(double r){
    if(r>0) raio = r;
  }

  public double getRaio(){
    return raio;
  }

  public double areaCirculo(){
    return Math.PI*raio*raio;
  }

  public double areaCircunferencia(){
    return 2*Math.PI*raio;
  }

}

