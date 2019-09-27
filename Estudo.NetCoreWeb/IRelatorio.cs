using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Estudo.NetCoreWeb
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}