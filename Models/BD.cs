using System.Data.SqlClient;
using Dapper;

public class BD
{
    private static string _connectionString = @"Server = .";

    public static List<User> ObtenerUsuarios(){
        List <User> ListUsers = new List<User>();
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM User";
            ListUsers = db.Query<User>(sql).ToList();
        }
        return ListUsers;
    }
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
}