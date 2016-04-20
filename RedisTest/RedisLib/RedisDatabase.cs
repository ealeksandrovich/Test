namespace RedisLib
{
    using StackExchange.Redis;

    public class RedisDatabase
    {
        private readonly RedisConnection connection;
        private readonly int db;

        public RedisDatabase(RedisConnection connection, int db)
        {
            this.connection = connection;
            this.db = db;
        }

        public IDatabase Get()
        {
            return this.connection.GetDatabase(this.db);
        }
    }
}
