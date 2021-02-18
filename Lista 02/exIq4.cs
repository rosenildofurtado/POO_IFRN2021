using System;

class MainClass{
  public static void Main(string[] args){
    Conta x = new Conta();
    x.setTitular("Nildo");
    x.setNumeroConta("02467");
    Console.WriteLine($"Saldo = {x.getSaldo():0.00}");
    Console.WriteLine($"Depósito de 1000. Saldo = {x.deposito(1000):0.00}");
    Console.WriteLine($"Saque de 500. Saldo = {x.saque(500):0.00}");
    Console.WriteLine($"Saque de 501. Saldo = {x.saque(501):0.00}");
  }
}

class Conta{
  private string titular, nConta;
  private double saldo;

  public void setTitular(string nome){
    titular = nome;
  }

  public void setNumeroConta(string conta){
    nConta = conta;
  }

  public double deposito(double valor){
    if(valor>0){
      saldo += valor;
    }
    return saldo;
  }


  public double getSaldo(){
    return saldo;
  }

  public double saque(double valor){
    if(valor>saldo){
      Console.WriteLine("Saldo insuficiente");
    }
    else saldo -= valor;
    return saldo;
  }
}