using System;

class MainClass{
    public static string senha(string texto){
        string[] palavras = texto.Split();
        string senha = "";
        int tam = texto.Length;
        int tamV = palavras.Length;
        int cont = 0;
        while(cont<tamV){
            tam = palavras[cont].Length;
            senha += tam.ToString();
            cont++;
        }
        return senha;
    }

    public static void Main(string[] args){
        string texto = Console.ReadLine();
        Console.WriteLine(senha(texto));
    }
}