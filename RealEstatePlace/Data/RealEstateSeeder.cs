using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using RealEstatePlace.Data.Entities;
using VotingPoint.Data;

namespace RealEstatePlace.Data
{
    public class RealEstateSeeder
    {
        private readonly RealEstateContext _ctx;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<StoreUser> _userManager;

        public RealEstateSeeder(RealEstateContext ctx, IWebHostEnvironment env, UserManager<StoreUser> userManager)
        {
            _ctx = ctx;
            _env = env;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _ctx.Database.EnsureCreated();

            StoreUser user = await _userManager.FindByEmailAsync("alex@realestate.com");
            if (user == null)
            {
                user = new StoreUser()
                {
                    FirstName = "Alex",
                    LastName = "Alexiev",
                    Email = "alex@realestate.com",
                    UserName = "alex@realestate.com"
                };
                var result = await _userManager.CreateAsync(user, "P@ssw0rd!");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create user!");
                }
            }

            if (!_ctx.Products.Any())
            {
                var filepath = Path.Combine(_env.ContentRootPath, "Data/estates.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);

                _ctx
                    .Products.AddRange(products);

                var order = _ctx.Orders.FirstOrDefault(o => o.Id == 1);

                if (order != null)
                {
                    order.User = user;
                    order.Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        }
                    };
                }

                //var order = new Order()
                //{
                //    OrderDate = DateTime.Today,
                //    OrderNumber = "10000",
                //    Items = new List<OrderItem>()
                //    {
                //        new OrderItem()
                //        {
                //            Product = products.First(),
                //            Quantity = 1,
                //            UnitPrice = products.First().Price
                //        }
                //    }
                //};

                //_ctx.Orders.Add(order);
                _ctx.SaveChanges();
            }
        }
    }
}
