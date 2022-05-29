using Dio.Series;

string opcaoUsuario = ObterOpcaoUsuario();

SerieRepositorio repositorio = new SerieRepositorio();


while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            repositorio.Lista();
            break;
        case "2":
            repositorio.Insere();
            break;
        case "3":
            repositorio.Atualizar();
            break;
        case "4":
            repositorio.Excluir();
            break;
        case "5":
            repositorio.RetornoPorId();
            break;
        case "C":
            Console.Clear();
            break;
        default:
            throw new ArgumentOutOfRangeException();
        
    }
    opcaoUsuario = ObterOpcaoUsuario();
}

System.Console.WriteLine("Obrigado por utilizar nossos serviços!");
Console.ReadKey();





static string ObterOpcaoUsuario()
{
    System.Console.WriteLine();
    System.Console.WriteLine("DIOFLIX a seu dispor!");
    System.Console.WriteLine("Informe a opção desejada:");

    System.Console.WriteLine();
    System.Console.WriteLine("1- Listar séries");
    System.Console.WriteLine("2- Inserir nova série");
    System.Console.WriteLine("3- Atualizar série");
    System.Console.WriteLine("4- Excluir série");
    System.Console.WriteLine("5- Visualizar série");
    System.Console.WriteLine("C- Limpar Tela");
    System.Console.WriteLine("X- Sair");
    System.Console.WriteLine();

    string opcaoUsuario = System.Console.ReadLine().ToUpper();
    System.Console.WriteLine();
    return opcaoUsuario;
}