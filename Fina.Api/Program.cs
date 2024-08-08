using Fina.Api.Data;
using Fina.Api.Handlers;
using Fina.Core.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=fina;Trusted_Connection=True;MultipleActiveResultSets=true";

// Padrão utiliza AddScoped
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();
builder.Services.AddTransient<ITransactionHandler, TransactionHandler>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
