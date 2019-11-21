using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bandTogether.Services.BandSevices
{
    public static class YoutubeServices
    {

        public static void GetChannelVideos(string channelId)
        {
            channelId = "UCW89qBnjTxXFYTfHWbbHZkA";
            YoutubeManager manager = new YoutubeManager();
            manager.SearchForVideosByChannel(channelId, 20);
           // manager.GetVideoDetails("NUmVU4dLeZ8");

        }
       
            
    }


}