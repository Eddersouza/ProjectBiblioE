using ProjectBiblioE.Domain.Enums;

namespace ProjectBiblioE.Domain.Contracts.Utils
{
    public interface MessageContract
    {
        string MountMessage(MessageBiblioE message, params string[] paramsMessage);
    }
}
