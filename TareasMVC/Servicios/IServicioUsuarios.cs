using System.Security.Claims;

namespace TareasMVC.Servicios
{
    public interface IServicioUsuarios
    {
        string ObtenerUsuarioId();
    }

    public class ServicioUsuarios : IServicioUsuarios
    {
        private HttpContext HttpContext;
        public ServicioUsuarios(IHttpContextAccessor contextAccessor)
        {
            HttpContext = contextAccessor.HttpContext;
        }
        public string ObtenerUsuarioId()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var idClaim = HttpContext.User.Claims.Where( u => u.Type == ClaimTypes.NameIdentifier ).FirstOrDefault();

                return idClaim != null ? idClaim.Value : null;
            }
            else
            {
                throw new Exception("EL usuario no esta autenticado");
            }


        }
    }
}
