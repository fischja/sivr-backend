CREATE TABLE [dbo].[ImageNetConceptName]
(
    [ImageNetConceptNameId] INT NOT NULL IDENTITY(1, 1), 
	[ImageNetConceptId] SMALLINT NOT NULL , 
    [Name] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY ([ImageNetConceptNameId]), 
    CONSTRAINT [FK_ImageNetConceptId_ImageNetConcept] FOREIGN KEY (ImageNetConceptId) REFERENCES [ImageNetConcept](ImageNetConceptId)
)
