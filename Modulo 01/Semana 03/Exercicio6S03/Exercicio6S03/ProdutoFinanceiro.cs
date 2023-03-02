using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6S03
{
    internal class ProdutoFinanceiro : Produto
    {
        public void acesso()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
            PF1.Nome = "Produto dentro classe produto financeiro";
            PF1.Cor = "Verde";
            Console.WriteLine("Nome: " + PF1.Nome + "Cor: " + PF1.Cor);
            PF1.vender();
            PF1.verificarEstoque();
            PF1.alteraAtributosPrivados(99, 100.0);
        }
    }
}
