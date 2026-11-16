using Autofac;

namespace WinFormsApp1
{
    public static class Bootstrapper
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Регистрируем наши заглушки (Stub) под их интерфейсами
            builder.RegisterType<MaterialRepositoryStub>().As<IMaterialRepository>().SingleInstance();
            builder.RegisterType<ProductRepositoryStub>().As<IProductRepository>().SingleInstance();
            builder.RegisterType<NormaRashodovRepositoryStub>().As<INormaRashodovRepository>().SingleInstance();
            builder.RegisterType<SkladOperationRepositoryStub>().As<ISkladOperationRepository>().SingleInstance();
            builder.RegisterType<ZaavkaNaZakupkyRepositoryStub>().As<IZaavkaNaZakupkyRepository>().SingleInstance();

            builder.RegisterType<MainForm>().AsSelf();
           
            return builder.Build();
        }
    }
}