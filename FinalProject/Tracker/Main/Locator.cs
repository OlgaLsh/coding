using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Models;
using Main.ViewModels;

namespace Main
{
    public class Locator
    {

        private static IContainer container;

        public static void Init()
        {
            var builder = new Autofac.ContainerBuilder();

            builder.RegisterType<AutorizeViewModel>();

            builder.RegisterType<TrackContext>();

            container = builder.Build();
        }



    }
}
