using Autofac;
using govBr.Infra;
using govBr.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace govBr.CrossCutting.IoC
{
    public class DependencyInjection
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthorizeService>().As<IAuthorizeService>();
        }
    }
}
