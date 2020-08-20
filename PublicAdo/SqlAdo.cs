using System;
using System.Collections.Generic;

using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace PublicAdo
{
    /// <summary>
    /// that class is a base of the SqlAdo Operations
    /// </summary>
    public class SqlAdo
    {

       public static string _connectionString;

       public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
         static DBConnection Connection;


         public SqlAdo()
         {
             Connection= new DBConnection(ConnectionString);
             
         }
       
        #region Ado work Functions
        
        

        /// <summary>
        /// this function to execute non-Parametered select in data base and return values in data table 
        /// </summary>
        /// <param name="procedureName">name of the stored procedure</param>
        /// <param name="Connection">the connection used in the process</param>
        /// <returns></returns>
        public static DataTable ReturnDataTableFromDataBase(string procedureName)
        {
            return ExcuteAdapterStatement(procedureName, null);
        }


        /// <summary>
        /// this function to execute select in data base and return values in data table with only one parameter
        /// </summary>
        /// <param name="procedureName">name of the stored procedure</param>
        /// <param name="paramter">name of the parameter</param>
        /// <param name="Connection">the connection used in the process</param>
        /// <returns></returns>
        public static DataTable ReturnDataTableFromDataBase(string procedureName, SqlParameter paramter)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = paramter;
            return ExcuteAdapterStatement(procedureName, param);
        }

        /// <summary>
        /// this function to execute select in data base and return values in data table with array of parameters
        /// </summary>
        /// <param name="procedureName">name of the stored procedure</param>
        /// <param name="parmters">array of parameter send used in the Query statement </param>
        /// <param name="Connection">the connection used in the process</param>
        /// <returns> data table of result you select from data base</returns>
        public static DataTable ReturnDataTableFromDataBase(string procedureName, SqlParameter[] parmters)
        {
            return ExcuteAdapterStatement(procedureName, parmters);
        }
        

        /// <summary>
        /// the function that excutes the sql srarement itself
        /// </summary>
        /// <param name="procedureName">name of the stored procedure</param>
        /// <param name="parmters">array of parameter send used in the Query statement </param>
        /// <param name="Connection">the connection used in the process</param>
        /// <returns> data table of result you select from data base</returns>
        private static DataTable ExcuteAdapterStatement(string procedureName, SqlParameter[] parmters)
        {
            try
            {
                if (Connection.Con.State == ConnectionState.Closed)
                {
                    Connection.Con.Open();
                }
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(procedureName, Connection.Con);
                if (parmters != null)
                {
                    
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(parmters);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(dt);
                Connection.Con.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }



        /// <summary>
        /// Excutes insert ,update ,or delete statement 
        /// </summary>
        /// <param name="procedureName">the name of the stored procedure</param>
        /// <param name="parmters">the array of the parameters used in the Query statement</param>
        /// <param name="Connection">Sql Connection</param>
        /// <returns>the number of affected rows</returns>
        public static int ExcuteQueryStatement(string procedureName, SqlParameter[] parmters)
        {
            if (Connection.Con.State == ConnectionState.Closed)
            {
                Connection.Con.Open();

            }
            SqlCommand cmd = new SqlCommand(procedureName, Connection.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parmters != null)
            {
                cmd.Parameters.AddRange(parmters);
            }
            int AffectedRows=cmd.ExecuteNonQuery();
            Connection.Con.Close();
            return AffectedRows;

        }

         /// <summary>
        /// Excutes insert ,update ,or delete statement 
        /// </summary>
        /// <param name="procedureName">the name of the stored procedure</param>
        /// <param name="parmters">the parameter used in the Query statement</param>
        /// <param name="Connection">Sql Connection</param>
        /// <returns>the number of affected rows</returns>
        public static int ExcuteQueryStatement(string procedureName, SqlParameter parmter)
        {
            SqlParameter[] prms = new SqlParameter[1];
            prms[0] = parmter;
            return ExcuteQueryStatement(procedureName, prms);
        }

        /// <summary>
        ///  excutes select statement for getting one value only
        /// </summary>
        /// <param name="procedureName">the name of the stored procedure</param>
        /// <param name="parmters">the array of the parameters used in the Query statement</param>
        /// <param name="Connection">Sql Connection</param>
        /// <returns>returns the value of the first cell of the result</returns>
        public static object ExcuteScalarStatement(string procedureName, SqlParameter[] parmters)
        {
            if (Connection.Con.State == ConnectionState.Closed)
            {
                Connection.Con.Open();

            }
            SqlCommand cmd = new SqlCommand(procedureName, Connection.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parmters != null)
            {
                cmd.Parameters.AddRange(parmters);
            }
            object obj=cmd.ExecuteScalar();
            Connection.Con.Close();
            return obj;
        }

        /// <summary>
        ///  excutes select statement for getting one value only
        /// </summary>
        /// <param name="procedureName">the name of the stored procedure</param>
        /// <param name="parmters"> the parameter used in the Query statement</param>
        /// <param name="Connection">Sql Connection</param>
        /// <returns>returns the value of the first cell of the result</returns>
        public static object ExcuteScalarStatement(string procedureName, SqlParameter parmter)
        {
            SqlParameter[] prms=new SqlParameter[1];
            prms[0]=parmter;
            return ExcuteScalarStatement(procedureName,prms);
        }
        #endregion


        #region Adding Patameter
       

        /// <summary>
        /// function that adds sizeless parameter 
        /// </summary>
        /// <param name="Name">Parameter name</param>
        /// <param name="Type">Parameter type</param>
        /// <param name="Value">Parameter value</param>
        /// <returns>SqlParameter with the properties you send</returns>
        public static SqlParameter AddParameter(string Name, SqlDbType Type, object Value)
        {
            SqlParameter prm = new SqlParameter(Name, Type);
            prm.Value = Value;
            return prm;
        }

        /// <summary>
        /// function adds a sized parameter 
        /// </summary>
        /// <param name="Name">Parameter name </param>
        /// <param name="Type">Parameter type</param>
        /// <param name="Size">Parameter size</param>
        /// <param name="Value">Parameter value</param>
        /// <returns>SqlParameter with the properties you send</returns>
        public static SqlParameter AddParameter(string Name, SqlDbType Type, int Size, object Value)
        {
            SqlParameter prm = new SqlParameter(Name, Type, Size);
            prm.Value = Value;
            return prm;
        }


        #endregion
    }
}
