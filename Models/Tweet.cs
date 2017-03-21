using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{        public class Tweet
        {   [Required]            
            public string TweetHashTag { get; set; }
            public string Message { get; set; }
            public string Author { get; set; }
            public string AuthorPic { get; set; }
            public string TimePosted { get; set; }
            public int RetweetCount { get; set; }
            public int LikesCount { get; set; }
        }

    public class ExtendedTweet
    {
        public int Type { get; set; }
        public int ID { get; set; }
        public int UserID { get; set; }
        public object ScreenName { get; set; }
        public int SinceID { get; set; }
        public int MaxID { get; set; }
        public int Count { get; set; }
        public int Cursor { get; set; }
        public bool IncludeRetweets { get; set; }
        public bool ExcludeReplies { get; set; }
        public bool IncludeEntities { get; set; }
        public bool IncludeUserEntities { get; set; }
        public bool IncludeMyRetweet { get; set; }
        public object OEmbedUrl { get; set; }
        public int OEmbedMaxWidth { get; set; }
        public bool OEmbedHideMedia { get; set; }
        public bool OEmbedHideThread { get; set; }
        public bool OEmbedOmitScript { get; set; }
        public int OEmbedAlign { get; set; }
        public object OEmbedRelated { get; set; }
        public object OEmbedLanguage { get; set; }
        public string CreatedAt { get; set; }
        public int StatusID { get; set; }
        public object Text { get; set; }
        public object FullText { get; set; }
        //  public object ExtendedTweet { get; set; }
        public object Source { get; set; }
        public bool Truncated { get; set; }
        public object DisplayTextRange { get; set; }
        public int TweetMode { get; set; }
        public int InReplyToStatusID { get; set; }
        public int InReplyToUserID { get; set; }
        public object FavoriteCount { get; set; }
        public bool Favorited { get; set; }
        public object InReplyToScreenName { get; set; }
        public object User { get; set; }
        public object Users { get; set; }
        public object Contributors { get; set; }
        public object Coordinates { get; set; }
        public object Place { get; set; }
        public object Annotation { get; set; }
        public object Entities { get; set; }
        public object ExtendedEntities { get; set; }
        public bool TrimUser { get; set; }
        public bool IncludeContributorDetails { get; set; }
        public int RetweetCount { get; set; }
        public bool Retweeted { get; set; }
        public bool PossiblySensitive { get; set; }
        public object RetweetedStatus { get; set; }
        public int CurrentUserRetweet { get; set; }
        public bool IsQuotedStatus { get; set; }
        public int QuotedStatusID { get; set; }
        public object QuotedStatus { get; set; }
        public object Scopes { get; set; }
        public bool WithheldCopyright { get; set; }
        public object WithheldInCountries { get; set; }
        public object WithheldScope { get; set; }
        public object MetaData { get; set; }
        public object Lang { get; set; }
        public bool Map { get; set; }
        public object TweetIDs { get; set; }
        public int FilterLevel { get; set; }
        public object EmbeddedStatus { get; set; }
        public object CursorMovement { get; set; }
    }

    public class CursorMovement
    {
        public int Next { get; set; }
        public int Previous { get; set; }
    }

    public class Status2
    {
        public int Type { get; set; }
        public int ID { get; set; }
        public int UserID { get; set; }
        public object ScreenName { get; set; }
        public int SinceID { get; set; }
        public int MaxID { get; set; }
        public int Count { get; set; }
        public int Cursor { get; set; }
        public bool IncludeRetweets { get; set; }
        public bool ExcludeReplies { get; set; }
        public bool IncludeEntities { get; set; }
        public bool IncludeUserEntities { get; set; }
        public bool IncludeMyRetweet { get; set; }
        public object OEmbedUrl { get; set; }
        public int OEmbedMaxWidth { get; set; }
        public bool OEmbedHideMedia { get; set; }
        public bool OEmbedHideThread { get; set; }
        public bool OEmbedOmitScript { get; set; }
        public int OEmbedAlign { get; set; }
        public object OEmbedRelated { get; set; }
        public object OEmbedLanguage { get; set; }
        public string CreatedAt { get; set; }
        public int StatusID { get; set; }
        public object Text { get; set; }
        public object FullText { get; set; }
        public object ExtendedTweet { get; set; }
        public object Source { get; set; }
        public bool Truncated { get; set; }
        public object DisplayTextRange { get; set; }
        public int TweetMode { get; set; }
        public int InReplyToStatusID { get; set; }
        public int InReplyToUserID { get; set; }
        public object FavoriteCount { get; set; }
        public bool Favorited { get; set; }
        public object InReplyToScreenName { get; set; }
        public object User { get; set; }
        public object Users { get; set; }
        public object Contributors { get; set; }
        public object Coordinates { get; set; }
        public object Place { get; set; }
        public object Annotation { get; set; }
        public object Entities { get; set; }
        public object ExtendedEntities { get; set; }
        public bool TrimUser { get; set; }
        public bool IncludeContributorDetails { get; set; }
        public int RetweetCount { get; set; }
        public bool Retweeted { get; set; }
        public bool PossiblySensitive { get; set; }
        public object RetweetedStatus { get; set; }
        public int CurrentUserRetweet { get; set; }
        public bool IsQuotedStatus { get; set; }
        public int QuotedStatusID { get; set; }
        public object QuotedStatus { get; set; }
        public object Scopes { get; set; }
        public bool WithheldCopyright { get; set; }
        public object WithheldInCountries { get; set; }
        public object WithheldScope { get; set; }
        public object MetaData { get; set; }
        public object Lang { get; set; }
        public bool Map { get; set; }
        public object TweetIDs { get; set; }
        public int FilterLevel { get; set; }
        public object EmbeddedStatus { get; set; }
        public object CursorMovement { get; set; }
    }

    public class User
    {
        public int Type { get; set; }
        public int UserID { get; set; }
        public object UserIdList { get; set; }
        public object ScreenName { get; set; }
        public object ScreenNameList { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
        public int Cursor { get; set; }
        public object Slug { get; set; }
        public object Query { get; set; }
        public bool IncludeEntities { get; set; }
        public bool SkipStatus { get; set; }
        public string UserIDResponse { get; set; }
        public string ScreenNameResponse { get; set; }
        public int ImageSize { get; set; }
        public CursorMovement CursorMovement { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ProfileImageUrl { get; set; }
        public string ProfileImageUrlHttps { get; set; }
        public bool DefaultProfileImage { get; set; }
        public string Url { get; set; }
        public bool DefaultProfile { get; set; }
        public bool Protected { get; set; }
        public int FollowersCount { get; set; }
        public string ProfileBackgroundColor { get; set; }
        public string ProfileTextColor { get; set; }
        public string ProfileLinkColor { get; set; }
        public string ProfileSidebarFillColor { get; set; }
        public string ProfileSidebarBorderColor { get; set; }
        public int FriendsCount { get; set; }
        public string CreatedAt { get; set; }
        public int FavoritesCount { get; set; }
        public int UtcOffset { get; set; }
        public string TimeZone { get; set; }
        public string ProfileBackgroundImageUrl { get; set; }
        public string ProfileBackgroundImageUrlHttps { get; set; }
        public bool ProfileBackgroundTile { get; set; }
        public bool ProfileUseBackgroundImage { get; set; }
        public int StatusesCount { get; set; }
        public bool Notifications { get; set; }
        public bool GeoEnabled { get; set; }
        public bool Verified { get; set; }
        public bool ContributorsEnabled { get; set; }
        public bool IsTranslator { get; set; }
        public bool Following { get; set; }
        public Status2 Status { get; set; }
        public List<object> Categories { get; set; }
        public object Lang { get; set; }
        public string LangResponse { get; set; }
        public bool ShowAllInlineMedia { get; set; }
        public int ListedCount { get; set; }
        public bool FollowRequestSent { get; set; }
        public object ProfileImage { get; set; }
        public string ProfileBannerUrl { get; set; }
        public List<object> BannerSizes { get; set; }
        public object Email { get; set; }
    }

    public class Coordinates
    {
        public object Type { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsLocationAvailable { get; set; }
    }

    public class Place
    {
        public object Name { get; set; }
        public object CountryCode { get; set; }
        public object ID { get; set; }
        public object Country { get; set; }
        public object PlaceType { get; set; }
        public object Url { get; set; }
        public object FullName { get; set; }
        public object Attributes { get; set; }
        public object BoundingBox { get; set; }
        public object Geometry { get; set; }
        public object PolyLines { get; set; }
        public object ContainedWithin { get; set; }
    }

    public class Attributes
    {
    }

    public class Elements
    {
    }

    public class Annotation
    {
        public object Type { get; set; }
        public Attributes Attributes { get; set; }
        public Elements Elements { get; set; }
    }

    public class Entities
    {
        public List<object> UserMentionEntities { get; set; }
        public List<object> UrlEntities { get; set; }
        public List<object> HashTagEntities { get; set; }
        public List<object> MediaEntities { get; set; }
        public List<object> SymbolEntities { get; set; }
    }

    public class ExtendedEntities
    {
        public List<object> UserMentionEntities { get; set; }
        public List<object> UrlEntities { get; set; }
        public List<object> HashTagEntities { get; set; }
        public List<object> MediaEntities { get; set; }
        public List<object> SymbolEntities { get; set; }
    }

    public class RetweetedStatus
    {
        public int Type { get; set; }
        public int ID { get; set; }
        public int UserID { get; set; }
        public object ScreenName { get; set; }
        public int SinceID { get; set; }
        public int MaxID { get; set; }
        public int Count { get; set; }
        public int Cursor { get; set; }
        public bool IncludeRetweets { get; set; }
        public bool ExcludeReplies { get; set; }
        public bool IncludeEntities { get; set; }
        public bool IncludeUserEntities { get; set; }
        public bool IncludeMyRetweet { get; set; }
        public object OEmbedUrl { get; set; }
        public int OEmbedMaxWidth { get; set; }
        public bool OEmbedHideMedia { get; set; }
        public bool OEmbedHideThread { get; set; }
        public bool OEmbedOmitScript { get; set; }
        public int OEmbedAlign { get; set; }
        public object OEmbedRelated { get; set; }
        public object OEmbedLanguage { get; set; }
        public string CreatedAt { get; set; }
        public int StatusID { get; set; }
        public object Text { get; set; }
        public object FullText { get; set; }
        public object ExtendedTweet { get; set; }
        public object Source { get; set; }
        public bool Truncated { get; set; }
        public object DisplayTextRange { get; set; }
        public int TweetMode { get; set; }
        public int InReplyToStatusID { get; set; }
        public int InReplyToUserID { get; set; }
        public object FavoriteCount { get; set; }
        public bool Favorited { get; set; }
        public object InReplyToScreenName { get; set; }
        public object User { get; set; }
        public object Users { get; set; }
        public object Contributors { get; set; }
        public object Coordinates { get; set; }
        public object Place { get; set; }
        public object Annotation { get; set; }
        public object Entities { get; set; }
        public object ExtendedEntities { get; set; }
        public bool TrimUser { get; set; }
        public bool IncludeContributorDetails { get; set; }
        public int RetweetCount { get; set; }
        public bool Retweeted { get; set; }
        public bool PossiblySensitive { get; set; }
        //public object RetweetedStatus { get; set; }
        public int CurrentUserRetweet { get; set; }
        public bool IsQuotedStatus { get; set; }
        public int QuotedStatusID { get; set; }
        public object QuotedStatus { get; set; }
        public object Scopes { get; set; }
        public bool WithheldCopyright { get; set; }
        public object WithheldInCountries { get; set; }
        public object WithheldScope { get; set; }
        public object MetaData { get; set; }
        public object Lang { get; set; }
        public bool Map { get; set; }
        public object TweetIDs { get; set; }
        public int FilterLevel { get; set; }
        public object EmbeddedStatus { get; set; }
        public object CursorMovement { get; set; }
    }

    public class QuotedStatus
    {
        public int Type { get; set; }
        public int ID { get; set; }
        public int UserID { get; set; }
        public object ScreenName { get; set; }
        public int SinceID { get; set; }
        public int MaxID { get; set; }
        public int Count { get; set; }
        public int Cursor { get; set; }
        public bool IncludeRetweets { get; set; }
        public bool ExcludeReplies { get; set; }
        public bool IncludeEntities { get; set; }
        public bool IncludeUserEntities { get; set; }
        public bool IncludeMyRetweet { get; set; }
        public object OEmbedUrl { get; set; }
        public int OEmbedMaxWidth { get; set; }
        public bool OEmbedHideMedia { get; set; }
        public bool OEmbedHideThread { get; set; }
        public bool OEmbedOmitScript { get; set; }
        public int OEmbedAlign { get; set; }
        public object OEmbedRelated { get; set; }
        public object OEmbedLanguage { get; set; }
        public string CreatedAt { get; set; }
        public int StatusID { get; set; }
        public object Text { get; set; }
        public object FullText { get; set; }
        public object ExtendedTweet { get; set; }
        public object Source { get; set; }
        public bool Truncated { get; set; }
        public object DisplayTextRange { get; set; }
        public int TweetMode { get; set; }
        public int InReplyToStatusID { get; set; }
        public int InReplyToUserID { get; set; }
        public object FavoriteCount { get; set; }
        public bool Favorited { get; set; }
        public object InReplyToScreenName { get; set; }
        public object User { get; set; }
        public object Users { get; set; }
        public object Contributors { get; set; }
        public object Coordinates { get; set; }
        public object Place { get; set; }
        public object Annotation { get; set; }
        public object Entities { get; set; }
        public object ExtendedEntities { get; set; }
        public bool TrimUser { get; set; }
        public bool IncludeContributorDetails { get; set; }
        public int RetweetCount { get; set; }
        public bool Retweeted { get; set; }
        public bool PossiblySensitive { get; set; }
        public object RetweetedStatus { get; set; }
        public int CurrentUserRetweet { get; set; }
        public bool IsQuotedStatus { get; set; }
        public int QuotedStatusID { get; set; }
        // public object QuotedStatus { get; set; }
        public object Scopes { get; set; }
        public bool WithheldCopyright { get; set; }
        public object WithheldInCountries { get; set; }
        public object WithheldScope { get; set; }
        public object MetaData { get; set; }
        public object Lang { get; set; }
        public bool Map { get; set; }
        public object TweetIDs { get; set; }
        public int FilterLevel { get; set; }
        public object EmbeddedStatus { get; set; }
        public object CursorMovement { get; set; }
    }

    public class Scopes
    {
    }

    public class MetaData
    {
        public string ResultType { get; set; }
        public string IsoLanguageCode { get; set; }
    }

    public class Status
    {
        public int Type { get; set; }
        public int ID { get; set; }
        public int UserID { get; set; }
        public object ScreenName { get; set; }
        public int SinceID { get; set; }
        public int MaxID { get; set; }
        public int Count { get; set; }
        public int Cursor { get; set; }
        public bool IncludeRetweets { get; set; }
        public bool ExcludeReplies { get; set; }
        public bool IncludeEntities { get; set; }
        public bool IncludeUserEntities { get; set; }
        public bool IncludeMyRetweet { get; set; }
        public object OEmbedUrl { get; set; }
        public int OEmbedMaxWidth { get; set; }
        public bool OEmbedHideMedia { get; set; }
        public bool OEmbedHideThread { get; set; }
        public bool OEmbedOmitScript { get; set; }
        public int OEmbedAlign { get; set; }
        public object OEmbedRelated { get; set; }
        public object OEmbedLanguage { get; set; }
        public string CreatedAt { get; set; }
        public object StatusID { get; set; }
        public string Text { get; set; }
        public object FullText { get; set; }
        public ExtendedTweet ExtendedTweet { get; set; }
        public string Source { get; set; }
        public bool Truncated { get; set; }
        public object DisplayTextRange { get; set; }
        public int TweetMode { get; set; }
        public long InReplyToStatusID { get; set; }
        public long InReplyToUserID { get; set; }
        public int FavoriteCount { get; set; }
        public bool Favorited { get; set; }
        public string InReplyToScreenName { get; set; }
        public User User { get; set; }
        public List<object> Users { get; set; }
        public List<object> Contributors { get; set; }
        public Coordinates Coordinates { get; set; }
        public Place Place { get; set; }
        public Annotation Annotation { get; set; }
        public Entities Entities { get; set; }
        public ExtendedEntities ExtendedEntities { get; set; }
        public bool TrimUser { get; set; }
        public bool IncludeContributorDetails { get; set; }
        public int RetweetCount { get; set; }
        public bool Retweeted { get; set; }
        public bool PossiblySensitive { get; set; }
        public RetweetedStatus RetweetedStatus { get; set; }
        public int CurrentUserRetweet { get; set; }
        public bool IsQuotedStatus { get; set; }
        public int QuotedStatusID { get; set; }
        public QuotedStatus QuotedStatus { get; set; }
        public Scopes Scopes { get; set; }
        public bool WithheldCopyright { get; set; }
        public List<object> WithheldInCountries { get; set; }
        public object WithheldScope { get; set; }
        public MetaData MetaData { get; set; }
        public string Lang { get; set; }
        public bool Map { get; set; }
        public object TweetIDs { get; set; }
        public int FilterLevel { get; set; }
        public object EmbeddedStatus { get; set; }
        public object CursorMovement { get; set; }
    }

    public class SearchMetaData
    {
        public double CompletedIn { get; set; }
        public int MaxID { get; set; }
        public string NextResults { get; set; }
        public string Query { get; set; }
        public object RefreshUrl { get; set; }
        public int Count { get; set; }
        public int SinceID { get; set; }
    }

    public class Operation
    {
        public int Type { get; set; }
        public string Query { get; set; }
        public object SearchLanguage { get; set; }
        public object Locale { get; set; }
        public int Count { get; set; }
        public string Until { get; set; }
        public int SinceID { get; set; }
        public int MaxID { get; set; }
        public object GeoCode { get; set; }
        public int ResultType { get; set; }
        public bool IncludeEntities { get; set; }
        public int TweetMode { get; set; }
        public List<Status> Statuses { get; set; }
        public SearchMetaData SearchMetaData { get; set; }
    }

    public class RootObject
    {
        public List<Operation> operations { get; set; }
    }
}
