using MongoDB.Driver;

namespace SuggestionSiteBack.DataAccess.Interfaces;

public interface IDbConnection
{
    string DbName { get; }
    string CategoryCollectionName { get; }
    string StatusCollectionName { get; }
    string UserCollectionName { get; }
    string SuggestionCollectionName { get; }
    MongoClient Client { get; }
    IMongoCollection<CategoryModel> CategoryCollection { get; }
    IMongoCollection<StatusModel> StatusCollection { get; }
    IMongoCollection<UserModel> UserCollection { get; }
    IMongoCollection<SuggestionModel> SuggestionCollection { get; }
}