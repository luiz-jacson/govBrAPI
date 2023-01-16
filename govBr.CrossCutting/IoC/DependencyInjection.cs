using Autofac;
using govBr.Infra.IServices;
using govBr.Infra.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace govBr.CrossCutting.IoC
{
    public class DependencyInjection
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoginService>().As<ILoginService>();
        }
    }
}
