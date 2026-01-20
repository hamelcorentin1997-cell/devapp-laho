// See https://aka.ms/new-console-template for more information
using ADONETEX02.Class;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.WriteLine("exercice client || commande");
string connectionString = "Server=localhost;Database=dbcommandes;User ID=root;Password=root";

// ajouter client
void AjouterClient()
{
    Console.WriteLine("--- Ajouter un client ---");
    Console.Write("Nom : ");
    var nom = Console.ReadLine();
    Console.Write("Prenom : ");
    var prenom = Console.ReadLine();
    Console.Write("Adresse : ");
    var adresse = Console.ReadLine();
    Console.Write("Code postal : ");
    var codePostal = Console.ReadLine();
    Console.Write("Ville : ");
    var ville = Console.ReadLine();
    Console.Write("Numéro de Telephone : ");
    var telephone = Console.ReadLine();
    Clients client = new Clients(nom, prenom, adresse, codePostal, ville, telephone);
    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = "INSERT INTO Clients (nom,prenom, adresse, codePostal, ville, numeroTelephone) VALUES (@nom,@prenom, @adresse, @codePostal, @ville, @numeroTelephone)";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nom", client.Nom);
        cmd.Parameters.AddWithValue("@prenom", client.Prenom);
        cmd.Parameters.AddWithValue("@adresse", client.Adresse);
        cmd.Parameters.AddWithValue("@codePostal", client.CodePostal);
        cmd.Parameters.AddWithValue("@ville", client.Ville);
        cmd.Parameters.AddWithValue("@numeroTelephone", client.NumeroTelephone);

        int rows = cmd.ExecuteNonQuery();
        if (rows > 0)
        {
            Console.WriteLine("Client ajouté avec succès !");
        }

    }
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
    }
}

// afficher tout client
void AfficherClient()
{
    Console.WriteLine("--- Liste des clients ---");
    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = "SELECT * FROM clients";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Clients c = new Clients(
                    reader.GetInt32("clientId"),
                    reader.GetString("nom"),
                    reader.GetString("prenom"),
                    reader.GetString("adresse"),
                    reader.GetString("codePostal"),
                    reader.GetString("ville"),
                    reader.GetString("numeroTelephone")
                );

                Console.WriteLine(c);
            }
        }
        else
        {
            Console.WriteLine("Aucun client en base.");
        }

        reader.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }

}
// editer client 
void EditerClient()
{
    Console.WriteLine("id du client recherché: ");
    int id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {

        connection.Open();

        string queryCheck = "SELECT COUNT(*) FROM clients WHERE clientId = @id";
        MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection);
        cmdCheck.Parameters.AddWithValue("@id", id);
        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

        if (count == 0)
        {
            Console.WriteLine("aucune personne avec cet id!");
            return;
        }

        Console.WriteLine("modification du  client");
        Console.Write("nom : ");
        var nom = Console.ReadLine();

        Console.Write("prenom : ");
        var prenom = Console.ReadLine();

        Console.Write("adresse : ");
        var adresse = Console.ReadLine();

        Console.Write("code postal : ");
        var codePostal = Console.ReadLine();

        Console.Write("ville : ");
        var ville = Console.ReadLine();

        Console.Write("numéro de telephone : ");
        var numeroTelephone = Console.ReadLine();

        string query = "UPDATE clients SET nom = @nom, prenom  = @prenom , adresse = @adresse, codePostal = @codePostal, ville = @ville WHERE clientId = @id";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nom", nom);
        cmd.Parameters.AddWithValue("@prenom", prenom);
        cmd.Parameters.AddWithValue("@adresse", adresse);
        cmd.Parameters.AddWithValue("@codePostal", codePostal);
        cmd.Parameters.AddWithValue("@ville", ville);
        cmd.Parameters.AddWithValue("@id", id);

        int rowsAffected = cmd.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            Console.WriteLine("le client a été modifié.");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur: {ex.Message}");

    }
    finally
    {
        connection.Close();
    }

}
//suprimer client et ces commandes
void SuprimmerClient()
{
    Console.WriteLine("id du client à supprimer : ");
    var id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = "DELETE FROM clients WHERE clientId = @id";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);

        int rowsAffected = cmd.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            Console.WriteLine("client supprimé");
        }
        else
        {
            Console.WriteLine("pas de client a cet id!");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur: {ex.Message}");
    }
    finally { connection.Close(); }
}


// detail client et comandes
void DetailClient()
{
    Console.WriteLine("--- Consulter un client et ses commandes ---");
    Console.WriteLine("Id du client :");
    int id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

//        string query = @"
//SELECT
//  cl.id, cl.nom, cl.prenom, cl.adresse, cl.codePostal,
//  cl.ville, cl.numeroTelephone, co.id, co.dateComande, co.total, co.clientId
//FROM clients cl 
//LEFT JOIN commandes co ON co.clientId = cl.id
//WHERE cl.id = @id;
//";
          string query = @"
                SELECT
          cl.clientId AS clientId, cl.nom, cl.prenom, cl.adresse, cl.codePostal,
          cl.ville, cl.numeroTelephone, 
          co.commandeId AS commandeId, co.dateCommande, co.total, co.clientId
        FROM clients cl
        LEFT JOIN commandes co ON co.clientId = cl.clientId
        WHERE cl.clientId = @id;
                ";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);

        MySqlDataReader reader = cmd.ExecuteReader();

        Clients client = null;

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                if (client == null)
                {
                    client = new Clients(
                        reader.GetInt32("ClientId"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetString("adresse"),
                        reader.GetString("codePostal"),
                        reader.GetString("ville"),
                        reader.GetString("numeroTelephone")
                    );
                }

                if (!reader.IsDBNull(reader.GetOrdinal("commandeId")))
                {
                    Commandes commande = new Commandes(
                        reader.GetInt32("CommandeId"),
                        reader.GetDateTime("dateCommande").ToString(),
                        reader.GetDouble("total")
                    );
                    client.commandes.Add(commande);
                    
                }
            }
        }

        reader.Close();

        if (client == null)
        {
            Console.WriteLine("Aucun client trouvé avec cet Id.");
            return;
        }

        Console.WriteLine(client);
        foreach (var commande in client.commandes)
        {
            Console.WriteLine("  - " + commande);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}
// ajouter comande a un client 
void AjouterCommande()
{
    Console.WriteLine("--- Ajouter une commande ---");
    Console.Write("id du client : ");
    var idClient = int.Parse(Console.ReadLine());
    Console.Write("date commande : ");
    var date = Console.ReadLine();
    Console.Write("total de la commande : ");
    var total = double.Parse(Console.ReadLine());
    
    Commandes commande = new Commandes(idClient, date, total);
    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = "INSERT INTO commandes (clientId ,dateCommande, total) VALUES (@clientId,@dateCommande, @total)";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@clientId", commande.ClientId);
        cmd.Parameters.AddWithValue("@dateCommande", commande.Date);
        cmd.Parameters.AddWithValue("@total", commande.Total);

        int rows = cmd.ExecuteNonQuery();
        if (rows > 0)
        {
            Console.WriteLine("commande ajouté avec succès !");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
    }

}



//AjouterClient();
//AjouterClient();
//SuprimmerClient();
//AfficherClient();
//AjouterCommande();

DetailClient();