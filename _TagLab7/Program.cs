var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseStaticFiles();

app.Map("/addReg", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {

        await next(); 
    });

    appBuilder.Run(async context => await context.Response.WriteAsync("HuiD"));
});

app.Map("/redReg", appBuilder =>
{
    
    appBuilder.Use(async (context, next) =>
    {

        await next();
    });

    appBuilder.Run(async context => await context.Response.WriteAsync("Pizda"));
});

app.Map("/fetchPeriod", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {

        await next(); 
    });

    appBuilder.Run(async context => await context.Response.WriteAsync(""));
});

app.Map("/delete", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {

        await next();   
    });

    appBuilder.Run(async context => await context.Response.WriteAsync(""));
});

app.Map("/list", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {

        await next();  
    });

    appBuilder.Run(async context => await context.Response.WriteAsync(""));
});

app.Run();
