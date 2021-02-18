using System;

class MainClass{
  public static void Main(string[] args){
    EntradaCinema x = new EntradaCinema();
    Console.WriteLine("Digite o dia e a hora da sessao no formato dd-mm-aaaa-hh-mm-ss");
    string sessao = Console.ReadLine();
    
    x.setSessao(sessao);
    Console.WriteLine(x.valor());
  }
}

class EntradaCinema{
  private DateTime filme;

  public void setSessao(string sessao){
    string[] horario = sessao.Split("-");
    filme = new DateTime(int.Parse(horario[2]), int.Parse(horario[1]), int.Parse(horario[0]), int.Parse(horario[3]), int.Parse(horario[4]), int.Parse(horario[5]));
  }

  public double valor(){
    double acrescimo = 1.0;
    if(filme.Hour >= 17) 
      acrescimo=1.2;

    if(filme.DayOfWeek==DayOfWeek.Monday || filme.DayOfWeek==DayOfWeek.Tuesday || filme.DayOfWeek==DayOfWeek.Thursday){
      return 16.00*acrescimo;
    }
    else if(filme.DayOfWeek==DayOfWeek.Wednesday){
      return 8*acrescimo;
    }
    else
      return 20*acrescimo;
  }
  public DateTime getSessao(){
    return filme;
  }
}