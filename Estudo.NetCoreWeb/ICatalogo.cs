using System.Collections.Generic;

namespace Estudo.NetCoreWeb
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}