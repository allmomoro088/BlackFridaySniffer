using AutoMapper;
using BlackFridaySniffer.Data;
using BlackFridaySniffer.Models;
using ProductLoader.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLoader.Services.Handlers
{
    public class DefaultProductService : IProductService
    {
        IMapper _mapper;
        IProductRepository _productRepository;

		public DefaultProductService(IMapper mapper, IProductRepository productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public Product CreateProduct(CreateProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            product.Id = Guid.NewGuid().ToString();

            _productRepository.Insert(product);
            return product;
        }

        public Product GetProduct(string id)
        {
            return _productRepository.Read(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.ReadAll();
        }

        public void RemoveProduct(Product product)
        {
            _productRepository.Remove(product);
        }
    }
}
