using DHeebWebsite.BusinessLayer.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHeebWebsite.Models
{
    public class PhotoModel
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

        public PhotoModel()
        {
            this.photoUrl = string.Empty;
            this.thumbnailUrl = string.Empty;
            this.title = string.Empty;
        }
        public void fillFromBusiness(Business_Photo photo)
        {
            this.photoUrl = photo.PhotoUrl;
            this.thumbnailUrl = photo.ThumbnailUrl;
            this.title = photo.Title;
        }
    }
}