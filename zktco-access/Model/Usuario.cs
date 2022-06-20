namespace zktco_access.Model
{
    [Index(nameof(email), IsUnique = true)]
    public class Usuario
    {
        public int id { get; set; }
        
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string email { get; set; }

        public string celular { get; set; }

        public string dirrecion { get; set; }

        public string rol { get; set; }

        public string usuario { get; set; }

        public string password { get; set; }
    }
}
