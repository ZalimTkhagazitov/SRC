﻿CREATE TABLE [dbo].[Login]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Password] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Login_Users] FOREIGN KEY (UserId) REFERENCES Users(UserId)
)
