using System;

class MainClass{
  public static void Main(string[] args){
    Disciplina x = new Disciplina();
    x.setNotas(6, 5 ,8 ,9);
    Console.WriteLine(x.getNome());
    Console.WriteLine(x.getNota1());
  }
}

class Disciplina{
  private int n1, n2, n3, n4, pf;
  string nome;

  public void setNotas(int nt1, int nt2, int nt3, int nt4){
    if(nt1>=0 && nt1<=100) n1 = nt1;
    if(nt2>=0 && nt2<=100) n2 = nt2;
    if(nt3>=0 && nt3<=100) n3 = nt3;
    if(nt4>=0 && nt4<=100) n4 = nt4;
  }

  public void setNome(string n){
    nome = n;
  }

  public double getNota1(){
    return n1;
  }

  public double getNota2(){
    return n2;
  }

  public string getNome(){
    return nome;
  }

  

}