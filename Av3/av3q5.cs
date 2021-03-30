using System;
using System.Collections;

class MainClass{
  public static void Main(){
    ArrayList cesta = new ArrayList();
    Fruta f1 = new Fruta("banana");
    Doce d1 = new Doce("chocolate");
    cesta.Add(f1);
    cesta.Add(d1);

    Colecao<int> n = new Colecao<int>();
    n.Inserir(3);
    n.Inserir(5);
    n.Inserir(7);
    n.Inserir(9);


    foreach (int item in n.Listar())
      Console.WriteLine(item);

    for(int i=0; i<cesta.Count; i++) 
       Console.WriteLine(((IItem)cesta[i]).Nome);  }
}

interface ILogin {
  string Usuario { get; }
  string Senha {get;}
}

class Colecao<T>{
  private T[] objs = new T[2];
  private int k;

  public void Inserir(T obj){
    if(k<2) objs[k++] = obj;
    else{
      Array.Resize(ref objs, objs.Length*2);
      objs[k++] = obj;
    } 
  }
  public T[] Listar(){
    T[] r = new T[k];
    Array.Copy(objs, r, k);
    return r;
  }
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