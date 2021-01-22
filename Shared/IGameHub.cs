using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor8s.Shared
{
    public interface IGameHub
    {
        Task JoinedGame(Guid playerId);
        
        // TODO: Determine what value "player" stores
        Task PlayerJoined(string player);

        // TODO: Determine why there are two "GameStarted" methods
        Task GameStarted(/*game id*/);
        Task GameStarted(int deckCount, Card discardCard);

        // Who is the hand being added for?
        Task AddHand(List<Card> hand);
        
        // So there is state somewhere, where is Hand stored - it must be persisted somewhere?
        Task AddCardToHand(Card card);
        // Who is discarding a card?
        Task DiscardPlayed(Card card);
        
        // Update deck count does what? Who cares, and why?
        Task UpdateDeckCount(int deckCount);
    }
}