namespace hiflex
{
    public class series : entidadebase
    {
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Excluido { get; set;}

    public series(int Id, Genero genero, string Titulo, string Descricao, int Ano)
    {
        this.Id = Id;
        this.Genero = genero;
        this.Titulo = Titulo;
        this.Descricao = Descricao;
        this.Ano = Ano;
        this.Excluido = false;
    }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }

         public int retornaId()
         {
             return this.Id;
         }
         public void Excluir()
         {
             this.Excluido = true;
         }
         public bool retornaExcluido()
		{
			return this.Excluido;
		}
    }
}