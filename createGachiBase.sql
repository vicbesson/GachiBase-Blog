CREATE DATABASE ContentManagement;

GO

IF NOT EXISTS (
	SELECT name
	FROM master.sys.server_principals
	WHERE name = 'GBMaster')
BEGIN 
	CREATE LOGIN [GBMaster] WITH PASSWORD =N'Mypasswordispassword'
	CREATE USER [GBMaster] FOR LOGIN [GBMaster]
END

USE [ContentManagement]

IF NOT EXISTS
    (SELECT name
     FROM sys.database_principals
     WHERE name = 'GBMaster')
BEGIN
    CREATE USER [GBMaster] FOR LOGIN [GBMaster] 
	ALTER ROLE [db_owner] ADD MEMBER [GBMaster]
END

CREATE TABLE ContentManagement.dbo.Avatars (
	AvatarID int IDENTITY(1,1) PRIMARY KEY,
	AvatarImage varbinary(MAX) DEFAULT(0x)
);

CREATE TABLE ContentManagement.dbo.Users (
	UserID int IDENTITY(1,1) PRIMARY KEY,
	Username varchar(20) NOT NULL UNIQUE,
	Password varchar(255) NOT NULL,
	Email varchar(64) NOT NULL UNIQUE,
	JoinDate datetime DEFAULT(GETDATE()),
	NumPosts int DEFAULT(0) NOT NULL,
	NumPages int DEFAULT(0) NOT NULL,
	NumComments int DEFAULT(0) NOT NULL,
	Banned bit DEFAULT(0) NOT NULL,
	BanReason varchar(MAX),
	Avatar int FOREIGN KEY REFERENCES Avatars(AvatarID),
);

CREATE TABLE ContentManagement.dbo.Pages (
	PageID int IDENTITY(1,1) PRIMARY KEY,
	UserID int FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	Title varchar(60) NOT NULL,
	Description varchar(255),
	DateCreated datetime DEFAULT(GETDATE())
);

CREATE TABLE ContentManagement.dbo.PageContent (
	PageContentID int IDENTITY(1,1) PRIMARY KEY,
	PageID int FOREIGN KEY REFERENCES Pages(PageID) NOT NULL,
	PageContent varchar(MAX),
	PageOrderNum int NOT NULL
);

CREATE TABLE ContentManagement.dbo.PageImage (
	PageImageID int IDENTITY(1,1) PRIMARY KEY,
	PageID int FOREIGN KEY REFERENCES Pages(PageID) NOT NULL,
	PageImage varbinary(MAX),
	PageOrderNum int NOT NULL
);

CREATE TABLE ContentManagement.dbo.Whispers (
	WhisperID int IDENTITY(1,1) PRIMARY KEY,
	SendingUser int FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	ReceivingUser int FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	WhisperContent varchar(MAX) NOT NULL,
	WhisperDate datetime DEFAULT(GETDATE()) NOT NULL
);

CREATE TABLE ContentManagement.dbo.Posts (
	PostID int IDENTITY(1,1) PRIMARY KEY,
	UserID int FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	Title varchar(60) NOT NULL,
	PostDate datetime DEFAULT(GETDATE()) NOT NULL
);

CREATE TABLE ContentManagement.dbo.Comments (
	CommentID int IDENTITY(1,1) PRIMARY KEY,
	PostID int FOREIGN KEY REFERENCES Posts(PostID) NOT NULL,
	UserID int FOREIGN KEY REFERENCES Users(UserID) NOT NULL,
	CommentContent varchar(MAX) NOT NULL,
	CommentDate datetime DEFAULT(GETDATE()) NOT NULL
);

CREATE TABLE ContentManagement.dbo.PostContent (
	PostContentID int IDENTITY(1,1) PRIMARY KEY,
	PostID int FOREIGN KEY REFERENCES Posts(PostID) NOT NULL,
	PostContent varchar(MAX) NOT NULL,
	PostOrderNUM int NOT NULL
);

CREATE TABLE ContentManagement.dbo.PostImage (
	PostImageID int IDENTITY(1,1) PRIMARY KEY,
	PostID int FOREIGN KEY REFERENCES Posts(PostID) NOT NULL,
	PostImage varbinary(MAX),
	PostOrderNum int NOT NULL
);

CREATE TABLE ContentManagement.dbo.Admins (
	AdminID int IDENTITY(1,1) PRIMARY KEY,
	UserID int FOREIGN KEY REFERENCES Users(UserID) NOT NULL
);