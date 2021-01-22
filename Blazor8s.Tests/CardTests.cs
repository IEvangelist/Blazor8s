using Blazor8s.Shared;
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
        }
    }
}
