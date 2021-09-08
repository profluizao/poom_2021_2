using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class LocacaoDeCarros : ILocacao
    {
        private Carro carroParaAlugar;

        public Carro CarroParaAlugar 
        {
            get => this.carroParaAlugar;
            set => this.carroParaAlugar = value;
        }

        public decimal Valor 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public DateTime DataInicial 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        
        public DateTime DataFinal 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public string NomeLocatario 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public string DocumentoLocatario 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public LocacaoDeCarros()
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
