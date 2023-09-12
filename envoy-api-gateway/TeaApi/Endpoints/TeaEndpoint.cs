namespace TeaApi.Endpoints;

public static class TeaEndpoint
{
    public static void AddTeaEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/tea", () =>
        {
            var tea = new []
            {
                "Green", "Black", "Earl Grey", "English Breakfast", "Camomile"
            };
    
            var rng = new Random();

            return Results.Ok(tea[rng.Next(tea.Length)]);
        });
    }
}