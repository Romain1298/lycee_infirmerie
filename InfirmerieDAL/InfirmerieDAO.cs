using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;

namespace InfirmerieDAL
{
    internal class InfirmerieDAO
    {
        private static InfirmerieDAO unInfirmerieDAO;
        // Accesseur en lecture, renvoi une instance
        public static InfirmerieDAO GetunInfirmerieDAO()
        {
            if (unInfirmerieDAO == null)
            {
                unInfirmerieDAO = new InfirmerieDAO();
            }
            return unInfirmerieDAO;
        }

        // Cette méthode retourne une List contenant les objets Infirmeries
        //contenus dans la table Identification
        public static List<Infirmerie> GetInfirmeries()
        {
            int id;
            string nom;
            Infirmerie unInfirmerie;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Infirmeries
            List<Infirmerie> lesInfirmeries = new List<Infirmerie>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM T_Identification";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_Infirmerie"].ToString());
                if (monReader["Nom_Infirmerie"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["Nom_Infirmerie"].ToString();
                }
                unInfirmerie = new Infirmerie(id, nom);
                lesInfirmeries.Add(unInfirmerie);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesInfirmeries;
        }

        // Cette méthode insert un nouvel Infirmerie passé en paramètre dans la BD
        public static int AjoutInfirmerie(Infirmerie unInfirmerie)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO T_Identification values('" +
           unInfirmerie.Nom + "')";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un Infirmerie passé en paramètre dans la BD
        public static int UpdateInfirmerie(Infirmerie unInfirmerie)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE T_Identification SET Nom_Infirmerie = '"
           + unInfirmerie.Nom + "' WHERE Id_Infirmerie = " + unInfirmerie.Id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un Infirmerie dont l'id est passé
        //en paramètre
        public static int DeleteInfirmerie(int id)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM T_Identification WHERE Id_Infirmerie = " + id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
