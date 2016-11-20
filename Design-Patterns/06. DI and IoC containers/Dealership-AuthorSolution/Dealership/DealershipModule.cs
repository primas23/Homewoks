using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common;
using Dealership.Contracts;
using Dealership.Engine;
using Dealership.Factories;
using Dealership.Models;
using Ninject.Modules;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;

namespace Dealership
{
    public class DealershipModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                    .SelectAllClasses()
                    .BindDefaultInterface();
            });

            Bind<IEngine>().To<DealershipEngine>().InSingletonScope();

            Bind<IDealershipFactory>().ToFactory().InSingletonScope();

            Bind<IVehicle>().To<Car>().Named(Constants.CarName);
            Bind<IVehicle>().To<Motorcycle>().Named(Constants.MotorcycleName);
            Bind<IVehicle>().To<Truck>().Named(Constants.TruckName);


        }
    }
}
