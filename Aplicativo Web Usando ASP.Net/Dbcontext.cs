using Microsoft.EntityFrameworkCore;

namespace Aplicativo_Web_Usando_ASP.Net
{
    public class Dbcontext
    {
        private DbContextOptions options;

        public Dbcontext(DbContextOptions options)
        {
            this.options = options;
        }
    }
}