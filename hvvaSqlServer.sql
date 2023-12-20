use master
go
create database [HVVA]
go
ALTER DATABASE [HVVA] SET COMPATIBILITY_LEVEL = 160
GO
use [HVVA]
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table PersonalData(
	personalDataId int IDENTITY(1,1) not null,
	name varchar(255) null,
	lastname varchar(255) null,
	age int null,
	bornDate datetime null,
    bornPlace datetime null,
    idDocument varchar(255) null,
    address varchar(255) null,
    celPhone varchar(255) null,
    email varchar(255) null
)
go
create table SummaryData(
	summaryDataId int identity(1,1) not null,
	title varchar(max) null,
	data varchar(max) null
)
go
create table TypeTraining(
	typeTrainingId int identity(1,1) not null,
	type varchar(255) null
)
go
create table ModalityTraining(
	modalityTrainingId int identity(1,1) not null,
	modality varchar(255) null
)
go
create table EducationData(
	educationDataId int identity(1,1) not null,
	typeTrainingId int not null,
	modalityTrainingId int not null,
	title varchar(255) null,
	institution varchar(255) null,
	startDate datetime null,
	finishDate datetime null,
	summary varchar(255) null
)
go
create table DetailSummary(
	detailSummaryId int identity(1,1) not null,
	detail varchar(max)
)
go
create table Skills(
	skillsId int identity(1,1) not null,
	skill varchar(max)
)
go
create table ExperienceData(
	experienceDataId int identity(1,1) not null,
	enterprise varchar(255) null,
	phone varchar(255) null,
	url varchar(255) null,
	position varchar(255) null,
	summary varchar(max) null,
	startDate datetime not null,
	finishDate datetime not null,
	detailSumaryId int not null,
	skillsId int not null
)
go
create table PersonalReference(
	personalReferenceId int identity(1,1) not null,
	name varchar(255) null,
	celphone varchar(255) null,
	email varchar(255) null,
	occupation varchar(255) null
)
go


