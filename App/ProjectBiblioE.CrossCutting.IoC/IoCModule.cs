using Ninject.Modules;

using ProjectBiblioE.App;
using ProjectBiblioE.Domain.Contracts.App;
using ProjectBiblioE.Domain.Contracts.Services;
using ProjectBiblioE.Domain.Services;

namespace ProjectBiblioE.CrossCutting.IoC
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
        }
    }
}