CREATE TABLE [dbo].[User] (
    [UserID]      INT          IDENTITY (1, 1) NOT NULL,
    [RoleID]      INT          NOT NULL,
    [Username]    VARCHAR (50) NOT NULL,
    [Email]       VARCHAR (50) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [Gender]      SMALLINT     NOT NULL,
    [PhoneNumber] NUMERIC (18) NOT NULL,
    [Address]     VARCHAR (50) NOT NULL,
    [Banned]      BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC),
    FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role] ([RoleID]),
    CHECK ([Address] like '%Street%'),
    CHECK ([Email] like '%@%'),
    CHECK (len([Username])>=(3)),
    CHECK (len([Username])>=(8))
);

