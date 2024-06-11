var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

// Question 1: AddTen
app.MapGet("/api/AddTen/{id:int}", (int id) =>
{
    return $"{id + 10}";
});

// Question 2: Square
app.MapGet("/api/Square/{id:int}", (int id) =>
{
    return $"{id * id}";
});

// Question 3: Greeting
app.MapPost("/api/Greeting", () =>
{
    return "Hello World!";
});

// Question 4: Greeting with id
app.MapGet("/api/Greeting/{id:int}", (int id) =>
{
    return $"Greetings to {id} people!";
});

// Question 5: NumberMachine
app.MapGet("/api/NumberMachine/{id:int}", (int id) =>
{
    // Applying four mathematical operations
    int result = ((id + 5) * 2) / 3 - 7;
    return $"{result}";
});

// Question 6: HostingCost
app.MapGet("/api/HostingCost/{id:int}", (int id) =>
{
    // Calculate the number of fortnights
    int numberOfFortnights = (id / 14) + 1;

    // Calculate the hosting cost for the given number of fortnights
    double hostingCost = numberOfFortnights * 5.50;

    // Calculate the HST (13%)
    double hst = hostingCost * 0.13;

    // Calculate the total cost including HST
    double totalCost = hostingCost + hst;

    // Prepare the response strings
    string fortnightsString = $"{numberOfFortnights} fortnights at $5.50/FN = ${hostingCost.ToString("0.00")} CAD";
    string hstString = $"HST 13% = ${hst.ToString("0.00")} CAD";
    string totalString = $"Total = ${totalCost.ToString("0.00")} CAD";

    // Return the response as an array of strings
    return new string[] { fortnightsString, hstString, totalString };
});

app.Run();
