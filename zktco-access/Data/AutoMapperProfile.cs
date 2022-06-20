
namespace zktco_access.Data
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario,UsuarioDto>().ReverseMap();
            CreateMap<createUsuarioDto, Usuario>();
        }
    }
}
