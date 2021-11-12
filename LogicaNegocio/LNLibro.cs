﻿using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class LNLibro
    {
        #region Atributos
            private string mensaje;
            private string cadConexion;
        #endregion
        
        #region Constructores
        public LNLibro()
        {
            mensaje = string.Empty;
            cadConexion = string.Empty;
        }

        public LNLibro(string cadena)
        {
            mensaje = string.Empty;
            cadConexion = cadena;
        }
        #endregion

        #region Metodos
        public bool libroRepetido(ELibro libro)
        {
            bool result = false;
            ADLibro adLibro = new ADLibro(cadConexion);
            try
            {
                result = adLibro.libroRepetido(libro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

            return result;
        }

        public bool claveLibroRepetida(string clave)
        {
            bool result = false;
        
            ADLibro adLibro = new ADLibro(cadConexion);

            try
            {
                result = adLibro.claveLibroRepetida(clave);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public int insertar(ELibro libro)
        {
            int result;
            ADLibro adLibro = new ADLibro(cadConexion);
            try
            {
                result = adLibro.insertar(libro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public DataSet listarTodos(string condicion = "")
        {
            DataSet SetLibros;
            ADLibro adLibro = new ADLibro(cadConexion);
            try
            {
                SetLibros = adLibro.listarTodos(condicion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return SetLibros;
        }
        #endregion
    }
}
