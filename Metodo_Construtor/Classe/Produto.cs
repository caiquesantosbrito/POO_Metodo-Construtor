namespace Metodo_Construtor.Classe
{
    public class Produto
    {
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public string Desc{get; set;}
        public int Estoque{get; set;}

        // metodos construtores
        public Produto()
        {

        }
        public Produto(int cod, int est)
        {
            Codigo = cod;
            Estoque = est;
        }
        public Produto(int cod, string nom, string desc, int est)
        {
            Codigo = cod;
            Nome = nom;
            Desc = desc;
            Estoque = est;            
        }
    }
}