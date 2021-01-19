  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingApplication.Models
{
//This interface will ensure that all application developers will create classes, using business standards for this photo application
//Developers are required to implement this Interface when creating CRUD and Query classes for the Photo Application


    public interface IPhotoSharingContext
    {
        IQueryable<Photo> Photos { get; }
        IQueryable<Comment> Comments { get; }
        int SaveChanges();
        T Add<T>(T entity) where T : class;
        Photo FindPhotoById(int ID);
        Photo FindPhotoByTitle(string Title);
        Comment FindCommentById(int ID);
        T Delete<T>(T entity) where T : class;
    }
}
