namespace RedisTest
{
    using NUnit.Framework;
    using RedisLib;
    using StackExchange.Redis;

    [TestFixture]
    public class Test
    {
        private readonly IDatabase database;

        public Test()
        {
            var redisDatabase = new RedisDatabase(new RedisConnection("52.36.99.52"), 0);
            this.database = redisDatabase.Get();
        }

        [Test]
        public void SetTest()
        {

            var result = this.database.StringSet("testKey", "testValue");

            Assert.IsTrue(result);
        }

        [Test]
        public void GetTest()
        {
            var value = this.database.StringGet("testKey");

            Assert.AreEqual("testValue", value.ToString());
        }
    }
}
