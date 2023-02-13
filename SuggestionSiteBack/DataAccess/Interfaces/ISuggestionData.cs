namespace SuggestionSiteBack.DataAccess.Interfaces;

public interface ISuggestionData
{
    Task<List<SuggestionModel>> GetUsersSuggestions(string userId);
    Task CreateSuggestions(SuggestionModel suggestion);
    Task<List<SuggestionModel>> GetAllApprovedSuggestion(); 
    Task<List<SuggestionModel>> GetAllSuggestions();
    Task<List<SuggestionModel>> GetAllSuggestionsWaitingForApproval();
    Task<SuggestionModel> GetSuggestion(string id);
    Task UpdateSuggestion(SuggestionModel suggestion);
    Task UpvoteSuggestion(string suggestionId, string userId);
}