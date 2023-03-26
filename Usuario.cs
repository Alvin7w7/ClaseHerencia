using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    abstract class Usuario
    {
        public string Cuenta { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public bool login(string username, string password)
        {
            if (username == this.Cuenta && password == Password)
            {
                Console.WriteLine("Bienvenido al Sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Error en los datos");
                return false;
            }
        }
        public void login()
        {
            Console.WriteLine("Login con Polimorfismo");
        }
    }
}
