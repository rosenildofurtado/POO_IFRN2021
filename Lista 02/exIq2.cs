using System;

class MainClass{
  public static void Main(string[] args){
    Disciplina x = new Disciplina();
    double media;
    Console.WriteLine("Digite as notas de POO");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    int n4 = int.Parse(Console.ReadLine());
    int pf;
    x.setNotas(n1,n2,n3,n4);
    x.setNome("POO");
    media = x.mediaParcial();
    if(media>=60){
      Console.WriteLine($"O aluno passou por média com a nota igual a {media:0.0}");
    }
    else{
      Console.WriteLine($"Não passou por média. Nota = {media}. Digite a nota da prova final");
      pf = int.Parse(Console.ReadLine());
      x.setPf(pf);
      media = x.mediaFinal();
      Console.WriteLine($"Média final = {media:0.0}");
    }
  }
}

class Disciplina{
  private int n1, n2, n3, n4, pf;
  private string nome = "";

  public void setNotas(int nt1, int nt2, int nt3, int nt4){
    if(nt1>=0 && nt1<=100) n1 = nt1;
    if(nt2>=0 && nt2<=100) n2 = nt2;
    if(nt3>=0 && nt3<=100) n3 = nt3;
    if(nt4>=0 && nt4<=100) n4 = nt4;
  }

  public void setPf(int npf){
    if(npf>=0 && npf<=100) pf = npf;
  }

  public void setNome(string n){
    nome = n;
  }

  public string getNome(){
    return nome;
  }

  public int getNota1(){
    return n1;
  }

  public int getNota2(){
    return n2;
  }

  public int getNota3(){
    return n3;
  }

  public int getNota4(){
    return n4;
  }

  public double mediaParcial(){
    return (n1*2+n2*2+n3*3+n4*3)/10;
  }

  public double mediaFinal(){
    return (this.mediaParcial()+pf)/2;
  }
}