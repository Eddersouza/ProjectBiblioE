using ProjectBiblioE.CrossCutting.Helpers;
using ProjectBiblioE.Domain.Contracts.Utils;

using ProjectBlibioE.Tests.Controllers;
using ProjectBlibioE.Tests.IoC;

namespace ProjectBlibioE.Tests
{
    public class GenreTest
    {
        private readonly GenreController _genreController;
        private readonly MessageContract _messageContract;

        public GenreTest()
        {
            CompositionRoot.Wire(new IoCModule());
            _genreController = CompositionRoot.Resolve<GenreController>();
            _messageContract = new MessageBuilder();
        }
    }
}