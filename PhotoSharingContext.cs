using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

//This ACTION class represents CRUD properties that will serve:
  // SQLMIADB_Dev (dev.products.photos table)
  //PSQLAZExamPrep_PROD (products.photos table)
//class performing inserts, deletes, query by photoID, PhotoTitle, PhotoComments

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingContext : DbContext, IPhotoSharingContext
    {
        public PhotoSharingContext() : base()
        {
            this.Database.CommandTimeout = 180;
        }
//two classes specific to this app used for Photos and Comments which will be uploaded by end users
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

        IQueryable<Photo> IPhotoSharingContext.Photos
        {
            get { return Photos; }
        }

        IQueryable<Comment> IPhotoSharingContext.Comments
        {
            get { return Comments; }
        }

        int IPhotoSharingContext.SaveChanges()
        {
            return SaveChanges();
        }
//insert photo
        T IPhotoSharingContext.Add<T>(T entity)
        {
            return Set<T>().Add(entity);
        }
//query by photoid
        Photo IPhotoSharingContext.FindPhotoById(int ID)
        {
            return Set<Photo>().Find(ID);
        }
//query by title
        Photo IPhotoSharingContext.FindPhotoByTitle(string Title)
        {
            Photo photo = (from p in Set<Photo>()
                           where p.Title == Title
                           select p).FirstOrDefault();
            return photo;
        }
//query by comment
        Comment IPhotoSharingContext.FindCommentById(int ID)
        {
            return Set<Comment>().Find(ID);
        }
//delte photo
        T IPhotoSharingContext.Delete<T>(T entity)
        {
            return Set<T>().Remove(entity);
        }
    }
}
