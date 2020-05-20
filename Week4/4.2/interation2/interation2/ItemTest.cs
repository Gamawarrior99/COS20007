using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Iteration2
{
    [TestFixture()]
    class NUnitItemTest
    {
        Item Sword = new Item(new string[] { "Sword", "Long-Sword" }, "Long-Sword", "A heavy Weapon used to seriously maim the guy who created oop");

        [Test()]
        public void Item_Identifiable()
        {
            Assert.AreEqual(true, Sword.AreYou("Sword"));
        }

        [Test()]
        public void Short_Description()
        {
            //CHECK IF SHORT DESC OF THE ITEM MATCHES ITEMS SHORT DESC
            Assert.AreEqual("Long-Sword A heavy Weapon used to seriously maim the guy who created oop", Sword.ShortDescription);
        }

        [Test()]
        public void Full_Description()
        {
            Assert.AreEqual("A heavy Weapon used to seriously maim the guy who created oop", Sword.FullDescription);
        }
    }
}
