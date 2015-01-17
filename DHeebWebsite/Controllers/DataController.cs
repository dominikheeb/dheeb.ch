using DHeebWebsite.BusinessLayer.BusinessModel;
using DHeebWebsite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHeebWebsite.Controllers
{
    public class DataController : Controller
    {
        [HttpPost]
        public JsonResult flickrGallery()
        {
            BusinessLayer.PhotoHandler handler = new BusinessLayer.PhotoHandler();
            string appKey = ConfigurationManager.ConnectionStrings["FlickrAppCode"].ConnectionString;
            string appKeySecret = ConfigurationManager.ConnectionStrings["FlickrAppCodeSecret"].ConnectionString;
            string authKey = ConfigurationManager.ConnectionStrings["FlickrAuthCode"].ConnectionString;
            string authKeySecret = ConfigurationManager.ConnectionStrings["FlickrAuthCodeSecret"].ConnectionString;
            string userID = ConfigurationManager.ConnectionStrings["FlickrNetUserId"].ConnectionString;
            Business_PhotoCollection col = handler.getPhotosOfDheeb(appKey, appKeySecret, authKey, authKeySecret, userID);
            PhotoCollectionModel model = new PhotoCollectionModel();
            
            foreach (Business_Photo pht in col)
            {
                PhotoModel photo = new PhotoModel();

                photo.fillFromBusiness(pht);

                model.Add(photo);
            }

            return Json(model);
        }

        public PartialViewResult dotPhotoCollection()
        {
            return PartialView();
        }
    }
}