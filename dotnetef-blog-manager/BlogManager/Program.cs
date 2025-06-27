using BlogManager.Data;
using BlogManager.Models;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

RegisterServices(builder.Services);
var app = builder.Build();

ConfigureApp(app);

void RegisterServices(IServiceCollection services)
{
    services.AddDbContext<AppDbContext>();

    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Blogs API",
            Description = "Blog administration",
            Version = "v1"
        });
    });
}

void ConfigureApp(WebApplication app)
{
    var ctx = app.Services.CreateScope().ServiceProvider.GetService<AppDbContext>();
    ctx.Database.EnsureCreated();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.UseCors(builder => builder.AllowAnyOrigin());
}

app.MapGet("/v1/posts", (AppDbContext context) =>
{
    var posts = context.Posts;

    if (!posts.Any())
        return Results.NotFound();

    var postsDto = posts.Select(b => new BlogPostDto(b.Id, b.Title, b.Content, b.Tags, b.PublishedDate, b.CoverImage, b.Author)).ToList();

    return Results.Ok(postsDto);
}).Produces<BlogPostDto>();



app.Run();
