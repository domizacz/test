namespace testownlog.Settings
{
    public class MongoDbConfig
    {
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; init; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Host' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Host { get; init; }
#pragma warning restore CS8618 // Non-nullable property 'Host' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}
