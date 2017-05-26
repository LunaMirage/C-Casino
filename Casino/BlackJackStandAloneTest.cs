using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackTests
public class BlackJackStandAloneTest
{
    [TestClass]
    public BlackJackStandAloneTest()
    {

    }

    [TestMethod]
    public void DeckTest()
    {
        var Decky = new Deck();

        Assert.AreEqual(52, Decky.size(), 0.001, "Deck Contains the proper number of cards");

        Decky.deal();
        Assert.AreEqual(48, Decky.size(), 0.001, "Deck Contains the proper number of cards");
    }
};
