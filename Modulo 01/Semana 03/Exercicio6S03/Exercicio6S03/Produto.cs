namespace Exercicio6S03
{
    internal class Produto
    {
        public string Nome;
        protected string Cor;
        private double Peso, Preco;

        public Produto(string nome, string cor)
        {
            Nome = nome;
            Cor = cor;
        } 

        public Produto()
        {

        }

        public void verificarEstoque() 
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void vender() 
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando produto, acessando método da classe produto");
        }

        protected void alteraAtributosPrivados(double Peso2, double Preco) 
        {
            Peso = Peso2;
            Console.WriteLine("Váriavel peso de escopo da classe: " + Peso);
        }
    }
}
