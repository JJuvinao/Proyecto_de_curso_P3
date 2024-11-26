using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaRepository
    {
        public CategoriaRepository() { }

        public DataTable Listado_Categoria()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_CATEGORIAS", sqlconnec))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("resultadoCursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
                    dataReader = command.ExecuteReader();
                    tabla.Load(dataReader);
                }
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlconnec.State == ConnectionState.Open)
                {
                    sqlconnec.Close();
                }
            }
        }

        public DataTable Listado_Nombre_Categoria()
        {
            OracleDataReader dataReader;
            DataTable tabla = new DataTable();
            OracleConnection sqlconnec = new OracleConnection();
            try
            {
                sqlconnec = DBConnection.Getinstancia().GetConnection();
                sqlconnec.Open();
                using (OracleCommand command = new OracleCommand("FX_CONSULTAR_NOMBRE_CATEGORIAS", sqlconnec))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("resultadoCursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
                    dataReader = command.ExecuteReader();
                    tabla.Load(dataReader);
                }
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlconnec.State == ConnectionState.Open)
                {
                    sqlconnec.Close();
                }
            }
        }

        public List<Categorias> GetList()
        {
            DataTable tablecategoria = Listado_Categoria();
            List<Categorias> categorias = new List<Categorias>();

            foreach (DataRow row in tablecategoria.Rows)
            {
                Categorias elemento = new Categorias
                {
                    Id_Categoria = row["ID_CATEGORIA"].ToString(),
                    Nombre = row["NOMBRE_CATEGORIA"].ToString()
                };
                categorias.Add(elemento);
            }

            return categorias;
        }

        public List<string> GetList_Nombre()
        {
            DataTable tablecategoria = Listado_Nombre_Categoria();
            List<string> Nom_categorias = new List<string>();

            foreach (DataRow row in tablecategoria.Rows)
            {
                Nom_categorias.Add((string)row["NOMBRE_CATEGORIA"]);
            }

            return Nom_categorias;
        }
    }
}
