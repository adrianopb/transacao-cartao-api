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
               UserId = 1,
               ExpirationMonth = 12,
               ExpirationYear = 2030,
               SecurityCode = 123
            },
            new Card {
                Id = 2,
                Brand = "Visa",
                CardHolderName = "Henrique Rocha",
                UserId = 2,
                ExpirationMonth = 12,
                ExpirationYear = 2031,
                SecurityCode = 124
            },
            new Card {
                Id = 3,
                Brand = "ELO",
                CardHolderName = "Rafael Passos",
                UserId = 3,
                ExpirationMonth = 12,
                ExpirationYear = 2036,
                SecurityCode = 824
            }
        };

        public IEnumerable<Card> GetAll()
        {
            return v_CardList;
        }
    }
}
