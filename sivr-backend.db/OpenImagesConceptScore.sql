CREATE TABLE [dbo].[OpenImagesConceptScore]
(
	[OpenImagesConceptId] SMALLINT NOT NULL, 
    [Score] FLOAT NOT NULL CHECK([Score] >= 0.0), 
    [V3CId] SMALLINT NOT NULL, 
    [KeyframeNumber] SMALLINT NOT NULL, 
    CONSTRAINT [PK_OpenImagesConceptScore] PRIMARY KEY ([V3CId], [KeyframeNumber], [OpenImagesConceptId]), 
    CONSTRAINT [FK_OpenImagesConceptScore_OpenImagesConcept] FOREIGN KEY ([OpenImagesConceptId]) REFERENCES [OpenImagesConcept]([OpenImagesConceptId]), 
    CONSTRAINT [FK_OpenImagesConceptScore_Keyframe] FOREIGN KEY ([V3CId], [KeyframeNumber]) REFERENCES [Keyframe]([V3CId], [KeyframeNumber]), 

)

GO

CREATE INDEX [IX_OpenImagesConceptScore_Score] ON [dbo].[OpenImagesConceptScore] ([Score])

GO

CREATE INDEX [IX_OpenImagesConceptScore_OpenImagesConceptName] ON [dbo].[OpenImagesConceptScore] ([OpenImagesConceptId])
