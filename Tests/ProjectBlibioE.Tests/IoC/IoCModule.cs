﻿using Ninject.Modules;

using ProjectBiblioE.App;
using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Services;

using ProjectBlibioE.Tests.Repository;

namespace ProjectBlibioE.Tests.IoC
{
    public class IoCModule : NinjectModule
    {
        /// <summary>
        /// Load method to injection.
        /// </summary>
        public override void Load()
        {
            Bind(typeof(LanguageAppContract)).To(typeof(LanguageApp));
            Bind(typeof(LanguageServiceContract)).To(typeof(LanguageService));
            Bind(typeof(LanguageRepositoryContract)).To(typeof(LanguageRepositoryTests));
        }
    }
}