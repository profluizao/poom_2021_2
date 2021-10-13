using System;

namespace ConsoleApp
{
    public abstract class CampoDeData
    {
        protected DateTime dataDeInsercao;

        public DateTime DataDeInsercao
        {
            get => this.dataDeInsercao;
            set => this.dataDeInsercao = value;
        }
    }
}
