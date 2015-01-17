using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHeebWebsite.BusinessLayer.BusinessModel
{
    public class Business_Photo
    {
        private string photoUrl;

        public string PhotoUrl
        {
            get { return photoUrl; }
            set { photoUrl = value; }
        }
        private string thumbnailUrl;

        public string ThumbnailUrl
        {
            get { return thumbnailUrl; }
            set { thumbnailUrl = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Business_Photo()
        {
            this.photoUrl = string.Empty;
            this.thumbnailUrl = string.Empty;
            this.title = string.Empty;
        }

        public void fillFromFlickr(FlickrNet.Photo photo)
        {
            this.photoUrl = photo.LargeUrl;
            this.thumbnailUrl = photo.MediumUrl;
            this.title = photo.Title;
        }
    }
}
