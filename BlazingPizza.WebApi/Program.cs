WebApplication.CreateBuilder(args)
    .ConfigureWebApiServices()
    .ConfigureWebApiMiddlewares()
    .Run();