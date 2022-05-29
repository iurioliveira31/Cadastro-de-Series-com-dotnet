using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        
        public void Atualizar()
        {
            System.Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            System.Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            listaSerie[indiceSerie] = atualizaSerie;
        }

        public void Excluir()
        {
            System.Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            listaSerie[indiceSerie].Excluir();
        }

        public void Insere()
        {
            System.Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            System.Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            listaSerie.Add(novaSerie);
        }

        public void Lista()
        {
            System.Console.WriteLine("Listar Séries");

            var lista = listaSerie;

            if(lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                System.Console.WriteLine($"#ID {serie.retornaId()}: - {serie.retornaTitulo()} {(excluido ? "*Excluído*" : "")}");
            }
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public void RetornoPorId()
        {
            System.Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = listaSerie[indiceSerie];

            System.Console.WriteLine(serie);
        }
    }
}