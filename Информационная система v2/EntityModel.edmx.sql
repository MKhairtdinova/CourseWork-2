
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2018 18:04:08
-- Generated from EDMX file: C:\Users\User\documents\visual studio 2015\Projects\Информационная система v2\Информационная система v2\EntityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [InformationSystemDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PatientDevice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeviceSet] DROP CONSTRAINT [FK_PatientDevice];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorPatient_Doctor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorPatient] DROP CONSTRAINT [FK_DoctorPatient_Doctor];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorPatient_Patient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorPatient] DROP CONSTRAINT [FK_DoctorPatient_Patient];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientHealthStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HealthStatusSet] DROP CONSTRAINT [FK_PatientHealthStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientMeasuredData]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MeasuredDataSet] DROP CONSTRAINT [FK_PatientMeasuredData];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministratorMessage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorMessageSet] DROP CONSTRAINT [FK_AdministratorMessage];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministratorDeviceMessage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeviceMessageSet] DROP CONSTRAINT [FK_AdministratorDeviceMessage];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceMessageDevice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeviceMessageSet] DROP CONSTRAINT [FK_DeviceMessageDevice];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorDoctorMessage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorMessageSet] DROP CONSTRAINT [FK_DoctorDoctorMessage];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DeviceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeviceSet];
GO
IF OBJECT_ID(N'[dbo].[DoctorMessageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoctorMessageSet];
GO
IF OBJECT_ID(N'[dbo].[DoctorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoctorSet];
GO
IF OBJECT_ID(N'[dbo].[PatientSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientSet];
GO
IF OBJECT_ID(N'[dbo].[AdministratorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdministratorSet];
GO
IF OBJECT_ID(N'[dbo].[MeasuredDataSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeasuredDataSet];
GO
IF OBJECT_ID(N'[dbo].[HealthStatusSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HealthStatusSet];
GO
IF OBJECT_ID(N'[dbo].[DeviceMessageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeviceMessageSet];
GO
IF OBJECT_ID(N'[dbo].[DoctorPatient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoctorPatient];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DeviceSet'
CREATE TABLE [dbo].[DeviceSet] (
    [DeviceCode] int IDENTITY(1,1) NOT NULL,
    [Function] int  NOT NULL,
    [OwnerCode] int  NOT NULL,
    [Patient_UserCode] int  NOT NULL
);
GO

-- Creating table 'DoctorMessageSet'
CREATE TABLE [dbo].[DoctorMessageSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [SenderCode] int  NOT NULL,
    [RecipientCode] int  NOT NULL,
    [Checked] bit  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Administrator_UserCode] int  NOT NULL,
    [Doctor_UserCode] int  NOT NULL
);
GO

-- Creating table 'DoctorSet'
CREATE TABLE [dbo].[DoctorSet] (
    [UserCode] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Polyclinic] int  NOT NULL,
    [Post] int  NOT NULL
);
GO

-- Creating table 'PatientSet'
CREATE TABLE [dbo].[PatientSet] (
    [UserCode] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Male] int  NOT NULL,
    [Height] tinyint  NOT NULL,
    [Weight] tinyint  NOT NULL
);
GO

-- Creating table 'AdministratorSet'
CREATE TABLE [dbo].[AdministratorSet] (
    [UserCode] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MeasuredDataSet'
CREATE TABLE [dbo].[MeasuredDataSet] (
    [DeviceCode] int  NOT NULL,
    [Number] bigint IDENTITY(1,1) NOT NULL,
    [CreatingTime] datetime  NOT NULL,
    [OwnerCode] int  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Patient_UserCode] int  NOT NULL
);
GO

-- Creating table 'HealthStatusSet'
CREATE TABLE [dbo].[HealthStatusSet] (
    [Status] nvarchar(max)  NOT NULL,
    [Number] int IDENTITY(1,1) NOT NULL,
    [CreatingTime] datetime  NOT NULL,
    [OwnerCode] int  NOT NULL,
    [Patient_UserCode] int  NOT NULL
);
GO

-- Creating table 'DeviceMessageSet'
CREATE TABLE [dbo].[DeviceMessageSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [SenderCode] int  NOT NULL,
    [RecipientCode] int  NOT NULL,
    [Checked] bit  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Administrator_UserCode] int  NOT NULL,
    [Device_DeviceCode] int  NOT NULL
);
GO

-- Creating table 'DoctorPatient'
CREATE TABLE [dbo].[DoctorPatient] (
    [Doctor_UserCode] int  NOT NULL,
    [Patient_UserCode] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DeviceCode] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [PK_DeviceSet]
    PRIMARY KEY CLUSTERED ([DeviceCode] ASC);
GO

-- Creating primary key on [Id] in table 'DoctorMessageSet'
ALTER TABLE [dbo].[DoctorMessageSet]
ADD CONSTRAINT [PK_DoctorMessageSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserCode] in table 'DoctorSet'
ALTER TABLE [dbo].[DoctorSet]
ADD CONSTRAINT [PK_DoctorSet]
    PRIMARY KEY CLUSTERED ([UserCode] ASC);
GO

-- Creating primary key on [UserCode] in table 'PatientSet'
ALTER TABLE [dbo].[PatientSet]
ADD CONSTRAINT [PK_PatientSet]
    PRIMARY KEY CLUSTERED ([UserCode] ASC);
GO

-- Creating primary key on [UserCode] in table 'AdministratorSet'
ALTER TABLE [dbo].[AdministratorSet]
ADD CONSTRAINT [PK_AdministratorSet]
    PRIMARY KEY CLUSTERED ([UserCode] ASC);
GO

-- Creating primary key on [Number] in table 'MeasuredDataSet'
ALTER TABLE [dbo].[MeasuredDataSet]
ADD CONSTRAINT [PK_MeasuredDataSet]
    PRIMARY KEY CLUSTERED ([Number] ASC);
GO

-- Creating primary key on [Number] in table 'HealthStatusSet'
ALTER TABLE [dbo].[HealthStatusSet]
ADD CONSTRAINT [PK_HealthStatusSet]
    PRIMARY KEY CLUSTERED ([Number] ASC);
GO

-- Creating primary key on [Id] in table 'DeviceMessageSet'
ALTER TABLE [dbo].[DeviceMessageSet]
ADD CONSTRAINT [PK_DeviceMessageSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Doctor_UserCode], [Patient_UserCode] in table 'DoctorPatient'
ALTER TABLE [dbo].[DoctorPatient]
ADD CONSTRAINT [PK_DoctorPatient]
    PRIMARY KEY CLUSTERED ([Doctor_UserCode], [Patient_UserCode] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Patient_UserCode] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [FK_PatientDevice]
    FOREIGN KEY ([Patient_UserCode])
    REFERENCES [dbo].[PatientSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientDevice'
CREATE INDEX [IX_FK_PatientDevice]
ON [dbo].[DeviceSet]
    ([Patient_UserCode]);
GO

-- Creating foreign key on [Doctor_UserCode] in table 'DoctorPatient'
ALTER TABLE [dbo].[DoctorPatient]
ADD CONSTRAINT [FK_DoctorPatient_Doctor]
    FOREIGN KEY ([Doctor_UserCode])
    REFERENCES [dbo].[DoctorSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Patient_UserCode] in table 'DoctorPatient'
ALTER TABLE [dbo].[DoctorPatient]
ADD CONSTRAINT [FK_DoctorPatient_Patient]
    FOREIGN KEY ([Patient_UserCode])
    REFERENCES [dbo].[PatientSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorPatient_Patient'
CREATE INDEX [IX_FK_DoctorPatient_Patient]
ON [dbo].[DoctorPatient]
    ([Patient_UserCode]);
GO

-- Creating foreign key on [Patient_UserCode] in table 'HealthStatusSet'
ALTER TABLE [dbo].[HealthStatusSet]
ADD CONSTRAINT [FK_PatientHealthStatus]
    FOREIGN KEY ([Patient_UserCode])
    REFERENCES [dbo].[PatientSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientHealthStatus'
CREATE INDEX [IX_FK_PatientHealthStatus]
ON [dbo].[HealthStatusSet]
    ([Patient_UserCode]);
GO

-- Creating foreign key on [Patient_UserCode] in table 'MeasuredDataSet'
ALTER TABLE [dbo].[MeasuredDataSet]
ADD CONSTRAINT [FK_PatientMeasuredData]
    FOREIGN KEY ([Patient_UserCode])
    REFERENCES [dbo].[PatientSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientMeasuredData'
CREATE INDEX [IX_FK_PatientMeasuredData]
ON [dbo].[MeasuredDataSet]
    ([Patient_UserCode]);
GO

-- Creating foreign key on [Administrator_UserCode] in table 'DoctorMessageSet'
ALTER TABLE [dbo].[DoctorMessageSet]
ADD CONSTRAINT [FK_AdministratorMessage]
    FOREIGN KEY ([Administrator_UserCode])
    REFERENCES [dbo].[AdministratorSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministratorMessage'
CREATE INDEX [IX_FK_AdministratorMessage]
ON [dbo].[DoctorMessageSet]
    ([Administrator_UserCode]);
GO

-- Creating foreign key on [Administrator_UserCode] in table 'DeviceMessageSet'
ALTER TABLE [dbo].[DeviceMessageSet]
ADD CONSTRAINT [FK_AdministratorDeviceMessage]
    FOREIGN KEY ([Administrator_UserCode])
    REFERENCES [dbo].[AdministratorSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministratorDeviceMessage'
CREATE INDEX [IX_FK_AdministratorDeviceMessage]
ON [dbo].[DeviceMessageSet]
    ([Administrator_UserCode]);
GO

-- Creating foreign key on [Device_DeviceCode] in table 'DeviceMessageSet'
ALTER TABLE [dbo].[DeviceMessageSet]
ADD CONSTRAINT [FK_DeviceMessageDevice]
    FOREIGN KEY ([Device_DeviceCode])
    REFERENCES [dbo].[DeviceSet]
        ([DeviceCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceMessageDevice'
CREATE INDEX [IX_FK_DeviceMessageDevice]
ON [dbo].[DeviceMessageSet]
    ([Device_DeviceCode]);
GO

-- Creating foreign key on [Doctor_UserCode] in table 'DoctorMessageSet'
ALTER TABLE [dbo].[DoctorMessageSet]
ADD CONSTRAINT [FK_DoctorDoctorMessage]
    FOREIGN KEY ([Doctor_UserCode])
    REFERENCES [dbo].[DoctorSet]
        ([UserCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorDoctorMessage'
CREATE INDEX [IX_FK_DoctorDoctorMessage]
ON [dbo].[DoctorMessageSet]
    ([Doctor_UserCode]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------