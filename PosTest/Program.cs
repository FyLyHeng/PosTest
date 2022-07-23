using IGPOS.Data.DependencyResolution;
using IGPOS.Infrastructure.APIClient;


Console.WriteLine("Hello, World!");
ServiceRegistration.RegisterServices();
HttpClientProvider.InitializeApisClient();
