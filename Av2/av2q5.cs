using System;

class MainClass{
  public static void Main(){
    Aplicativo a = new Aplicativo{Nome = "abc", Categoria="gue", Preco=10};
    Aplicativo b = new Aplicativo{Nome = "def", Categoria="gue", Preco=10};
    Aplicativo c = new Aplicativo{Nome = "ghi", Categoria="gue", Preco=10};
    Aplicativo d = new Aplicativo{Nome = "jkl", Categoria="gue", Preco=10};
    Loja x = new Loja();
    x.Inserir(a);
    x.Inserir(b);
    x.Inserir(c);
    x.Inserir(d);
    x.Listar();
    x.Excluir(b);
    x.Listar();
  }
}

class Aplicativo{
  private int curtidas;

  public string Nome{get; set;}
  public string Categoria{get; set;}
  public double Preco{get; set;}
  public string Curtidas{get;}
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