﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using PokemonReview.DB.Mappings;

namespace PokemonReview.DB
{
    public class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        //SessionFactory initiates the connection between the model layer and the database layer

        public static ISessionFactory SessionFactory => _sessionFactory ??
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString
                (_connectionString))
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CountryMap>())
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
            .BuildSessionFactory();

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        private static string _connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\Desktop\cypherJorney\Phase II\Asp.Net Api\PokemonReviewApp\PokemonDB.mdf;Integrated Security = True; Connect Timeout = 30";
    }
}
