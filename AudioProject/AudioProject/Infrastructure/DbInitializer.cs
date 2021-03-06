﻿using AudioProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using AudioProject.Entities.Orders;
using AudioProject.Entities.OrderManagement;

namespace AudioProject.Infrastructure
{
    public static class DbInitializer
    {
        private static AudioProjectContext context;
        public static void Initialize(IServiceProvider serviceProvider, string imagesPath)
        {
            context = (AudioProjectContext)serviceProvider.GetService(typeof(AudioProjectContext));
            InitializeUserRoles();
            InitializeOrderType();
            InitializeOrder();
           

        }

        private static void InitializeOrder()
        {
            var user = context.Find<User>(2);

            if (!context.Orders.Any())
            {
                var order = new Orders() { OrderStatus = OrderStatus.New,
                    UserId = user.Id,

                };
                context.Orders.Add(order);
                context.SaveChanges();

                var orderItem1 = new OrderItems()
                {
                    OrderId = order.Id,
                    CompletionPercent = 10,
                    Description = "Custom description",
                    OrderTypeId = 1,
                    OrderStatus = OrderStatus.New,

                };

                var orderItem2 = new OrderItems()
                {
                    OrderId = order.Id,
                    CompletionPercent = 20,
                    Description = "Custom description",
                    OrderTypeId = 2,
                    OrderStatus = OrderStatus.New,

                };

                context.OrderItems.AddRange(orderItem1, orderItem2);
                context.SaveChanges();

                var orderFile1 = new OrderFiles()
                {
                    FileName = "a.mp3",
                    OrderId = order.Id

                };
                var orderFile2 = new OrderFiles()
                {
                    FileName = "b.mp3",
                    OrderId = order.Id

                };
                context.OrderFiles.AddRange(orderFile1, orderFile2);
                context.SaveChanges();
                }

            }

            private static void InitializeOrderType()
        {
            if (!context.OrderTypeCategorys.Any())
            {
                var orderTypecategory = new Entities.Orders.OrderTypeCategorys()
                {
                    CategoryDescription = "Audio",
                    CategoryName = "Audio",
                    IsActive = true,
                    IsVisible = true,
                    SortOrder = 1,

                };
                context.OrderTypeCategorys.Add(orderTypecategory);
                context.SaveChanges();


                var ordertype1 = new Entities.Orders.OrderTypes()
                {
                    OrderTypeCategoryId = orderTypecategory.Id,
                    IsActive = true,
                    IsVisible = true,
                    OrderTypeDisplayName = "Clean Audio",
                    OrderTypeName = "Clean Audio",
                    Price = 10,
                    PriceFuture = 20,
                    SortOrder = 1
                };
                var ordertype2 = new Entities.Orders.OrderTypes()
                {
                    OrderTypeCategoryId = orderTypecategory.Id,
                    IsActive = true,
                    IsVisible = true,
                    OrderTypeDisplayName = "Audio Mixing",
                    OrderTypeName = "Audio Mixing",
                    Price = 10,
                    PriceFuture = 20,
                    SortOrder = 2
                };
                context.OrderTypes.AddRange(new Entities.Orders.OrderTypes[]
                {
                    ordertype1,ordertype2
                });
               
                context.SaveChanges();

                var ordertypeDescription1 = new OrderTypeDescriptions()
                {
                    Description = "Audio cleaning good",
                    IsActive = true,
                    IsVisible = true,
                    OrderTypeId = ordertype1.Id
                };
                var ordertypeDescription2 = new OrderTypeDescriptions()
                {
                    Description = "Audio cleaning better",
                    IsActive = true,
                    IsVisible = true,
                    OrderTypeId = ordertype1.Id
                };
                var ordertypeDescription3 = new OrderTypeDescriptions()
                {
                    Description = "Audio mixing good",
                    IsActive = true,
                    IsVisible = true,
                    OrderTypeId = ordertype2.Id
                };
                var ordertypeDescription4 = new OrderTypeDescriptions()
                {
                    Description = "Audio mixing better",
                    IsActive = true,
                    IsVisible = true,
                    OrderTypeId = ordertype2.Id
                };
                context.OrderTypeDescriptions.AddRange(new Entities.Orders.OrderTypeDescriptions[]
              {
                    ordertypeDescription1,ordertypeDescription2,ordertypeDescription3,ordertypeDescription4
              });
                context.SaveChanges();
            }
        }

        private static void InitializeUserRoles()
        {
            if (!context.Roles.Any())
            {
                // create roles
                context.Roles.AddRange(new Role[]
                {
                new Role()
                {
                    Name="Admin"
                }
                });

                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.Users.Add(new User()
                {
                    Email = "aa.aa@gmail.com",
                    Username = "aa",
                    HashedPassword = "9wsmLgYM5Gu4zA/BSpxK2GIBEWzqMPKs8wl2WDBzH/4=",
                    Salt = "GTtKxJA6xJuj3ifJtTXn9Q==",
                    IsLocked = false,
                    DateCreated = DateTime.Now
                });

                // create user-admin for chsakell
                context.UserRoles.AddRange(new UserRole[] {
                new UserRole() {
                    RoleId = 1, // admin
                    UserId = 1  // chsakell
                }
            });
                context.SaveChanges();
            }



        
        }
    }
}
