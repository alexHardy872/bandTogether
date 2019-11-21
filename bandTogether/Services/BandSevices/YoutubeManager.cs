using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.Services;

namespace bandTogether.Services.BandSevices
{
    public class YoutubeManager
    {
        YouTubeService client;

        public YoutubeManager()
        {
            client = new YouTubeService(new BaseClientService.Initializer() { ApiKey = Private.Secrets.youtubeAPIkey, ApplicationName = this.GetType().ToString() });

        }

        public List<string> SearchForVideosByChannel(string searchValue, int maxResultsCount)
        {
            SearchResource.ListRequest searchListRequest = client.Search.List("snippet");
           // searchListRequest.Q = searchValue;
            searchListRequest.MaxResults = maxResultsCount;
            searchListRequest.ChannelId = searchValue;
            searchListRequest.Type = "video";
            searchListRequest.Fields = "description";
            

            SearchListResponse searchListResponse = searchListRequest.Execute();



            List<string> videos = new List<string>();
            List<string> channels = new List<string>();
            List<string> playlists = new List<string>();

            foreach (SearchResult searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                       
                        break;

                    case "youtube#channel":
                        channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        break;

                    case "youtube#playlist":
                        playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                        break;
                }
            }

            return videos;
        }
    }
}