﻿using Ninject.Modules;

using ProjectBiblioE.App;
using ProjectBiblioE.CrossCutting.Helpers;
using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Repository;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Contracts.Utils;
using ProjectBiblioE.Domain.Services;

using ProjectBlibioE.Tests.Mocks;
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

            Bind(typeof(GenreAppContract)).To(typeof(GenreApp));
            Bind(typeof(GenreServiceContract)).To(typeof(GenreService));
            Bind(typeof(GenreRepositoryContract)).To(typeof(GenreRepositoryTests));

            Bind(typeof(MessageContract)).To(typeof(MessageBuilder));
        }
    }
}