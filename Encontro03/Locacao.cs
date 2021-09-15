using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public abstract class Locacao
    {
        protected decimal valor;
        protected DateTime dataInicial;
        protected DateTime dataFinal;
        protected string nomeLocatario;
        protected string documentoLocatario;

        public decimal Valor { get => valor; set => valor = value; }
        public DateTime DataInicial { get => dataInicial; set => dataInicial = value; }
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }
        public string NomeLocatario { get => nomeLocatario; set => nomeLocatario = value; }
        public string DocumentoLocatario { get => documentoLocatario; set => documentoLocatario = value; }
    }
}
