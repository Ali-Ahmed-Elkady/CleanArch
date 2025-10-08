using Microsoft.EntityFrameworkCore;

using Domain.Entities;
using Infrastructure.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddIdentityApiEndpoints<AppUser>().AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDbContext>(
    op=>
    op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI(op=>op.SwaggerEndpoint("/openApi/v1.json", "v1"));
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapIdentityApi<AppUser>();
app.UseAuthorization();

app.MapControllers();

app.Run();
