using MongoDB.Driver;

namespace dotnetdemo.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
