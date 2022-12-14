using Autofac;
using GildedRoseKata.Models;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GildedRose>().As<IGildedRose>();
            var container = builder.Build();
            container.Resolve<IGildedRose>().Execute();
        }
    }
}
