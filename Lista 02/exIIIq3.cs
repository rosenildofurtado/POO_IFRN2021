using System;

class MainClass{
  public static void Main(){
    Conversor x = new Conversor(12);

    Console.WriteLine(x.Binario());
    Console.WriteLine(x.ToString());

  }
}

class Conversor{
  private int num;

  public Conversor(int num){
    this.num = num;
  }

  public void SetNum(int num){
    this.num = num;
  }

  public int GetNum(){
    return num;
  }

  public string Binario(){
    String binario = Convert.ToString(num, 2);
    return binario;
  }

  public override string ToString(){
    return $"Decimal = {num} e Binário = {Convert.ToString(num, 2)}";
  }
}