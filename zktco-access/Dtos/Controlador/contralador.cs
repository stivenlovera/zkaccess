namespace zktco_access.Dtos.Controlador
{
    public class contralador
    {
        [Required(ErrorMessage = "Nombre es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Apellido es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string apellido { get; set; }

        [Required(ErrorMessage = "Email es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string email { get; set; }

        [Required(ErrorMessage = "Celular es Requerido")]
        [StringLength(maximumLength: 15, MinimumLength = 6)]
        public string celular { get; set; }

        [Required(ErrorMessage = "Dirrecion es Requerido")]
        [StringLength(maximumLength: 250)]
        public string dirrecion { get; set; }

        [Required(ErrorMessage = "Usuario es Requerido")]
        [StringLength(maximumLength: 250)]
        public string usuario { get; set; }
        [Required(ErrorMessage = "Contraseña es Requerido")]
        [StringLength(maximumLength: 250, MinimumLength = 3, ErrorMessage = "contraseña muy corta")]
        public string password { get; set; }
    }
}
