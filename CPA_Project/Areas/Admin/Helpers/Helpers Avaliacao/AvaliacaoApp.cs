using System;
using CPA_Project.Areas.Admin.Controllers;
using CPA_Project.Connect_DB;

namespace CPA_Project.Areas.Admin.Helpers
{
    public class AvaliacaoApp
    {
        private Contexto _contexto;

        public void criarAvaliacao(AvaliacaoViewModel avaliacaoViewModel)
        {
            var strQuery = string.Format("INSERT INTO AVALIACAO(NOME, DATA_CRIACAO, DATA_EXPEDICAO) VALUES('{0}','{1}','{2}')",
                avaliacaoViewModel.Nome, avaliacaoViewModel.Data_criacao, avaliacaoViewModel.Data_expedicao);
            var strQuery_q = string.Format("INSERT INTO AVALIACAO_QUESTAO() VALUES()");
        }
    }
}