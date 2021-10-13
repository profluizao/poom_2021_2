using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class LocacaoDeCarro : Locacao, ILocacao
    {
        private Carro carroParaAlugar;

        public Carro CarroParaAlugar 
        {
            get => this.carroParaAlugar;
            set => this.carroParaAlugar = value;
        }

        public LocacaoDeCarro()
        {
        }

        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Devolver()
        {
            throw new NotImplementedException();
        }

        public void Efetuar()
        {
            throw new NotImplementedException();
        }

        public void Renovar()
        {
            throw new NotImplementedException();
        }
    }
}
