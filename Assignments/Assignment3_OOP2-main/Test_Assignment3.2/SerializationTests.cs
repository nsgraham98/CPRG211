using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment_3_2
{
    /* I know it says to not change this Test class in the assingment doc... 
     * however i believe there are errors in original Test class */
    public class SerializationTests
    {
        /* originally:
         *      private List<User> users;
         * required changing because you cannot Add objects to a null List<User> */
        private List<User> users = new List<User>();

        /* originally:
         *      private readonly string testFileName = "test_users.bin";
         * changed to a TempPath for testing purposes */
        private readonly string testFileName = Path.Combine(Path.GetTempPath(),"test_users.bin");

        [SetUp]
        public void Setup()
        {
            /* orginally
             *      users.Append(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
             *      users.Append(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
             *      etc.
             * required changing .Append to .Add */
            users.Add(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.Add(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.Add(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
        }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        //Tests the object was serialized.
        [Test]
        public void TestSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            Assert.IsTrue(File.Exists(testFileName));
        }

        [Test]
        public void TestDeSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            List<User> deserializedUsers = SerializationHelper.DeserializeUsers(testFileName);
            Assert.AreEqual(users.Count, deserializedUsers.Count);
            for (int i = 0; i < users.Count; i++)
            {
                Assert.AreEqual(users[i].Id, deserializedUsers[i].Id);
                Assert.AreEqual(users[i].Name, deserializedUsers[i].Name);
                Assert.AreEqual(users[i].Email, deserializedUsers[i].Email);
                Assert.AreEqual(users[i].Password, deserializedUsers[i].Password);
            }
        }

    }
}
