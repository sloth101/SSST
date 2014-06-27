using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Security.Cryptography;


namespace SuperSambaSommerTippspiel
{
    class DBAccess
    {

        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;
       

        public DBAccess() { 
            
        }
        private void Connect() {
            this.connection = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=T:\Klassen\e2fi2t\SAE\Tippspiel_SSS\SSSDB.accdb");
            this.connection.Open();
            this.command = new OleDbCommand();
            this.command.Connection = this.connection;
        }
        private void Disconnect() {
            this.connection.Close();
        }
        public int Anmelden(string name, string pw) {
            
            this.Connect();
            pw = pw.GetHashCode().ToString();
            this.command.CommandText = "SELECT T_ID FROM Teilnehmer WHERE T_Name = '" + name + "' AND Passwort = '" + pw + "'";
            this.reader = this.command.ExecuteReader();
            int id= -1;
            if (this.reader.HasRows)
            {
                this.reader.Read();
                id = this.reader.GetInt32(0); 
            }
            this.Disconnect();
            return id;
        }

        public bool Registrierung(string name, string pw)
        {
            try
            {
                this.Connect();
                pw = pw.GetHashCode().ToString();
                this.command.CommandText = "INSERT INTO Teilnehmer(T_Name, Passwort) VALUES('" + name + "', '" + pw + "')";
                this.command.ExecuteReader();
                this.Disconnect();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
