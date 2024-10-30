namespace StackExchange.DataExplorer.Tests
{
    [TestClass]
    public class TestQueryRunner
    {
        [TestMethod]
        public void TestPostLinkShouldNotCrash()
        {
            QueryRunner.GetResults(new ParsedQuery("select top 10 Id as [Post Link] from Posts", null), Current.DB.Sites.First(), new User());
        }
    }
}
