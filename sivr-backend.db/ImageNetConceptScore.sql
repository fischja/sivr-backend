CREATE TABLE [dbo].[ImageNetConceptScore]
(
    [ImageNetConceptId] SMALLINT NOT NULL, 
    [Score] FLOAT NOT NULL CHECK([Score] >= 0.0), 
    [V3CId] SMALLINT NOT NULL, 
    [KeyframeNumber] SMALLINT NOT NULL, 
    CONSTRAINT [FK_ImageNetConceptId_ImageNetConceptScore] FOREIGN KEY ([ImageNetConceptId]) REFERENCES [ImageNetConcept]([ImageNetConceptId]), 
    CONSTRAINT [FK_ImageNetConceptScore_Keyframe] FOREIGN KEY ([V3CId], [KeyframeNumber]) REFERENCES [Keyframe]([V3CId], [KeyframeNumber]), 
    CONSTRAINT [PK_ImageNetConceptScore] PRIMARY KEY ([V3CId], [KeyframeNumber], [ImageNetConceptId]), 
)

GO

CREATE INDEX [IX_ImageNetConceptScore_ImageNetConceptId] ON [dbo].[ImageNetConceptScore] ([ImageNetConceptId])

GO

CREATE INDEX [IX_ImageNetConceptScore_Score] ON [dbo].[ImageNetConceptScore] ([Score])
