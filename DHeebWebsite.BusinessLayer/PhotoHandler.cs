using DHeebWebsite.BusinessLayer.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHeebWebsite.BusinessLayer
{
    public class PhotoHandler
    {
        public Business_PhotoCollection getPhotosOfDheeb(string appkey,string secretAppKey, string authKey, string authKeySecret, string userID)
        {
            Business_PhotoCollection output = new Business_PhotoCollection();
            
            Flickr.FlickrHandler handler = new Flickr.FlickrHandler(appkey, secretAppKey, authKey, authKeySecret, userID);
            FlickrNet.PhotoCollection col = handler.getPhotoCollection();
            foreach (FlickrNet.Photo pht in col)
            {
                Business_Photo photo = new Business_Photo();
                photo.fillFromFlickr(pht);
                output.Add(photo);
            }

            return output;
        }
    }
}
