﻿using System.Web.Http;
using MyOnboardingApp.Contracts.Configuration;
using Unity;

namespace MyOnboardingApp.Api.Utils
{
    public static class UnityContainerExtensions
    {
        public static IUnityContainer RegisterDependency<T>(this IUnityContainer container) where T: IConfiguration, new()
        { // T == DependencyResolverConfig
            var dependency = new T();
            dependency.Register();
            return container;
        }
    }
}
