using System;

namespace ConsoleApp
{
    public abstract class CamposComuns : CampoDeData
    {
        protected string descricao;

        public string Descricao
        {
            get => this.descricao;
            set => this.descricao = value;
        }
    }
}
