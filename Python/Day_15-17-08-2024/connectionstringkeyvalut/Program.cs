
using Azure.Identity;

namespace connectionstringkeyvalut
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var keyVaultName = builder.Configuration["AzureKeyVault:Vault"];
            if (!string.IsNullOrEmpty(keyVaultName))
            {
                var kvUri = new Uri($"https://{keyVaultName}.vault.azure.net/");
                builder.Configuration.AddAzureKeyVault(kvUri, new DefaultAzureCredential());
            }
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
