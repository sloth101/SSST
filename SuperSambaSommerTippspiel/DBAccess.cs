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

        private void connect() {
            this.connection = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=D:\Eigene Dateien\Documents\GitHub\SSST\SSSDB.accdb");
            this.connection.Open();
            this.command = new OleDbCommand();
            this.command.Connection = this.connection;
        }

        private void disconnect() {
            this.connection.Close();
        }

        public int anmelden(string name, string pw) {

            this.connect();
            int id = -1;
            pw = pw.GetHashCode().ToString();
            
            this.command.CommandText = "SELECT T_ID FROM Teilnehmer WHERE T_Name = '" + name + "' AND Passwort = '" + pw + "'";
            this.reader = this.command.ExecuteReader();

            if (this.reader.HasRows)
            {
                this.reader.Read();
                id = this.reader.GetInt32(0); 
            }

            this.disconnect();
            return id;
        }

        public bool registrierung(string name, string pw)
        {
            try
            {
                this.connect();
                pw = pw.GetHashCode().ToString();

                this.command.CommandText = "INSERT INTO Teilnehmer(T_Name, Passwort) VALUES('" + name + "', '" + pw + "')";
                this.command.ExecuteReader();

                this.disconnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int[] getGruppe(int gruppenID)
        {
            int[] gruppe = new int[4];

            this.connect();

            this.command.CommandText = "SELECT M_ID1, M_ID2, M_ID3, M_ID4 FROM Gruppe WHERE G_ID = " + gruppenID;
            this.reader = this.command.ExecuteReader();

            this.reader.Read();

            for (int i = 0; i < gruppe.Length; i++)
            {
                gruppe[i] = this.reader.GetInt32(i);
            }

            this.disconnect();
            return gruppe;
        }

        public void setPaarung(int M_ID1, int M_ID2)
        {
            this.connect();

            this.command.CommandText = "INSERT INTO Spiel (M_ID1, M_ID2) VALUES (" + M_ID1 + ", " + M_ID2 + ")";
            this.command.ExecuteReader();

            this.disconnect();
        }
    }
}
