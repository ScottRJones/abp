﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Volo.Abp.SettingManagement.MongoDB
{
    [DependsOn(
        typeof(AbpSettingManagementDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class AbpSettingManagementMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            AbpSettingManagementBsonClassMap.Configure();

            context.Services.AddMongoDbContext<SettingManagementMongoDbContext>(options =>
            {
                options.AddDefaultRepositories<ISettingManagementMongoDbContext>();

                options.AddRepository<Setting, MongoSettingRepository>();
            });

            context.Services.AddAssemblyOf<AbpSettingManagementMongoDbModule>();
        }
    }
}
