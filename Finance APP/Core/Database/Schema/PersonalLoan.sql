﻿CREATE TABLE [dbo].[PersonalLoan] (
    [Id]                          INT            NOT NULL,
	[AccountId]					  INT            NOT NULL,
    [FullName]                    NVARCHAR (200) NOT NULL,
    [ResidentialAddress]          NCHAR (200)    NOT NULL,
    [Occupation]                  NCHAR (50)     NOT NULL,
    [DateOfBirth]                 DATE           NOT NULL,
    [NICNumber]                   NCHAR (10)     NOT NULL,
    [TINNumber]                   NCHAR (10)     NOT NULL,
    [MobileNumber]                NCHAR (10)     NOT NULL,
    [Email]                       NCHAR (100)    NOT NULL,
    [Nationality]                 NCHAR (100)    NOT NULL,
    [CivilStatus]                 NCHAR (10)     NOT NULL,
    [Profession]                  NCHAR (100)    NOT NULL,
    [Designation]                 NCHAR (100)    NOT NULL,
    [Employer]                    NCHAR (100)    NOT NULL,
    [EmplyementStatus]            NCHAR (15)     NOT NULL,
    [EmployementServiceTimeStart] DATE           NOT NULL,
    [SpouseProfession]            NCHAR (10)     NOT NULL,
    [IncomeMethod]                NCHAR (10)     NOT NULL,
    [IncomeAmount]                NCHAR (10)     NOT NULL,
    [LoanPurpose]                 NCHAR (10)     NOT NULL,
    [LoanAmount]                  REAL           NOT NULL,
    [RepaymentPeriodStart]        DATE           NOT NULL,
    [RepaymentPeriodEnd]          DATE           NOT NULL,
);
