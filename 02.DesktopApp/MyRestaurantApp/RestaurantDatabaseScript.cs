﻿USE [master]
GO
/****** Object:  Database [RestaurantDb]    Script Date: 26.10.2023 22:56:57 ******/
CREATE DATABASE [RestaurantDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RestaurantDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RestaurantDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RestaurantDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RestaurantDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RestaurantDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RestaurantDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RestaurantDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RestaurantDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RestaurantDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RestaurantDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RestaurantDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [RestaurantDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RestaurantDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RestaurantDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RestaurantDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RestaurantDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RestaurantDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RestaurantDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RestaurantDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RestaurantDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RestaurantDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RestaurantDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RestaurantDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RestaurantDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RestaurantDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RestaurantDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RestaurantDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RestaurantDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RestaurantDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RestaurantDb] SET  MULTI_USER 
GO
ALTER DATABASE [RestaurantDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RestaurantDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RestaurantDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RestaurantDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RestaurantDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RestaurantDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RestaurantDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [RestaurantDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RestaurantDb]
GO
/****** Object:  Table [dbo].[Additions]    Script Date: 26.10.2023 22:56:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Additions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TableId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[AdditionDate] [datetime] NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[ProductVariantId] [int] NULL,
 CONSTRAINT [PK_Additions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentHistories]    Script Date: 26.10.2023 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentHistories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TableId] [int] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[ProductVariantId] [int] NULL,
	[PaymentType] [smallint] NOT NULL,
 CONSTRAINT [PK_PaymentHistories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 26.10.2023 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Products] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductVariants]    Script Date: 26.10.2023 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductVariants](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_ProductVariants] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tables]    Script Date: 26.10.2023 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tables](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[IsAvailable] [bit] NOT NULL,
	[IsPayment] [bit] NOT NULL,
	[TotalAmount] [money] NOT NULL,
	[PaidAmount] [money] NOT NULL,
 CONSTRAINT [PK_Tables] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Tables] UNIQUE NONCLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Additions]  WITH CHECK ADD  CONSTRAINT [FK_Additions_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Additions] CHECK CONSTRAINT [FK_Additions_Products]
GO
ALTER TABLE [dbo].[Additions]  WITH CHECK ADD  CONSTRAINT [FK_Additions_ProductVariants] FOREIGN KEY([ProductVariantId])
REFERENCES [dbo].[ProductVariants] ([Id])
GO
ALTER TABLE [dbo].[Additions] CHECK CONSTRAINT [FK_Additions_ProductVariants]
GO
ALTER TABLE [dbo].[Additions]  WITH CHECK ADD  CONSTRAINT [FK_Additions_Tables] FOREIGN KEY([TableId])
REFERENCES [dbo].[Tables] ([Id])
GO
ALTER TABLE [dbo].[Additions] CHECK CONSTRAINT [FK_Additions_Tables]
GO
ALTER TABLE [dbo].[PaymentHistories]  WITH CHECK ADD  CONSTRAINT [FK_PaymentHistories_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[PaymentHistories] CHECK CONSTRAINT [FK_PaymentHistories_Products]
GO
ALTER TABLE [dbo].[PaymentHistories]  WITH CHECK ADD  CONSTRAINT [FK_PaymentHistories_ProductVariants] FOREIGN KEY([ProductVariantId])
REFERENCES [dbo].[ProductVariants] ([Id])
GO
ALTER TABLE [dbo].[PaymentHistories] CHECK CONSTRAINT [FK_PaymentHistories_ProductVariants]
GO
ALTER TABLE [dbo].[PaymentHistories]  WITH CHECK ADD  CONSTRAINT [FK_PaymentHistories_Tables] FOREIGN KEY([TableId])
REFERENCES [dbo].[Tables] ([Id])
GO
ALTER TABLE [dbo].[PaymentHistories] CHECK CONSTRAINT [FK_PaymentHistories_Tables]
GO
ALTER TABLE [dbo].[ProductVariants]  WITH CHECK ADD  CONSTRAINT [FK_ProductVariants_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductVariants] CHECK CONSTRAINT [FK_ProductVariants_Products]
GO
USE [master]
GO
ALTER DATABASE [RestaurantDb] SET  READ_WRITE 
GO
namespace Bookify.Domain.Abstractions;

public abstract class Entity<TEntityId> : IEntity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    protected Entity(TEntityId id)
    {
        Id = id;
    }

    protected Entity()
    {
    }

    public TEntityId Id { get; init; }

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}