CREATE TABLE [dbo].[ColorScore]
(
	[ColorId] NVARCHAR(7) NOT NULL, 
    [Score] FLOAT NOT NULL CHECK([Score] >= 0.0), 
    [V3CId] SMALLINT NOT NULL, 
    [KeyframeNumber] SMALLINT NOT NULL, 
    CONSTRAINT [FK_ColorScore_Keyframe] FOREIGN KEY ([V3CId], [KeyframeNumber]) REFERENCES [Keyframe]([V3CId], [KeyframeNumber]), 
    CONSTRAINT [PK_ColorScore] PRIMARY KEY ([V3CId], [KeyframeNumber], [ColorId]), 

)

GO

CREATE INDEX [IX_ColorScore_Score] ON [dbo].[ColorScore] ([Score])

GO

CREATE INDEX [IX_ColorScore_RgbId] ON [dbo].[ColorScore] ([ColorId])
