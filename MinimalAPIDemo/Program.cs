
using System.Data;
using System.Data.SqlClient;
using Dapper;

using DataAccess.DbAccess;
using DataAccess.Models;
using MinimalAPIDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>(); //data access
builder.Services.AddSingleton<IUserData, UserData>(); //users data
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.ConfigureApi(); 





string con = "Data Source=DESKTOP-ESCI621; Initial Catalog=MinimalApiUserDB; Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
using IDbConnection connection = new SqlConnection(con);
var rez = connection.Query<UserModel>("SELECT [Id],[FirstName],[LastName] FROM[MinimalApiUserDB].[dbo].[User] ");




app.Run();

