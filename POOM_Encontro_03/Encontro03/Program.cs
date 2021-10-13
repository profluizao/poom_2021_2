using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    class Program
    {
        static void Main(string[] args)
        {
            Motocicleta moto1 = new Motocicleta();
            moto1.Autonomia = "150 km";
            moto1.Cilindradas = 1500;
            moto1.Codigo = 10903;
            moto1.Cor = "Azul";
            moto1.DataDeFabricacao = new DateTime(2021, 9, 8);
            moto1.Modelo = "teste";
            moto1.Nome = "teste de aula";
            moto1.NumeroDeChassi = "132asd";
            moto1.TipoDeCambio = "manual";
            moto1.TipoDeCombustivel = "Gasolina";
            moto1.TipoDeMotor = "teste";

            moto1.Ligar();
            moto1.ImprimirDados();
            moto1.Desligar();

            Console.ReadLine();

        }
    }
}
