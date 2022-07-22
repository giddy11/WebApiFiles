namespace ConsoleToWebApi
{
    public class Startup
    {
        public static void ConfigurationServices(IServiceCollection services)
        {
            //used only for the web API and by using this controllers, this application has the support of the controllers
            //and since we are dealing with the controllers, then the output will be generated from the controllers ie map
            //the routing to the controllers.
            services.AddControllers();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Adds a RouteEndpoint to the IEndRouteBuilder that matches HTTP GET requests for the specified pattern
            app.UseRouting();           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                /*endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello from new web API app");       //To write any kind of output in the response
                });

                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello from new web API app test");       //To write any kind of output in the response
                });*/
            });
        }
    }
}
