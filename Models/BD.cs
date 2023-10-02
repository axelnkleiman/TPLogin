using System.Data.SqlClient;
using Dapper;

public class BD
{
    private static string _connectionString = @"Server = .";
    public static void AgregarUsuario(User usuario){
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql ="INSERT INTO User(Username,Contrasena,Respuesta,Mail,FechaNacimiento) VALUES (@pUsername,@pContrasena,@pRespuesta,@Mail,@pFechaNacimiento)";
            db.Execute(sql, new {pUsername = usuario.Username, p.Contrasena = usuario.Contrasena, pRespuesta = usuario.Respuesta, pMail = usuario.Mail, pFechaNacimiento = usuario.FechaNacimiento});
        }
    }
    public static User VerInfoUsuario(string username){
        User infoUsuario = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM User WHERE Username = @username";
            infoUsuario = db.QueryFirstOrDefault<User>(sql, new{Username=username})
        }
        return infoUsuario;
    }
    public static void UpdatearContrasena(string nuevaContrasena,string mail,string respuesta){
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "UPDATE User SET Contrasena = @nuevaContrasena WHERE Mail = @mail AND Respuesta = @respuesta";
            db.Execute(sql, new {Contrasena = nuevaContrasena, Mail = mail, Respuesta = respuesta});
        }
    }
}