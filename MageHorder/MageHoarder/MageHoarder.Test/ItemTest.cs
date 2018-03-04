using MageHoarder.BLL.Weapons;
using MageHoarder.BLL.Containers;
using NUnit.Framework;
using MageHoarder.BLL.Potions;

namespace MageHoarder.Test
{
    [TestFixture]
    class ItemTest
    {
        [Test]
        public void CanAddCrossbowToBackpack()
        {
            Backpack bp = new Backpack("Small Backpack", 3, 4);
            Crossbow bow = new Crossbow("Terrible Crossbow", 3, 4);
            bool expected = true;
            bool actual = bp.Add(bow);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CannotAddThreeCrossbowToBackpack()
        {
            Backpack bp = new Backpack("Small Backpack", 3, 4);
            Crossbow bow = new Crossbow("Terrible Crossbow", 3, 4);
            Crossbow tooBig = new Crossbow("Terrible Crossbow", 3, 4);
            bool expected = false;

            bp.Add(bow);
            bool actual = bp.Add(tooBig);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CanAddPotion()
        {
            PotionPack pp = new PotionPack("Small potion sack", 2, 4);
            ManaPotion mana = new ManaPotion("Small Mana Potion", 1);
            bool expected = true;
            bool actual = pp.Add(mana);
            Assert.AreEqual(expected, actual);
           
        }

        [Test]
        public void CannotAddGiantManaPotion()
        {
            PotionPack pp = new PotionPack("Small potion sack", 2, 4);
            ManaPotion mana = new ManaPotion("GIANT Mana Potion", 10);
            bool expected = false;
            bool actual = pp.Add(mana);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CannotPutCrossbowInPotionPack()
        {
            PotionPack pp = new PotionPack("Small potion sack", 2, 4);
            Crossbow bow = new Crossbow("Crossbow of the Hawk", 2, 10);
            bool expected = false;
            bool actual = pp.Add(bow);
            Assert.AreEqual(expected, actual);
        }
    }
}
