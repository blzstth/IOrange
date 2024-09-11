using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using IOrange.ViewModels;

namespace IOrange.Controllers
{
    public class AccountController : Controller
    {
        private string connectionString = "Server=localhost;Database=IOrangeDatabase;Uid=root;Pwd=root;";

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Ellenőrizzük az ID és Username alapú felhasználói adatokat az adatbázisban
                if (ValidateUser(model.Id, model.Name))
                {
                    HttpContext.Session.SetString("Username", model.Name);
                    // Sikeres login, átirányítás az oldalra
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid User ID or Username.");
                }
            }

            return View(model);
        }

        // Felhasználói hitelesítés ID és Username alapján
        private bool ValidateUser(int userId, string username)
        {
            bool isValid = false;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Felhasználó lekérdezése ID és Username alapján
                string query = "SELECT COUNT(*) FROM Employee WHERE EId = @Id AND Name = @Name";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);  // @Id helyesen
                    cmd.Parameters.AddWithValue("@Name", username);

                    var result = Convert.ToInt32(cmd.ExecuteScalar());

                    // Ha a lekérdezés 1-et ad vissza, akkor van ilyen felhasználó
                    isValid = result > 0;
                }
            }

            return isValid;
        }

    }
}
