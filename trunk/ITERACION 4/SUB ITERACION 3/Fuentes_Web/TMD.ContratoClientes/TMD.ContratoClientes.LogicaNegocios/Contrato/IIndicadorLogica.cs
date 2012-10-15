﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.Entidades;
using System.Data;

namespace TMD.CC.LogicaNegocios.Contrato
{
    public interface IIndicadorLogica
    {

        List<Indicador> ListarIndicador();

        void Agregar(Indicador indicador);
    }
}
