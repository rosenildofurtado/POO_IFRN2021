using System;

enum SituacaoEstagio{
  Cadastrado, Iniciado, Cancelado, Finalizado
}

class Estagio{
  private string estagiario, empresa;
  private DateTime dataInicio;  
  private DateTime dataCancelamento; 
  private DateTime dataFim; 
  private int situacao;

  public Estagio(string est, string emp){
    estagiario = est;
    empresa = emp;
    situacao = SituacaoEstagio.Cadastrado;
  }

  public bool Iniciar(DateTime data){
    dataInicio = data;
    situacao = SituacaoEstagio.Iniciado;
    return true;
  }

  public bool Cancelar(DateTime data){
    dataCancelamento = data;
    situacao = SituacaoEstagio.Cancelado;
    return true;
  }

  public bool Finalizar(DateTime data){
    dataFim = data;
    situacao = SituacaoEstagio.Finalizado;
    return true;
  }
}