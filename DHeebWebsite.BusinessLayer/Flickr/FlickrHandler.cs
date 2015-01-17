using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHeebWebsite.BusinessLayer.Flickr
{
    public class FlickrHandler
    {
        private FlickrNet.Flickr api;
        private string userID;
        public FlickrHandler(string apiKey, string secretApiKey, string authKey, string authKeySecret, string userID)
        {
            this.userID = userID;
            this.api = new FlickrNet.Flickr(apiKey, secretApiKey);
            this.api.OAuthAccessToken = authKey;
            this.api.OAuthAccessTokenSecret = authKeySecret;
        }

        public FlickrNet.PhotoCollection getPhotoCollection()
        {
            FlickrNet.PhotoCollection output = new FlickrNet.PhotoCollection();

            if (this.api != null)
            {
                FlickrNet.PhotoSearchOptions options = new FlickrNet.PhotoSearchOptions();
                options.PrivacyFilter = FlickrNet.PrivacyFilter.PublicPhotos;
                options.UserId = this.userID;
                output = this.api.PhotosSearch(options);
            }

            return output;
        }
    }
}
