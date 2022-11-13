using Singleton;

//var cfg = new Configuration();

var cfg = Configuration.GetConfiguration();
var cfg2 = Configuration.GetConfiguration();

if (ReferenceEquals(cfg, cfg2))
{
    Console.WriteLine("Configuration is a singleton");
}