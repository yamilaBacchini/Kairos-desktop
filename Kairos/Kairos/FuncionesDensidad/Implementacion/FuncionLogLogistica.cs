﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Distributions.Univariate;
using Kairos.Entidades;
using Kairos.Modelo;

namespace Kairos.FuncionesDensidad.Implementacion
{
    class FuncionLogLogistica : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        public string StringFDP => "No implementado aun";

        public string StringInversa => "No implementado aun";

        public FuncionLogLogistica(double[] eventos) : base(eventos)
        {
            try
            {
                MultivariateDistribucionContinua = new LogLogisticDistribution();
                MultivariateDistribucionContinua.Fit(eventos);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, MultivariateDistribucionContinua.StandardDeviation, MultivariateDistribucionContinua.Mean, MultivariateDistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }
}
