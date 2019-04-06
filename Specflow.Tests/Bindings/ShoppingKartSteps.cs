using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingKart;
using System.Linq;
using TechTalk.SpecFlow;

namespace Specflow.Tests
{
    [Binding]
    public class ShoppingKartSteps
    {
        Basket basket;
        Product item;
        [Given(@"I start shopping")]
        public void GivenIStartShopping()
        {
            basket = new Basket();
        }

        [When(@"I add new product")]
        public void WhenIAddNewProduct()
        {
            item = new Product();
            basket.Add(item);
        }

        [When(@"there is an item")]
        public void WhenThereIsAnItem()
        {
            basket.Remove(item);
        }

        [Then(@"the shopping kart should not be empty")]
        public void ThenTheShoppingKartShouldNotBeEmpty()
        {
            Assert.AreEqual(1, basket.Items.Count());
        }

        [Then(@"the shopping kart should be empty")]
        public void ThenTheShoppingKartShouldBeEmpty()
        {
            Assert.AreEqual(0, basket.Items.Count());
        }
    }
}
