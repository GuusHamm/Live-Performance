namespace GuusHamm__S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Oracle.DataAccess.Client;

    /// <summary>The database manager.</summary>
    public static class DatabaseManager
    {
        /// <summary>Gets the connection.</summary>
        public static OracleConnection Connection { get; private set; }

        /// <summary>The initialize.</summary>
        public static void Initialize()
        {
            Connection =
                new OracleConnection(
                    "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.15.50)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora))); User ID=dbi312497; Password=WdCYOlWdSf");
        }

        /// <summary>The query template.</summary>
        public static void DatabaseQueryTemplate()
        {
            using (OracleConnection connection = DatabaseManager.Connection)
            {
                string query = string.Format("select * from {0}", "Test");
                OracleCommand command = new OracleCommand(query, connection);
                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MessageBox.Show(reader[0].ToString());
                    }
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
