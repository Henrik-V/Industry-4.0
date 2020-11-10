USE [Industry]
GO

/****** Object:  Table [dbo].[CONFIGURATIONDATA]    Script Date: 15/09/2020 14:14:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CONFIGURATIONDATA](
	[ConfigurationDataId] [int] IDENTITY(1,1) NOT NULL,
	[TemperatureUnit] [nchar](16) NULL,
 CONSTRAINT [PK_Table_2] PRIMARY KEY CLUSTERED 
(
	[ConfigurationDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[DATAINFORMATION]    Script Date: 15/09/2020 14:15:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DATAINFORMATION](
	[DataInformationId] [int] IDENTITY(1,1) NOT NULL,
	[AverageCelsius] [real] NULL,
	[MinCelsius] [real] NULL,
	[MaxCelsius] [real] NULL,
	[AverageFahrenheit] [real] NULL,
	[MinFahrenheit] [real] NULL,
	[MaxFahrenheit] [real] NULL,
 CONSTRAINT [PK_DATAINFORMATION] PRIMARY KEY CLUSTERED 
(
	[DataInformationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[TEMPERATURES]    Script Date: 15/09/2020 14:22:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TEMPERATURES](
	[TemperatureId] [int] IDENTITY(1,1) NOT NULL,
	[TimeStampo] [datetime] NULL,
	[Celsius] [real] NULL,
	[Fahrenheit] [real] NULL
) ON [PRIMARY]
GO

/****** Object:  StoredProcedure [dbo].[StoreData]    Script Date: 15/09/2020 13:59:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[StoreData]
@Timestampo datetime,
@Celsius real

AS

DECLARE
@Fahrenheit real

BEGIN
SET @Fahrenheit = @Celsius * 9/5 + 32
insert into TEMPERATURES (Timestampo, Celsius, Fahrenheit) values (@Timestampo, @Celsius, @Fahrenheit)

END
GO

/****** Object:  StoredProcedure [dbo].[SetUnit]    Script Date: 15/09/2020 14:00:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SetUnit]
@TemperatureUnit nchar(16)

AS

UPDATE CONFIGURATIONDATA SET TemperatureUnit = @TemperatureUnit

GO

/****** Object:  View [dbo].[TempData]    Script Date: 15/09/2020 13:56:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[TempData]
AS

SELECT
DATAINFORMATION.AverageCelsius,
DATAINFORMATION.AverageFahrenheit,
DATAINFORMATION.MaxCelsius,
DATAINFORMATION.MaxFahrenheit,
DATAINFORMATION.MinCelsius,
DATAINFORMATION.MinFahrenheit,
DATAINFORMATION.DataInformationId,
CONFIGURATIONDATA.TemperatureUnit,
CONFIGURATIONDATA.ConfigurationDataId


FROM
DATAINFORMATION
INNER JOIN CONFIGURATIONDATA ON DATAINFORMATION.DataInformationId = CONFIGURATIONDATA.ConfigurationDataId
GO

/****** Object:  Trigger [dbo].[CalculateStats]    Script Date: 15/09/2020 14:27:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TRIGGER [dbo].[CalculateStats] ON [dbo].[TEMPERATURES]
FOR UPDATE, INSERT, DELETE

AS

DECLARE
@AverageCelsius real,
@MinCelsius real,
@MaxCelsius real,
@AverageFahrenheit real,
@MinFahrenheit real,
@MaxFahrenheit real

select @AverageCelsius = AVG(Celsius) FROM TEMPERATURES
select @MinCelsius = MIN(Celsius) FROM TEMPERATURES
select @MaxCelsius = MAX(Celsius) FROM TEMPERATURES

select @AverageFahrenheit = AVG(Fahrenheit) FROM TEMPERATURES
select @MinFahrenheit = MIN(Fahrenheit) FROM TEMPERATURES
select @MaxFahrenheit = MAX(Fahrenheit) FROM TEMPERATURES

UPDATE DATAINFORMATION SET AverageCelsius = @AverageCelsius, 
							MinCelsius = @MinCelsius,
							MaxCelsius = @MaxCelsius,
							AverageFahrenheit = @AverageFahrenheit,
							MinFahrenheit = @MinFahrenheit,
							MaxFahrenheit = @MaxFahrenheit
GO

ALTER TABLE [dbo].[TEMPERATURES] ENABLE TRIGGER [CalculateStats]
GO
