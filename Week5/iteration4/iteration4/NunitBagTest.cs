using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace iteration4
{
    [TestFixture]
    class NUnitBagTest
    {
        Player Player1;
        Inventory inv = new Inventory();
        Item Sword;
        Item Bow;
        Item PC;
        Bag bag;
        Bag sBag;

        [SetUp]
        public void SetUp()
        {
            Player1 = new Player("Frodo", "Inventory");
            Sword = new Item(new string[] { "Sword", "Long-Sword" }, "A Long-Sword ", "A heavy Weapon used to seriously maim the guy who created oop");
            Bow = new Item(new string[] { "Bow", "Long-Bow" }, "A long-Bow ", "a Ranged Weapon used to seriously maim the guy who created oop ");
            PC = new Item(new string[] { "pc", "Personal Computer" }, "Persoal Computing devices ", "A tool Used by OOP devs to torture UNI Students");
            bag = new Bag(new string[] { "bag", "bags" }, "Bag", "Stores All your Items");
            sBag = new Bag(new string[] { "sBag", "sBags" }, "sBag", "Stores All your small Items");
        }
        [Test]
        public void TestLocatesItself()
        {
            Assert.That(bag.AreYou("bag"), Is.True);
        }
        [Test]
        public void LocateItems()
        {
            bag.Inventory.Put(Sword);
            Assert.AreEqual(Sword, bag.Locate("Sword"));
        }
        [Test]
        public void Bag1locatesBag2()
        {
            bag.Inventory.Put(sBag);
            Assert.AreEqual(sBag, bag.Locate("sBag"));
        }
        [Test]
        public void LocateNothing()
        {
            Assert.AreEqual(null, bag.Locate("Sword"));
        }
        [Test]
        public void FullDescription()
        {
            bag.Inventory.Put(Sword);
            Assert.AreEqual("Your trusty bag that you take everywhere\n The item you currently have is :\n A Long-Sword  A heavy Weapon used to seriously maim the guy who created oop\n", bag.FullDescription);
            ;
        }
    }
}
