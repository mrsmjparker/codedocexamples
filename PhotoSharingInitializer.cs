# codedocexamples
#Seekingthedream_codeDocumentationSamples

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext>
    {
        //This method puts meta_dump data into SQLMIADB_Dev (DEV)
        protected override void Seed(PhotoSharingContext context)
        {
            base.Seed(context);

            //DEV - Create some photos to insert into SQLMIADB_Dev (dev.products.photos table)
            //PROD - user uploads photos to insert into SQLAZExamPrep_PROD (products.photos table)
            var photos = new List<Photo>
            {
                new Photo {
                    Title = "test_photo_1",
                    Description = "test photo 1_dump",
                    UserName = "Testuser1",
                    PhotoFile = getFileBytes("\\Images\\az_900.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-5),
                    Location = "London, UK",
                      Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                    Title = "test_photo2",
                    Description = "test photo 2_dump",
                    UserName = "Testuser2",
                    PhotoFile = getFileBytes("\\Images\\az_300.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-14),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                      Title = "test_photo3",
                    Description = "test photo 3_dump",
                    UserName = "Testuser3",
                    PhotoFile = getFileBytes("\\Images\\az_400.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-6),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo4",
                    Description = "test photo 4_dump",
                    UserName = "Testuser4",
                    PhotoFile = getFileBytes("\\Images\\az_200.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-10),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo5",
                    Description = "test photo 5_dump",
                    UserName = "Testuser5",
                    PhotoFile = getFileBytes("\\Images\\m365_400.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-14),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo6",
                    Description = "test photo 6_dump",
                    UserName = "Testuser6",
                    PhotoFile = getFileBytes("\\Images\\sp_300.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-4),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo7",
                    Description = "test photo 7_dump",
                    UserName = "Testuser7",
                    PhotoFile = getFileBytes("\\Images\\exchange_100.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-30),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                      Title = "test_photo8",
                    Description = "test photo 8_dump",
                    UserName = "Testuser8",
                    PhotoFile = getFileBytes("\\Images\\exchange_300.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-14),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo9",
                    Description = "test photo 9_dump",
                    UserName = "Testuser9",
                    PhotoFile = getFileBytes("\\Images\\az_250.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-12),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                        Title = "test_photo10",
                    Description = "test photo 10_dump",
                    UserName = "Testuser10",
                    PhotoFile = getFileBytes("\\Images\\onedrive_300.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-14),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo11",
                    Description = "test photo 11_dump",
                    UserName = "Testuser11",
                    PhotoFile = getFileBytes("\\Images\\onedrive_200.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-6),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo12",
                    Description = "test photo 12_dump",
                    UserName = "Testuser12",
                    PhotoFile = getFileBytes("\\Images\\onedrive_100.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-16),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                },
                new Photo {
                     Title = "test_photo13",
                    Description = "test photo 13_dump",
                    UserName = "Testuser13",
                    PhotoFile = getFileBytes("\\Images\\sp_400.jpg"),
                    ImageMimeType = "image/jpeg",
                    CreatedDate = DateTime.Today.AddDays(-14),
                    Location = "London, UK",
                    Latitude = "51.506321",
                    Longitude = "-0.12714"
                }
            };
            photos.ForEach(s => context.Photos.Add(s));
            context.SaveChanges();

             //DEV - Create some comments to insert into SQLMIADB_Dev (dev_products_comments table)
            //PROD - user uploads photos to insert into SQLAZExamPrep_PROD (products_comments table)
            var comments = new List<Comment>
            {
                new Comment {
                    PhotoID = 1,
                    UserName = "testuser1",
                    Subject = "Sample Comment 1",
                    Body = "logo for product 1"
                },
                new Comment {
                    PhotoID = 2,
                    UserName = "testuser2",
                    Subject = "Sample Comment 2",
                    Body = "logo for product 2"
                },
                new Comment {
                    PhotoID = 3,
                    UserName = "testuser3",
                    Subject = "Sample Comment 3",
                    Body = "logo for product 3
                }
            };
            comments.ForEach(s => context.Comments.Add(s));
            context.SaveChanges();
        }

        //next, get a byte array for a file at the path specified
        //The path is relative to the route of the web site
        //It is used to seed images
        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }

    }
}
