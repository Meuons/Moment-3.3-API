
using Microsoft.EntityFrameworkCore;
using Moment_3._3_API.Data;

namespace Moment_3._3_API
{
    public class startup
    {
        public class Startup
        {
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            // This method gets called by the runtime. Use this method to add services to the container.
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddControllers();

                services.AddDbContext<SongContext>(opt =>

                opt.UseSqlite(Configuration.GetConnectionString("SQLiteDbString")));




            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(
                IApplicationBuilder app,
                IWebHostEnvironment env
                )
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();

                }

                app.UseHttpsRedirection();
                app.UseRouting();
                app.UseAuthorization(

                );

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });



            }

        }

    }
}
