using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            containerBuilder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();

            containerBuilder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            containerBuilder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            containerBuilder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            containerBuilder.RegisterType<EfCarDal>().As<IUserDal>().SingleInstance();

            containerBuilder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
            containerBuilder.RegisterType<EfRentalDal>().As<IRentalDal>().SingleInstance();

            containerBuilder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            containerBuilder.RegisterType<EfColorDal>().As<IColorDal>().SingleInstance();

            containerBuilder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            containerBuilder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            containerBuilder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
