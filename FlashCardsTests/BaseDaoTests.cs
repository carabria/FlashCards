using System.Data.SqlClient;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlashCards.testDAO
{
    [TestClass]
    public class BaseDaoTests
    {
        private const string AdminConnectionString = @"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        protected const string connectionString = @"Server=.\SQLEXPRESS;Database=FlashCardsTest;Trusted_Connection=True;";

        private TransactionScope transaction;
        [AssemblyInitialize]
        public static void BeforeAllTests(TestContext context)
        {
            string sql = File.ReadAllText("TestCreate.sql");
            using (SqlConnection conn = new SqlConnection(AdminConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            sql = File.ReadAllText("TestData.sql");
            using (SqlConnection conn = new SqlConnection(AdminConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        [AssemblyCleanup]
        public static void AfterAllTests()
        {
            string sql = File.ReadAllText("TestDrop.sql");
            using (SqlConnection conn = new SqlConnection(AdminConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        [TestInitialize]
        public virtual void Setup()
        {
            transaction = new TransactionScope();
        }

        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }
    }
}
