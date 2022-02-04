using System;
using Autofac;
using RestApiForOnlineStores.Database.Contexts;
using RestApiForOnlineStores.Database.Orders.Repositories;
using RestApiForOnlineStores.Database.Orders.Repositories.Interfaces;
using RestApiForOnlineStores.Database.Postamates.Repositories;
using RestApiForOnlineStores.Database.Postamates.Repositories.Interfaces;
using RestApiForOnlineStores.Domain.Orders.Services;
using RestApiForOnlineStores.Domain.Orders.Services.Interfaces;
using RestApiForOnlineStores.Domain.Postamates.Services;
using RestApiForOnlineStores.Domain.Postamates.Services.Interfaces;


namespace RestApiForOnlineStores.IoC
{
    public static class IoCContainer
    {
        private const string ConnectionStringKey = "RestApiForOnlineStoresConnectionString";

        private static readonly string RestApiForOnlineStoresConnectionString =
            Environment.GetEnvironmentVariable(ConnectionStringKey);

        public static void InitContainer(ContainerBuilder container)
        {
            PostgreSqlContext postgreSqlContext = new PostgreSqlContext(RestApiForOnlineStoresConnectionString);
            container.RegisterInstance(postgreSqlContext).As<SqlDbContext>().SingleInstance();
            container.RegisterType<OrdersRepository>().As<IOrdersRepository>().SingleInstance();
            container.RegisterType<PostamatesRepository>().As<IPostamatesRepository>().SingleInstance();
            container.RegisterType<PostamatesService>().As<IPostamatesService>().SingleInstance();
            container.RegisterType<ValidationOrderService>().SingleInstance();
            container.RegisterType<OrdersService>().As<IOrdersService>().SingleInstance();
        }
    }
}