namespace GuusHamm__S22
{
    #region

    using System;
    using System.Windows.Forms;

    using Oracle.DataAccess.Client;

    #endregion

    /// <summary>The database manager.</summary>
    public class DatabaseSettings
    {
        /// <summary>Initializes a new instance of the <see cref="DatabaseSettings"/> class.</summary>
        public DatabaseSettings()
        {
            /*
            Connection = new OracleConnection();
            Connection.ConnectionString =string.Format(
                "User Id={0};Password={1};Data Source=//{2}:{3}/{4}", 
                "LivePerformance", 
                "test", 
                "localhost", 
                "1521", 
                "xe");

             */
            Connection =
                new OracleConnection(
                    "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.15.50)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora))); User ID=dbi312497; Password=WdCYOlWdSf");
            
            
        
            Connection.Open();
        }

        /// <summary>Gets the connection.</summary>
        public static OracleConnection Connection { get; private set; }

        /// <summary>The initialize.</summary>
        public static void Initialize()
        {
            /*
            Connection =
                new OracleConnection(
                    "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.15.50)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora))); User ID=dbi312497; Password=WdCYOlWdSf");
        
             */
            }

        /// <summary></summary>
        public static void Commit()
        {
            string query = "commit";

            OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
            command.ExecuteNonQuery();
        }

        // <summary>The query template.</summary>
        /// <summary></summary>
        public static void DatabaseQueryTemplate()
        {
            using (OracleConnection connection = DatabaseSettings.Connection)
            {
                string query = "select cm.* from crewmember cm where cm.id not in (select crewmemberid from crewmember_ship)";
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
