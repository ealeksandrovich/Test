namespace RedisLib
{
    using StackExchange.Redis;

    public class RedisConnection
    {
        private readonly ConnectionMultiplexer connectionMultiplexer;

        public RedisConnection(string configuration)
        {
            ConfigurationOptions options = ConfigurationOptions.Parse(configuration);
            options.ConnectTimeout = 2000;

            this.connectionMultiplexer = ConnectionMultiplexer.Connect(options);
        }

        public IDatabase GetDatabase(int db)
        {
            return this.connectionMultiplexer.GetDatabase(db);
        }
    }
}
