using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string Nome;

    public string Sobrenome;

    public int Idade;

    public string Telefone;

    public string Celular;

    public string Email;
    public Pessoa()
    {

    }

    public string DefinirNome()
    {
        Console.WriteLine("Informe o nome: ");

        //string nome;
        //nome = Console.ReadLine();
        //return nome;

        return Console.ReadLine();
    }
    public string DefinirSobrenome()
    {
        Console.WriteLine("Informe o sobrenome");
        return Console.ReadLine();
    }
    public int DefinirIdade()
    {
        Console.WriteLine("Informe a idade");
        //int idade;
        //idade = int.Parse(Console.ReadLine());
        //return idade;

        return int.Parse(Console.ReadLine());
    }

    public void DefinirTelefone(string telefone)
    {
        this.Telefone = telefone;
    }

    public void DefinirCelular(string celular)
    {
        Celular = celular;
    }

    public void DefinirEmail(string email)
    {
        Email = email;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"\n\nNome: {Nome}", this.Nome);
        Console.WriteLine($"Sobrenome: {Sobrenome}",this.Sobrenome);
        Console.WriteLine("Idade: "+this.Idade);
        Console.WriteLine("Telefone: "+this.Telefone);
        Console.WriteLine($"Celular: {Celular}",this.Celular);
        Console.WriteLine($"Email: {Email}",this.Email);
    }
}