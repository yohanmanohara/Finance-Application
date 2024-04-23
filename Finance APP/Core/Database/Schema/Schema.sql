IF OBJECT_ID('dbo.PersonalLoan', 'U') IS NOT NULL DROP TABLE [dbo].[PersonalLoan];
IF OBJECT_ID('dbo.User', 'U') IS NOT NULL DROP TABLE [dbo].[User];
IF OBJECT_ID('dbo.Transaction', 'U') IS NOT NULL DROP TABLE [dbo].[Transaction];
IF OBJECT_ID('dbo.Account', 'U') IS NOT NULL DROP TABLE [dbo].[Account];
IF OBJECT_ID('dbo.Customer', 'U') IS NOT NULL DROP TABLE [dbo].[Customer];

CREATE TABLE [dbo].[Customer]
(
	[Id]                          INT            NOT NULL PRIMARY KEY, 
	[Name]                        NCHAR(300)     NOT NULL,
    [FullName]                    NVARCHAR (300) NOT NULL,
    [ResidentialAddress]          NCHAR (200)    NOT NULL,
	[Mobile]                      NCHAR(10)      NOT NULL, 
	[Email]                       NCHAR(100)     NOT NULL,
    [NICNumber]                   NCHAR (10)     NOT NULL,
    [TINNumber]                   NCHAR (10)     NOT NULL,
    [Occupation]                  NCHAR (50)     NOT NULL,
    [DateOfBirth]                 DATE           NOT NULL,
    [CivilStatus]                 NCHAR (10)     NOT NULL,
    [Nationality]                 NCHAR (100)    NOT NULL,
    [Profession]                  NCHAR (100)    NOT NULL,
    [Designation]                 NCHAR (100)    NOT NULL,
    [Employer]                    NCHAR (100)    NOT NULL,
    [EmplyementStatus]            NCHAR (15)     NOT NULL,
    [EmployementServiceTimeStart] DATE           NOT NULL,
    [SpouseProfession]            NCHAR (10)     NOT NULL,
    [IncomeMethod]                NCHAR (10)     NOT NULL,
    [IncomeAmount]                REAL           NOT NULL,
);

CREATE TABLE [dbo].[Account]
(
	[Id]                          INT            NOT NULL PRIMARY KEY, 
    [CustomerId]                  INT            NOT NULL FOREIGN KEY REFERENCES [dbo].[Customer](Id),
    [Type]                        NCHAR(30)      NOT NULL, 
    [Balance]                     REAL           NOT NULL, 
    [Name]                        NCHAR(300)     NOT NULL
);

CREATE TABLE [dbo].[Transaction]
(
	[Id]                          INT            NOT NULL PRIMARY KEY, 
	[AccountId]                   INT            NOT NULL FOREIGN KEY REFERENCES [dbo].[Account](Id),
	[Amount]                      REAL           NOT NULL, 
	[Type]                        NCHAR(30)      NOT NULL, 
	[Date]                        TIMESTAMP      NOT NULL, 
	[Notes]                       NCHAR(100)     NOT NULL
);

CREATE TABLE [dbo].[User]
(
	[Id]                          INT            NOT NULL PRIMARY KEY, 
	[Name]                        NCHAR(300)     NOT NULL, 
	[Password]                    NCHAR(40)      NOT NULL, 
	[Role]                        NCHAR(30)      NOT NULL,
    [Email]                       NCHAR(100)     NOT NULL,
    [Gender]                      NCHAR(1)       NOT NULL,
    [Mobile]                      NCHAR(10)      NOT NULL,
    [NICNumber]                   NCHAR(10)      NOT NULL,
    [DateOfBirth]                 DATE           NOT NULL,
    [ResidentialAddress]          NCHAR (200)    NOT NULL,
    [EmployementStatus]           NCHAR (15)     NOT NULL,
    [EmployementServiceTimeStart] DATE           NOT NULL,
    [ProfilePicture]              BINARY         NOT NULL,
);

CREATE TABLE [dbo].[PersonalLoan] (
    [Id]                          INT            NOT NULL,
    [AccountId]                   INT            NOT NULL FOREIGN KEY REFERENCES [dbo].[Account](Id),
    [LoanPurpose]                 NCHAR (10)     NOT NULL,
    [LoanAmount]                  REAL           NOT NULL,
    [RepaymentPeriodStart]        DATE           NOT NULL,
    [RepaymentPeriodEnd]          DATE           NOT NULL,
    [InterestRate]                REAL           NOT NULL,
    [MonthlyRepaymentAmount]      REAL           NOT NULL,
    [TotalRepaymentAmount]        REAL           NOT NULL,
    [LoanStatus]                  NCHAR (10)     NOT NULL,
    [LoanApprovalDate]            DATE           NOT NULL,
    [LoanDisbursedDate]           DATE           NOT NULL,
    [LoanDisbursedAmount]         REAL           NOT NULL,
    [LoanDisbursedBy]             INT            NOT NULL FOREIGN KEY REFERENCES [dbo].[User](Id),
);
