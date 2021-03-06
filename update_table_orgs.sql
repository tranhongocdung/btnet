/*
   Wednesday, May 15, 20194:39:09 PM
   User: 
   Server: DESKTOP-21CFVH6\SQLEXPRESS
   Database: BTNET
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.orgs ADD
	og_sapid nvarchar(200) NULL,
	og_address nvarchar(200) NULL
GO
ALTER TABLE dbo.orgs SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
