using System;

namespace Acciones
{
    internal class Transponer
    {
        public Transponer()
        {
        }

        public double[,] CalcularTranspuesta(double[,] laMatriz)
        {
            double[,] elResultado;

            var elCalculo = new Especificaciones.CalculoTranspuesta(laMatriz);
            elResultado = elCalculo.elCalculoDeLaTranspuesta();

            return elResultado;
        }
    }
}