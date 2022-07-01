namespace series
{
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set;}
        private string Titulo { get; set;}
        private string Descricao { get; set;}
        private int Ano { get; set;}

        public Series(int id, Genero genero, string titutlo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titutlo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "" + this.Titulo + Environment.NewLine;
            retorno += "" + this.Descricao + Environment.NewLine;
            retorno += "" + this.Ano; 
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }
    }
}