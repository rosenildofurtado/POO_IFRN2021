using System;

class MainClass{
  public static void Main(string[] args){
    Viagem x = new Viagem();
    Console.WriteLine("Digite a distância pecorrida em kilômetros");
    x.setKm(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o tempo da viagem no formato hh:mm");
    string tempo = Console.ReadLine();
    string[] tempos = tempo.Split(":");
    x.setHoras(int.Parse(tempos[0]));
    x.setMinutos(int.Parse(tempos[1]));
    Console.WriteLine($"Velocidade = {x.velocidade():0.00}");
  }
}

class Viagem{
  private int d, h, m;

  public void setKm(int km){
    if(km>=0) d = km;
  }

  public void setHoras(int hora){
    if(hora>=0) h = hora;
  }

  public void setMinutos(int minuto){
    if(minuto>=0) m = minuto;
  }

  public double velocidade(){
    double tempo = h + m/60.0;
    if(tempo>0) return d/tempo;
    else return d/0.001;
  }
}