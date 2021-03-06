﻿CREATE TABLE [dbo].[MetaData]
(
	[V3CId] SMALLINT NOT NULL PRIMARY KEY CHECK([V3CId] > 0), 
    [Width] SMALLINT NOT NULL CHECK([Width] > 0),
    [Height] SMALLINT NOT NULL CHECK([Height] > 0),
    [Duration] SMALLINT NOT NULL CHECK([Duration] > 0), 
    [Title] NVARCHAR(MAX) NULL, 
    [FullTitle] NVARCHAR(MAX) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Licence] NVARCHAR(MAX) NULL, 
    [Extractor] NVARCHAR(MAX) NULL, 
    [ExtractorKey] NVARCHAR(MAX) NULL, 
    [SourceOrigId] INT NULL UNIQUE CHECK([SourceOrigId] > 0), 
    [SourceOrigFilename] NVARCHAR(MAX) NULL, 
    [DisplayId] NVARCHAR(MAX) NULL, 
    [WebpageUrl] NVARCHAR(MAX) NULL, 
    [WebpageUrlBasename] NVARCHAR(MAX) NULL, 
    [Thumbnail] NVARCHAR(MAX) NULL, 
    [Format] NVARCHAR(MAX) NULL, 
    [FormatId] NVARCHAR(MAX) NULL, 
    [SourceTimestamp] DATETIME2 NULL, 
    [Resolution] NVARCHAR(MAX) NULL, 
    [StretchedRatio] NVARCHAR(MAX) NULL, 
    [Fps] NVARCHAR(MAX) NULL, 
    [Abr] NVARCHAR(MAX) NULL, 
    [Vbr] NVARCHAR(MAX) NULL, 
    [Ext] NVARCHAR(MAX) NULL, 
    [ACodec] NVARCHAR(MAX) NULL, 
    [VCodec] NVARCHAR(MAX) NULL, 
    [Channel] NVARCHAR(MAX) NULL, 
    [Uploader] NVARCHAR(MAX) NULL, 
    [UploaderId] NVARCHAR(MAX) NULL, 
    [UploaderUrl] NVARCHAR(MAX) NULL, 
    [UploadDate] DATETIME2 NULL, 
    [ViewCount] INT NULL CHECK([ViewCount] >= 0),
    [LikeCount] INT CHECK([LikeCount] >= 0),
    [CommentCount] INT CHECK([CommentCount] >= 0), 
    [Playlist] NVARCHAR(MAX) NULL, 
    [PlaylistIndex] SMALLINT NULL,


)
