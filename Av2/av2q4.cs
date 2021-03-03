using System;

class MainClass{
  public static void Main(){
    Pessoa x = new Pessoa();
    Pessoa y = new Pessoa(34, "adc", DateTime.Now);
    x.SetId(24);
    Console.WriteLine(x.GetId());
    Console.WriteLine(y.GetDtNasc());

  }
}

class Pessoa{
  private int id;
  private string nome;
  private DateTime dtNasc;

  public Pessoa(){

  }

  public Pessoa(int id, string nome, DateTime dtNasc){
    this.id = id;
    this.nome = nome;
    this.dtNasc = dtNasc;
  }

  public void SetId(int id){
    this.id = id;
  }

  public int GetId(){
    return id;
  }
  
  public void SetNome(string nome){
    this.nome = nome;
  }

  public string GetNomec(){
    return nome;
  }

  public void SetDtNasc(DateTime dtNasc){
    this.dtNasc = dtNasc;
  }

  public DateTime GetDtNasc(){
    return dtNasc;
  }

  public string Falar(){
    return "Boa Prova!!";
  }
}