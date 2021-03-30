using System;
using System.Collections;

class MainClass{
  public static void Main(){
    ArrayList cesta = new ArrayList();
    Fruta f1 = new Fruta("banana");
    Doce d1 = new Doce("chocolate");
    cesta.Add(f1);
    cesta.Add(d1);
    foreach (IItem item in cesta)
      Console.WriteLine(item.Nome);

    for(int i=0; i<cesta.Count; i++) 
       Console.WriteLine(((IItem)cesta[i]).Nome);  }
}



class Aplicativo{
  private int curtidas;

  public string Nome{get; set;}
  public string Categoria{get; set;}
  public double Preco{get; set;}
  public string Curtidas{get;}
}

class Fruta: IItem{
  public string Nome{get; set;}
  public Fruta(string nome){
    this.Nome = nome;
  }
}

class Doce: IItem{
  public string Nome{get; set;}
  public Doce(string nome){
    this.Nome = nome;
  }
}

interface IItem{
  string Nome{get; set;}
}

class Loja{
  private Aplicativo[] apps = new Aplicativo[10];
  private int k;

  public string Nome{get; set;}
  public int Qtd{get;}

  public void Inserir(Aplicativo app){
    apps[k] = app;
    k++;
  }

  public void Listar(){
    for(int i = 0; i<k; i++)
      Console.WriteLine(apps[i].Nome);
  }

  public void Excluir(Aplicativo app){
    int ind = Array.IndexOf(apps, app);
    if(k>0 && ind>=0){
      for(int i=ind+1; i<k; i++)
        apps[i-1] = apps[i];
      k--;
    }
  }

}