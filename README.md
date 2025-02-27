#codedocexamples

#Seekingthedream_codeDocumentationSamples

**ABOUT - PHOTO SHARING APP**
The code in this repository represents code for a photo sharing app.  The two environments being targeted are "DEV" and "PROD".  The app is designed to share photos/logos for various exam prep books, and comments about them.

**Process Overview**
Marketing department will upload new logos for each new product, including title
Marketing department will supply comment information for each photo uploaded
Marketing and Sales departments will update as needed


____________________________________________
**ARTIFACTS LOCATION**

  DEV - Create some fake photo metadata to insert into SQLMIADB_Dev (dev.products.photos table)
  
  PROD - user uploads photos into app, which will insert metadata into SQLAZExamPrep_PROD (products.photos table)
____________________________________________


**EXPECTED RESULTS OF APP (version 1)_timestamp 1/19/2021**
In producttion, it is expected that users will insert photos, and comments into the products schema:
Photos Table
Comments Table

**RULES**
Photos must be valid type
Subject field is required after upload (comments)
Title Field is required after upload (photos)
Provided users are validated, after logging in, all users can edit their own comments and/or photos

________________________________
**FILES INCLUDED IN THIS REPO:**

PhotoSharingInitializer.cs
DEV photos and comments inserted into DEV database to simulate actual insertion of photos and comments in PROD

PhotoSharingContext.cs
This class is the actual ACTION class for CRUD and query functions for app.  Users will be able to insert photos and comments. Once inserted, users will be able to query for photos and comments by ID and Title.

Photo.cs
This class shows metadata and properties which map to fields in the actual databases.  In addition, this class outlines:
Field Types
Rules/Requirements on Fields (for users)
Additional format information (dates, and photo types)

Comments.cs
This class contains properties that map to fields in the DEV and PROD databases mentioned above




