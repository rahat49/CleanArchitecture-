﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries
{
    public class GetAllProductsQuery:IRequest<IEnumerable<Product>>
    {
        internal class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
        {
            public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var list= new List<Product>();

                for (int i= 0; i<100; i++)
                {
                    var product = new Product();
                    product.Name = "Mobile";
                    product.Description = "Mobile";
                    product.Rate = 100 + i;

                    list.Add(product);

                }

                return list;
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}
