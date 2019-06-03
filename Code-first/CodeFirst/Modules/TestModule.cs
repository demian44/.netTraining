using System;
using Autofac;
using CodeFirst.Models;

namespace Code_first.Modules
{
    public class TestModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(x => new Test(Guid.NewGuid())).As<ITest>();
        }
    }
}