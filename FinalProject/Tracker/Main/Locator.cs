using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Models;
using Main.ViewModels;
using Main.Services;

namespace Main
{
    public class Locator
    {

        private static IContainer container;

        public static void Init()
        {
            var builder = new Autofac.ContainerBuilder();
            // ViewModels

            builder.RegisterType<AutorizeViewModel>();
            builder.RegisterType<RegisterViewModel>();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<TipViewModel>();
            builder.RegisterType<AllProgressViewModel>();

            // Services
            builder.RegisterInstance<CurrentUserService>(new CurrentUserService());
            builder.RegisterType<TrackContext>();
            builder.RegisterType<TipService>();
            builder.RegisterType<UserProgressService>();

            container = builder.Build();
        }
        public static T TryGet<T>() => container.Resolve<T>();


    }
}
