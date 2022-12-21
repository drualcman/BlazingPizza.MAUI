namespace BlazingPizza.WebApi.Configurations;

public static class ServicesConfiguration
{
    public static WebApplication ConfigureWebApiServices(this WebApplicationBuilder builder)
    {        
        builder.Services.AddEndpointsApiExplorer();          
        builder.Services.AddSwaggerGen();  
        builder.Services.AddBlazingPizzaServices(builder.Configuration, "BlazingPizza", "ImagesBaseUrl");
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(config => 
            {
                config.AllowAnyMethod();
                config.AllowAnyHeader();
                config.AllowAnyOrigin();
            });
        });
        return builder.Build();
    }
}
