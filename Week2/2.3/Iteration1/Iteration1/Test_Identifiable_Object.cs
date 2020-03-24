using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Iteration1
{
    [TestFixture]
    public class Test_Identifiable_Object //Rename this appropriately.    
    {
        private Identifiable_Object _id;
 
        [SetUp]
        public void SetUp()
        {
            _id = new Identifiable_Object(new string[] { "id1", "id2" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.AreEqual(true, _id.AreYou("id1"), "id1 should Exist");
        }

        [Test]
        public void TestAreYouNot()
        {
            Assert.AreEqual(false, _id.AreYou("id3"), "id3 should not Exist");
        }

        [Test]
        public void TestAreYouCaseSensative()
        {
            Assert.AreEqual(true, _id.AreYou("Id1"), "id1 should Exist");
        }

        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual("id1", _id.FirstId(), "id1 should be First ID");
        }

        [Test]
        public void TestAddID()
        {
            _id.Add_Identifier("id3");
            Assert.AreEqual(true, _id.AreYou("Id3"), "id3 should now  Exist");
        }
    }


  
}

