using Core.Entities;

namespace Core.interfaces
{
    public interface ITokenProvider
    {
        public string creatToken(User user);
    }
}
