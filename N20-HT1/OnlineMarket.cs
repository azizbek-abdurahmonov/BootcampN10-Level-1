using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal class OnlineMarket
    {
        private readonly IPaymentProvider _provider;
        private readonly IDebitCard _debitCard;
        private List<Product> _products;

        public OnlineMarket(IPaymentProvider provider, IDebitCard MarketCard)
        {
            _provider = provider;
            _debitCard = MarketCard;
            _products = new List<Product>();
        }


        //methods
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public bool Buy(string name, int number, IDebitCard card)
        {
            foreach (var product in _products)
            {
                if (product.Name == name)
                {
                    var price = product.Price * number;
                    return _provider.Transfer(sourceCard: card, destinationCard: _debitCard, amount: price);
                }
            }
            return false;
        }
    }
}
