using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Mapping;
using DataAccessLayer.AppDbContext;
using DataAccessLayer.Repository.Abstract;
using DataAccessLayer.Repository.Concrete;
using DataAccessLayer.UnitOfWorks.Absract;
using DataAccessLayer.UnitOfWorks.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace MakalePaneliCore_API.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(Context));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));


            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
