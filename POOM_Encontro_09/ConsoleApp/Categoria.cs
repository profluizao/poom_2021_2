using System;

namespace ConsoleApp
{
    public class Categoria : CamposComuns
    {
        private int categoriaId;

        public int CategoriaId
        {
            get => this.categoriaId;
            set => this.categoriaId = value;
        }
    }
}
