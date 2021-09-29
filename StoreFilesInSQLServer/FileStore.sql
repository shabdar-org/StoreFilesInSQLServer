drop table [dbo].[FileStore];
CREATE TABLE [dbo].[FileStore] (
    [FileId]     INT   IDENTITY(1,1)           NOT NULL,
    [OriginalPath] VARCHAR(MAX)      NULL,
    [FileData]     VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([FileId] ASC)
);