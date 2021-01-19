#codedocexamples

#Seekingthedream_codeDocumentationSamples

The code in this repository represents code for a photo sharing app.  The two environments being targeted are "DEV" and "PROD".  

____________________________________________
**ARTIFACTS LOCATION**

  DEV - Create some fake photo metadata to insert into SQLMIADB_Dev (dev.products.photos table)
  
  PROD - user uploads photos into app, which will insert metadata into SQLAZExamPrep_PROD (products.photos table)
____________________________________________


EXPECTED RESULTS OF APP (version 1)_timestamp 1/19/2021
In producttion, it is expected that users will insert photos, and comments into the products schema:
Photos Table
Comments Table

RULES
Photos must be valid type

________________________________
WHAT IS INCLUDED IN THIS REPO:

PhotoSharingInitializer.cs
DEV photos and comments inserted into DEV database to simulate actual insertion of photos and comments in PROD

PhotoSharingContext.cs
This class is the actual ACTION class for CRUD and query functions for app.  Users will be able to insert photos and comments. Once inserted, users will be able to query for photos and comments by ID and Title.

Photo.cs

