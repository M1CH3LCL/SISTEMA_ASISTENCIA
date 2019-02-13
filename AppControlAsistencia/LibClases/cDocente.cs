﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cDocente : cEntidad
    {
        //------------ ATRIBUTOS -------------
        //-- Se heredan de cEntidad

        //------------ METODOS ---------------
        //----- Constructores
        public cDocente() : base("TDocente")
        {
        }
        //---- Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "CodDocente", "Contraseña", "DNI", "Nombre", "Direccion", "Telefono" };
        }

        public Boolean RespuestaLogin(string pUsuario, string pContraseña)
        {
            string Consulta = "exec spuTDocente_Validar '"+pUsuario+"' ,'"+pContraseña+"'";
            Console.WriteLine(Consulta);

            aConexion.EjecutarSelect(Consulta);
            if (aConexion.Datos.Tables[0].Rows[0][0].ToString() == "0")
                return true;
            else
                return false;
        }
    }
}
