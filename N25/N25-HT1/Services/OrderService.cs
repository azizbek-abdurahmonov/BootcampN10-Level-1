using N25_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Services
{
    internal class OrderService
    {
        private ProductService _productService;
        private PaymentService _paymentService;

        public OrderService(ProductService service, PaymentService paymentService)
        {
            _productService = service;
            _paymentService = paymentService;

        }

        public bool Order(Guid id, DebitCard card)
        {
            var product = _productService.Order(id);

            if (product is null) return false;

            if (_paymentService.CheckOut(product.Price, card)) return true;

            return false;
        }

        public bool Order(ProductFilterDataModel filterModel, DebitCard card)
        {
            var products = _productService.Get(filterModel);

            if (products.Count == 0) return false;

            if (_paymentService.CheckOut(products.Sum(x => x.Price), card)) return true;

            return false;
        }
    }
}
