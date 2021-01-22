using Blazor8s.Shared;
using System.Linq;
using Xunit;

namespace Blazor8s.Tests
{
    public class CardTests
    {
        [Fact]
        public void CanCreateShuffledDeck()
        {
            var deck = CardUtilities.GetShuffledDeck();
            Assert.Equal(52, deck.Count);
            Assert.Equal(52, deck.Distinct().Count());
        }
    }
}
