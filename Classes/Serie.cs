namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            return @$"Gênero: {Genero}
Título: {Titulo}
Descrição: {Descricao}
Ano de Início: {Ano}
Excluido: {Excluido}";
        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

        public bool retornaExcluido()
        {
            return Excluido;
        }

        public void Excluir() // Só marca o objeto como excluído, mas não exclui
        {
            Excluido = true;
        }
    }
}