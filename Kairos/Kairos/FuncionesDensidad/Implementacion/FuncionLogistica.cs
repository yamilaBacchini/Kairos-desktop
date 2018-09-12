﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Analysis;
using Kairos.Entidades;
using Kairos.Modelo;

namespace Kairos.FuncionesDensidad.Implementacion
{
    class FuncionLogistica : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        private readonly string MU = "";
        private readonly string S = "";

        public string StringFDP => string.Format("(e^(({0}-x)/{1}))/({1}*(1+e^(({0}-x)/{1}))^2)",MU,S);

        public string StringInversa =>string.Format("f(R) = {0}-{1}*ln(1/R-1)", MU,S);

        public FuncionLogistica(double[] eventos) : base(eventos)
        {
            try
            {
                 var distribucionContinua= new Accord.Statistics.Distributions.Univariate.LogisticDistribution();
                distribucionContinua.Fit(eventos);
                 //this.MU = distribucionContinua.Location.ToString("0.0000");
                 //this.S = DistribucionContinua.Scale.ToString("0.0000");
                 Resultado = new ResultadoAjuste(StringFDP, StringInversa, distribucionContinua.StandardDeviation, distribucionContinua.Mean, distribucionContinua.Variance, this);
                 
            }
            catch (Exception ex)
            {
                Resultado = null;
            }
        }
    }
}
