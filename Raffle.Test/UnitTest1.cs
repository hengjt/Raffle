﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raffle.Domain;

namespace Raffle.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var user = new User
            {
                Id = 1,
                Name = "Isaque Prestes",
                NickName = "isaquepf",
                Mail = "isaquepf@gmail.com",
                Password = "Shoptime.com",
                Phone = "11958583267",
                ProductId = 1,
                Address = new Address
                {
                    StreetName = "Estrada do Copiúva",
                    Number = 1500,
                    NeighborHood = "Parque Jandaia",
                    City = "Carapicuíba",
                    Complement = "Condominio Solaris",
                    Country = "Brasil",
                    UserId  = 1
                }                
            };

            if(!user.Autenticate("isaquepf", "Shoptime.com"))
                throw new ArgumentException("Login ou Senha são inválidos!");
                //Expirar sessão em 40 minutos


            var product = new Product
            {
                Id = 1,
                Category = "Telefonia",
                Name = "Iphone 6",
                Description = "16GB Dourado iOS",
                Value = 3.499m,
                Images = new List<Image>
                {
                    new Image
                    {
                        Id = 1,
                        Name = "phone.gif",
                        Path = @"~\Imagens/",
                        ProductId = 1
                    }
                }

            };
             
            var raffle = new Domain.Raffle
            {
                Id = 1,
                NumbersOfRaffles = new List<int>
                {
                    50
                },
                Price = 30,
                Product = product
            };


            var raffles = new List<Domain.Raffle>
            {
                raffle
            };
            int numero = 50;


            if (raffles.Sum(p => p.Price) > product.Value)
            {
                numero = 50;
            }
            else
            {
                var sorteio = new Random();                
                
                 numero = sorteio.Next(1, 100);

                if (raffles.Exists(p => p.NumbersOfRaffles.Contains(numero)))
                {
                    numero = sorteio.Next(1, 100); 
                }

            }
            

        }
    }
}
