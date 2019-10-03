using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transacao_cartao_api.Entities;

namespace transacao_cartao_api.Services
{
    public interface ICardService
    {
        IEnumerable<Card> GetAll();
    }
    public class CardService : ICardService
    {
        private IEnumerable<Card> v_CardList = new List<Card>
        {
            new Card {
                Id = 1,
                Brand = "Mastercard",
                CardHolderName = "José Milionário",
                CustomerId = 1,
                ExpirationMonth = 12,
                ExpirationYear = 2030,
                SecurityCode = 123
            }
        };

        public IEnumerable<Card> GetAll()
        {
            return v_CardList;
        }
    }
}
