CREATE TABLE [dbo].[userTb1] (
    [uName]     NVARCHAR(30)           NOT NULL,
    [IName]    NVARCHAR(20)    NOT NULL,
    [fName]    NVARCHAR(20)    NOT NULL,
    [eMail]    NVARCHAR(30)    NULL,
    [gender]   NCHAR (6)     NOT NULL,
    [yearBorn] INT           NOT NULL,
    [perfix]   NCHAR (3)     NULL,
    [phone]    NCHAR (7)     NULL,
    [city]     NCHAR (10)    NULL,
    [ch1]      NCHAR (10)    NULL,
    [ch2]      NCHAR (1)     NULL,
    [ch3]      NCHAR (1)     NULL,
    [ch4]      NCHAR (1)     NULL,
    [ch5]      NCHAR (1)     NULL,
    [pass]     NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([uName] ASC)
);

