using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    });

// Add Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Blog API",
        Version = "v1",
        Description = "API for managing blog posts and authors."
    });
});

var app = builder.Build();

// Enable middleware for Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog API v1");
    });

    // Seed data during development
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<BlogDataContext>();
        context.Database.EnsureCreated();
        BlogDataContext.Seed(context);
    }
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

#region Models
public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Post> Posts { get; set; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Author Author { get; set; }
}
#endregion

#region DataContext
public class BlogDataContext : DbContext
{
    static readonly string connectionString = "Server=localhost; User ID=root; Password=pass; Database=blog";

    public DbSet<Author> Authors { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public static void Seed(BlogDataContext context)
    {
        if (!context.Authors.Any() && !context.Posts.Any())
        {
            var john = new Author { Name = "John T. Author", Email = "john@example.com" };
            var jane = new Author { Name = "Jane Q. Hacker", Email = "jane@example.com" };

            var posts = new List<Post>
            {
                new Post { Title = "Hello World", Content = "I wrote an app using EF Core!", Author = jane },
                new Post { Title = "How to use EF Core", Content = "It's pretty easy", Author = john }
            };

            context.Authors.AddRange(john, jane);
            context.Posts.AddRange(posts);

            context.SaveChanges();
        }
    }
}
#endregion

#region Controllers
[ApiController]
[Route("api/[controller]")]
public class AuthorsController : ControllerBase
{
    private readonly BlogDataContext _context;

    public AuthorsController(BlogDataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
    {
        return await _context.Authors.Include(a => a.Posts).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Author>> CreateAuthor(Author author)
    {
        _context.Authors.Add(author);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAuthors), new { id = author.AuthorId }, author);
    }
}

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    private readonly BlogDataContext _context;

    public PostsController(BlogDataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
    {
        return await _context.Posts.Include(p => p.Author).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Post>> CreatePost(Post post)
    {
        var author = await _context.Authors.FindAsync(post.Author.AuthorId);
        if (author == null)
        {
            return BadRequest("Author not found.");
        }

        post.Author = author;
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPosts), new { id = post.PostId }, post);
    }
}
#endregion
