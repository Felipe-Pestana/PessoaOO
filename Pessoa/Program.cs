string telefone, celular, email;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Pessoa p3 = new Pessoa();

Pessoa CriarPessoa()
{
    Pessoa p = new Pessoa();

    p.Nome = p.DefinirNome();
    p.Sobrenome = p.DefinirSobrenome();
    p.Idade = p.DefinirIdade();

    Console.WriteLine("Informe o telefone:");
    telefone = Console.ReadLine();

    p.DefinirTelefone(telefone);

    Console.WriteLine("Informe o Celular:");
    celular = Console.ReadLine();

    p.DefinirCelular(celular);

    Console.WriteLine("Informe o Email:");
    email = Console.ReadLine();

    p.DefinirEmail(email);

    return p;
}

p1 = CriarPessoa();
p2 = CriarPessoa();
p3 = CriarPessoa();

Console.WriteLine("Primeiro Cadastro");
p1.MostrarDados();

Console.WriteLine("Segundo Cadastro");
p2.MostrarDados();

Console.WriteLine("Terceiro Cadastro");
p3.MostrarDados();