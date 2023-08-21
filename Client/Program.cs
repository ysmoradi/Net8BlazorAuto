using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

await Task.WhenAll(builder.Build().RunAsync(), Console.Out.WriteLineAsync("blazor wasm started..."));
