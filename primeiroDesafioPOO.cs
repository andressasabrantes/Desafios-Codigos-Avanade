using System;

class Pessoa
{
  public string Nome { get; private set; }
  public int Idade { get; private set; }
  
  public Pessoa(string nome, int idade)
  {
    Nome = nome;
    Idade = idade;
  }
}

class Program
{
    static void Main()
    {
       string nome = Console.ReadLine();
       int idade = int.Parse(Console.ReadLine());
      
       Pessoa p = new Pessoa(nome, idade);
       
       Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
    }
}