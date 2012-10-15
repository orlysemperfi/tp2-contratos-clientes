using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.Entidades;
using System.Data;

namespace TMD.CC.AccesoDatos.Contrato
{    

    public interface IClausulaData
    {
       
        //Solicitud Obtener(int id);

        List<Clausula> ListarClausula();

        void Agregar(Clausula clausula);
        
    }
}
