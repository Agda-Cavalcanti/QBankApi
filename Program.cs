using QBankApi.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/accounts", () => 
{
    // Código para obter todas as contas 
});

app.MapGet("/accounts/{id}", (int id) =>
{
    // Código para obter uma conta por ID
});

app.MapPost("/accounts", (Account account) =>
{
    // Código para criar uma nova conta
});

app.MapPut("/accounts/{id}", (int id, Account updateAccount) =>
{
    // Código para atualizar uma conta existente
});

app.MapDelete("/accounts/{id}", (int id) =>
{
    // Código para deletar uam conta
});




app.Run();
