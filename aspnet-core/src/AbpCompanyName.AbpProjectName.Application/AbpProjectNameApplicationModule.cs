﻿using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCompanyName.AbpProjectName.Authorization;

namespace AbpCompanyName.AbpProjectName
{
    [DependsOn(
        typeof(AbpProjectNameCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpProjectNameApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpProjectNameAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpProjectNameApplicationModule).GetAssembly());
        }
    }
}