CREATE TABLE [dbo].[Keyframe]
(
    [V3CId] SMALLINT NOT NULL, 
    [KeyframeNumber] SMALLINT NOT NULL CHECK([KeyframeNumber] >= 0), 
    CONSTRAINT [FK_Keyframe_Video] FOREIGN KEY ([V3CId]) REFERENCES [Video]([V3CId]), 
    CONSTRAINT [PK_Keyframe] PRIMARY KEY ([V3CId], [KeyframeNumber])
)
