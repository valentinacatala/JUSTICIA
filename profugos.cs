using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1
{
    
    class profugos
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        public profugos()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=JUSTICIA.mdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Profugos";

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["id"];
            tabla.PrimaryKey = vec;
        }
        public DataTable getData()
        {
            return tabla;
        }
    }
}
