using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Entity.Data
{
    class Startup
    {
        public void ConfigureServices(IConfigurationRoot Configuration, IServiceCollection services)
        {
            // Add framework services.
            //services.AddDbContext<SchoolContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
