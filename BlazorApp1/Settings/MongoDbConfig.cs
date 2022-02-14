namespace BlazorApp1.Settings
{
    public class MongoDbConfig
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }

        public string ConnectionSting => $"mongodb://{Host}:{Port}";

    }
}
