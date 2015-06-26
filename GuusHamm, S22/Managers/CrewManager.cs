﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuusHamm__S22.Managers
{
    using System.Diagnostics.Eventing.Reader;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    using GuusHamm__S22.Models;

    using Oracle.DataAccess.Client;

    static class CrewManager
    {
        public static CrewMemberModel GetCrewById(int Id)
        {
            CrewMemberModel crewMemberModel = null;

                string query = string.Format("select * from CrewMember where id = {0}",Id);
                OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                try
                {
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        CrewMemberModel.JobEnum job;
                        CrewMemberModel.JobEnum.TryParse(reader[2].ToString(),true, out job);
                        crewMemberModel = new CrewMemberModel(Convert.ToInt32(reader[0]),reader[1].ToString(),job,Convert.ToDateTime(reader[3]),Convert.ToString(reader[4]));
                        return crewMemberModel;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
            return crewMemberModel;
        }

        public static List<CrewMemberModel> GetAvailableCrewMembers()
        {
            List<CrewMemberModel>crewMembers = new List<CrewMemberModel>();
            CrewMemberModel crewMember = null;

            
                string query = "select cm.* from crewmember cm where cm.id not in (select crewmemberid from crewmember_ship)";
                OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
               
                    OracleDataReader reader = command.ExecuteReader();

                    command.ExecuteNonQuery();
                    while (reader.Read())
                    {
                        
                        int id = Convert.ToInt32(reader[0]);
                        string name = reader[1].ToString();
                        DateTime birthday = Convert.ToDateTime(reader[2]);
                        string username  = Convert.ToString(reader[4]);
                        CrewMemberModel.JobEnum job;
                        CrewMemberModel.JobEnum.TryParse(reader[3].ToString(), true, out job);

                        crewMember = new CrewMemberModel(id,name,job,birthday,username);
                        crewMembers.Add(crewMember);
                    }
                
                     
                return crewMembers;
            
        }

        public static bool LogInCrewMember(string username, string password)
        {
            string actualPassword = null;
            int? id = null;

                string query = string.Format("select password, id from CrewMember where upper(username) =upper('{0}')", username);
                OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
               
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        actualPassword = reader[0].ToString();
                        id = Convert.ToInt32(reader[1]);
                    }
                
            
            if (password == actualPassword)
            {
                if (id != null)
                {
                    CrewManager.GetCrewById(Convert.ToInt32(id));
                    return true;
                }
            }
            return false;
        }
    }
}
