namespace CoffeeApi.Endpoints;

public static class CoffeeEndpoint
{
    public static void AddCoffeeEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/coffee", () =>
        {
            var coffees = new []
            {
                "Flat White", "Long Black", "Latte", "Americano", "Cappuccino"
            };
    
            var rng = new Random();

            return Results.Ok(coffees[rng.Next(coffees.Length)]);
        });
    }
}