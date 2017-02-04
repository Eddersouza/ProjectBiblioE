using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBiblioE.CrossCutting.IoC
{
    /// <summary>
    /// Composition class to injection
    /// </summary>
    public class CompositionRoot
    {
        /// <summary>
        /// Instance of kernel
        /// </summary>
        private static IKernel _ninjectKernel;



        /// <summary>
        /// Resolve injection
        /// </summary>
        /// <typeparam name="TEntity">Class entiti to resolve</typeparam>
        /// <returns>Class with injection</returns>
        public static TEntity Resolve<TEntity>()
        {
            return _ninjectKernel.Get<TEntity>();
        }

        /// <summary>
        /// Link model
        /// </summary>
        /// <param name="module">Object with instance</param>
        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

    }
}
