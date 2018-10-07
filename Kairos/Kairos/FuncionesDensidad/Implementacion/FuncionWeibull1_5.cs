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
    class FuncionWeibull1_5 : FuncionDensidadProbabilidad, IFuncionRepresentable
    {
        private readonly double shape = 1.5;
        private readonly double scale = 1;

        public string StringFDP => string.Format("f(x) = ({0}/{1})*(x/{1})^({0}-1)*e^(-(x/{1})^{0})", shape, scale);

        public string StringInversa => string.Format("f(R)= {1}*(-ln(-R+1))^(1/{0})", shape, scale);

        public FuncionWeibull1_5(double[] eventos) : base(eventos)
        {
            try
            {
                DistribucionContinua = new WeibullDistribution(shape, scale);
                Resultado = new ResultadoAjuste(StringFDP, StringInversa, DistribucionContinua.StandardDeviation, DistribucionContinua.Mean, DistribucionContinua.Variance, this);
            }
            catch (Exception)
            {
                Resultado = null;
            }
        }
    }

}