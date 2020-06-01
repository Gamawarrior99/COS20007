using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace iteration4
{
    [TestFixture]
    public class NunitTestsLook
    {
        Look_Command look;
        Player newplayer;
        Bag bag1;
        Item gem;

        [SetUp]
        public void SetUp()
        {


            newplayer = new Player("Gam", "The big man");
            bag1 = new Bag(new string[] { "bag", "bags" }, "Bag", "Stores All your Items");



            look = new Look_Command(new string[] { "look" });
            gem = new Item(new string[] { "gem" }, "a gem", "a big gem");

        }

        [Test]
        public void Look_At_Gem()
        {
            newplayer.inventory.Put(gem);
            Assert.AreEqual("a big gem", look.Exe(newplayer, new string[] { "look", "at", "gem", "in", "inventory" }));
        }

        [Test]
        public void Look_At_Gem_In_Me()
        {
            newplayer.inventory.Put(gem);
            Assert.AreEqual("a big gem", look.Exe(newplayer, new string[] { "look", "at", "gem", "in", "inventory" }));
        }

        [Test]
        public void Look_At_Me()
        {
            newplayer.inventory.Put(bag1);

            Assert.AreEqual("You are Gam. The big man.", look.Exe(newplayer, new string[] { "look", "at", "inventory" }));

        }

        [Test]
        public void Look_At_Unk()
        {

            Assert.AreEqual("I cannot find gem in the iteration4.Player", look.Exe(newplayer, new string[] { "look", "at", "gem" }));
        }

        [Test]
        public void Look_At_Gem_In_Bag()
        {
            newplayer.inventory.Put(bag1);
            bag1.Inventory.Put(gem);

            Assert.AreEqual("a big gem", look.Exe(newplayer, new string[] { "look", "at", "gem", "in", "bag" }));
        }

        [Test]
        public void Look_At_No_Gem_In_Bag()
        {
            newplayer.inventory.Put(bag1);

            Assert.AreEqual("I cannot find gem in the iteration4.Bag", look.Exe(newplayer, new string[] { "look", "at", "gem", "in", "bag" }));
        }

        [Test]
        public void Look_At_Gem_In_No_Bag()
        {


            Assert.AreEqual("Cannot find the bag", look.Exe(newplayer, new string[] { "look", "at", "gem", "in", "bag" }));
        }

        [Test]
        public void Invalid_Look()
        {
            Assert.AreEqual("I don't know how to look like that", look.Exe(newplayer, new string[] { "look", "test" }));
            Assert.AreEqual("Error in look input", look.Exe(newplayer, new string[] { "test", "at", "gem" }));
            Assert.AreEqual("What do you want to look at?", look.Exe(newplayer, new string[] { "look", "test", "gem" }));
            Assert.AreEqual("What do you want to look in?", look.Exe(newplayer, new string[] { "look", "at", "gem", "test", "bag" }));
        }

    }
}
