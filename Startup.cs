using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HelloWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
