USE [master]
GO
/****** Object:  Database [Center__Learning]    Script Date: 09/02/2024 09:48:05 م ******/
CREATE DATABASE [Center__Learning]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Center__Learning', FILENAME = N'E:\web\Center__Learning.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Center__Learning_log', FILENAME = N'E:\web\Center__Learning_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Center__Learning] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Center__Learning].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Center__Learning] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Center__Learning] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Center__Learning] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Center__Learning] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Center__Learning] SET ARITHABORT OFF 
GO
ALTER DATABASE [Center__Learning] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Center__Learning] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Center__Learning] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Center__Learning] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Center__Learning] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Center__Learning] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Center__Learning] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Center__Learning] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Center__Learning] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Center__Learning] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Center__Learning] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Center__Learning] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Center__Learning] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Center__Learning] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Center__Learning] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Center__Learning] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Center__Learning] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Center__Learning] SET RECOVERY FULL 
GO
ALTER DATABASE [Center__Learning] SET  MULTI_USER 
GO
ALTER DATABASE [Center__Learning] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Center__Learning] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Center__Learning] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Center__Learning] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Center__Learning] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Center__Learning] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Center__Learning', N'ON'
GO
ALTER DATABASE [Center__Learning] SET QUERY_STORE = OFF
GO
USE [Center__Learning]
GO
/****** Object:  Table [dbo].[absentesonly]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[absentesonly](
	[student_id] [nvarchar](50) NULL,
	[student_name] [nvarchar](150) NULL,
	[type] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[marhala_name] [nvarchar](50) NULL,
	[marhala_id] [int] NULL,
	[student_code] [nvarchar](50) NULL,
	[magmo3a_id] [int] NULL,
	[magmo3a_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[absentsandkhosomat]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[absentsandkhosomat](
	[order_id] [int] NOT NULL,
	[emp_id] [int] NULL,
	[emp_name] [nvarchar](50) NULL,
	[nomberof_days] [real] NULL,
	[type] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[notes] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[add_new_employee]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[add_new_employee](
	[emp_id] [int] NOT NULL,
	[emp_name] [nvarchar](50) NULL,
	[emp_salary] [real] NULL,
	[start_date] [nvarchar](50) NULL,
	[phone] [nvarchar](11) NULL,
	[national_id] [nvarchar](14) NULL,
	[address] [nvarchar](150) NULL,
	[activation] [bit] NULL,
 CONSTRAINT [PK_add_new_employee] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[addnew_users]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[addnew_users](
	[user_id] [int] NOT NULL,
	[user_name] [nvarchar](50) NULL,
	[user_password] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[stoke_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[attendans]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[attendans](
	[order_id] [int] NULL,
	[student_id] [int] NULL,
	[student_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[time] [nvarchar](50) NULL,
	[notes_row] [nvarchar](250) NULL,
	[genral_notes] [nvarchar](250) NULL,
	[user_name] [nvarchar](150) NULL,
	[state] [nvarchar](50) NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](50) NULL,
	[student_code] [nvarchar](50) NULL,
	[magmo3a_id] [int] NULL,
	[magmo3a_name] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[attendansonly]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[attendansonly](
	[student_id] [int] NULL,
	[student_name] [nvarchar](150) NULL,
	[type] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[marhala_name] [nvarchar](50) NULL,
	[marhala_id] [int] NULL,
	[student_code] [nvarchar](50) NULL,
	[magmo3a_id] [int] NULL,
	[magmo3a_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[deserved]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deserved](
	[deserved_id] [int] NULL,
	[deserved_type_id] [int] NULL,
	[type_name] [nvarchar](150) NULL,
	[money] [real] NULL,
	[notes] [nvarchar](350) NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[deserved_type]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deserved_type](
	[type_id] [int] NOT NULL,
	[type_name] [nvarchar](150) NULL,
	[notes] [nvarchar](150) NULL,
	[user_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_deserved_type] PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_account]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_account](
	[order_id] [int] NULL,
	[emp_id] [int] NULL,
	[emp_name] [nvarchar](150) NULL,
	[discription] [nvarchar](450) NULL,
	[total] [real] NULL,
	[on_him] [real] NULL,
	[sadad] [real] NULL,
	[notes] [nvarchar](450) NULL,
	[user_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[type] [nvarchar](250) NULL,
	[time] [nvarchar](50) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_attendans]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_attendans](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [int] NULL,
	[emp_name] [nvarchar](150) NULL,
	[description] [nvarchar](250) NULL,
	[date] [nvarchar](50) NULL,
	[time] [nvarchar](50) NULL,
	[notes] [nvarchar](150) NULL,
	[user_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exam_degree]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exam_degree](
	[order_id] [int] NULL,
	[student_id] [int] NULL,
	[student_name] [nvarchar](150) NULL,
	[description] [nvarchar](350) NULL,
	[notes] [nvarchar](450) NULL,
	[date] [nvarchar](50) NULL,
	[day_use] [nvarchar](50) NULL,
	[marhala_name] [nvarchar](150) NULL,
	[exam_degree] [real] NULL,
	[user_name] [nvarchar](150) NULL,
	[student_code] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[expenses_id]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[expenses_id](
	[id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[explain]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[explain](
	[order_id] [int] NULL,
	[description] [nvarchar](450) NULL,
	[date] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[groups]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groups](
	[group_id] [int] NULL,
	[group_name] [nvarchar](150) NULL,
	[notes] [nvarchar](250) NULL,
	[price] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[madfou3aat_details]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[madfou3aat_details](
	[order_id] [int] NULL,
	[student_id] [int] NULL,
	[student_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[day] [int] NULL,
	[month] [int] NULL,
	[year] [int] NULL,
	[user_name] [nvarchar](150) NULL,
	[money] [real] NULL,
	[type] [nvarchar](150) NULL,
	[marhala_id] [int] NULL,
	[student_code] [nvarchar](50) NULL,
	[activation] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[madfou3aat_details22]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[madfou3aat_details22](
	[order_id] [int] NULL,
	[student_id] [int] NULL,
	[student_name] [nvarchar](350) NULL,
	[date] [nvarchar](50) NULL,
	[day] [int] NULL,
	[month] [int] NULL,
	[year] [int] NULL,
	[user_name] [nvarchar](150) NULL,
	[money] [real] NULL,
	[type] [nvarchar](150) NULL,
	[marhala_id] [int] NULL,
	[student_code] [nvarchar](50) NULL,
	[activation] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[magmou3at]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[magmou3at](
	[magmou3a_id] [int] NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](150) NULL,
	[magmou3a_day] [nvarchar](150) NULL,
	[time_from] [nvarchar](150) NULL,
	[time_to] [nvarchar](150) NULL,
	[notes_day] [nvarchar](450) NULL,
	[general_notes] [nvarchar](450) NULL,
	[user_name] [nvarchar](250) NULL,
	[magmo3a_id] [int] NULL,
	[magmou3a_name] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[magmou3at_data]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[magmou3at_data](
	[magmou3a_id] [int] NULL,
	[magmou3a_name] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marhala_money]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marhala_money](
	[marhal_id] [nchar](10) NULL,
	[marhala_name] [nchar](10) NULL,
	[price] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notpaybooks]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notpaybooks](
	[student_id] [int] NULL,
	[student_name] [nvarchar](150) NULL,
	[type] [nvarchar](150) NULL,
	[marhala_name] [nvarchar](100) NULL,
	[marhala_id] [int] NULL,
	[student_code] [nvarchar](50) NULL,
	[magmo3a_id] [int] NULL,
	[magmo3a_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[printstudentstatement]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[printstudentstatement](
	[student_id] [int] NULL,
	[student_code] [nvarchar](150) NULL,
	[student_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[description] [nvarchar](250) NULL,
	[money] [real] NULL,
	[notes] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sand_kabd_estrdad]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sand_kabd_estrdad](
	[sand_id] [int] NULL,
	[student_id] [int] NULL,
	[student_name] [nvarchar](150) NULL,
	[sand_type] [nvarchar](250) NULL,
	[notes] [nvarchar](350) NULL,
	[money] [real] NULL,
	[user_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[marhal_name] [nvarchar](150) NULL,
	[description] [nvarchar](350) NULL,
	[student_code] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sandat_id]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sandat_id](
	[sand_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[settingprinting_bills]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[settingprinting_bills](
	[logo] [image] NULL,
	[name] [nvarchar](150) NULL,
	[address] [nvarchar](250) NULL,
	[discriptionnn] [nvarchar](450) NULL,
	[phone1] [nvarchar](50) NULL,
	[phone2] [nvarchar](50) NULL,
	[phone3] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoke_insert]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoke_insert](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[stoke_id] [int] NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[name] [nvarchar](250) NULL,
	[type] [nvarchar](250) NULL,
	[notes] [nvarchar](200) NULL,
	[user_name] [nvarchar](150) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoke_money]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoke_money](
	[stoke_id] [int] NULL,
	[money] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoke_withdrowal]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoke_withdrowal](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[stoke_id] [int] NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[name] [nvarchar](250) NULL,
	[type] [nvarchar](250) NULL,
	[notes] [nvarchar](200) NULL,
	[user_name] [nvarchar](200) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stokes]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stokes](
	[stoke_id] [int] NOT NULL,
	[stoke_name] [nvarchar](150) NULL,
	[user_name] [nvarchar](150) NULL,
	[notes] [nvarchar](350) NULL,
	[date] [nvarchar](50) NULL,
 CONSTRAINT [PK_stokes] PRIMARY KEY CLUSTERED 
(
	[stoke_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_account]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_account](
	[order_id] [int] NULL,
	[student_id] [int] NULL,
	[student_name] [nvarchar](150) NULL,
	[description] [nvarchar](450) NULL,
	[date] [nvarchar](50) NULL,
	[degree] [real] NULL,
	[user_name] [nvarchar](150) NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](150) NULL,
	[student_code] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_data]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_data](
	[student_id] [nvarchar](50) NULL,
	[student_name] [nvarchar](150) NULL,
	[marhal_id] [int] NULL,
	[marhala_name] [nvarchar](250) NULL,
	[date] [nvarchar](50) NULL,
	[activation] [int] NULL,
	[phone] [nvarchar](50) NULL,
	[father_phone] [nvarchar](50) NULL,
	[address] [nvarchar](350) NULL,
	[notes] [nvarchar](450) NULL,
	[student_code] [nvarchar](50) NULL,
	[magmo3a_id] [int] NULL,
	[magmo3a_name] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_degrees_only]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_degrees_only](
	[order_id] [int] NULL,
	[student_id] [int] NULL,
	[student_code] [nvarchar](150) NULL,
	[student_name] [nvarchar](250) NULL,
	[exam_degree] [real] NULL,
	[student_degree] [real] NULL,
	[type] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_estrdad_book_money]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_estrdad_book_money](
	[order_id] [int] NOT NULL,
	[old_order_id] [int] NULL,
	[student_id] [int] NULL,
	[student_code] [nvarchar](150) NULL,
	[student_name] [nvarchar](250) NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[money] [real] NULL,
	[type] [nvarchar](150) NULL,
	[description] [nvarchar](250) NULL,
	[user_name] [nvarchar](150) NULL,
 CONSTRAINT [PK_student_estrdad_book_money] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_leve_course]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_leve_course](
	[student_id] [int] NULL,
	[student_code] [nvarchar](150) NULL,
	[student_name] [nvarchar](250) NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](150) NULL,
	[activation] [int] NULL,
	[phone] [int] NULL,
	[father_phone] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_madfou3aat]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_madfou3aat](
	[student_id] [nvarchar](50) NULL,
	[student_name] [nvarchar](250) NULL,
	[date] [nvarchar](50) NULL,
	[mon_1] [real] NULL,
	[mon_2] [real] NULL,
	[mon_3] [real] NULL,
	[mon_4] [real] NULL,
	[mon_5] [real] NULL,
	[mon_6] [real] NULL,
	[mon_7] [real] NULL,
	[mon_8] [real] NULL,
	[mon_9] [real] NULL,
	[mon_10] [real] NULL,
	[mon_11] [real] NULL,
	[mon_12] [real] NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](150) NULL,
	[student_code] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_magmou3a]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_magmou3a](
	[student_id] [nvarchar](50) NULL,
	[student_name] [nvarchar](150) NULL,
	[marhala_id] [int] NULL,
	[marhala_name] [nvarchar](50) NULL,
	[day] [nvarchar](50) NULL,
	[day_from] [nvarchar](50) NULL,
	[day_to] [nvarchar](50) NULL,
	[student_code] [nvarchar](50) NULL,
	[magmo3a_id] [int] NULL,
	[magmo3a_name] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_settings]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_settings](
	[user_id] [int] NULL,
	[setting] [int] NULL,
	[sal7iat] [int] NULL,
	[marahel] [int] NULL,
	[magmou3aat] [int] NULL,
	[student_data] [int] NULL,
	[student_attendans] [int] NULL,
	[student_attendans_reports] [int] NULL,
	[expenses_type] [int] NULL,
	[expeses] [int] NULL,
	[expenses_salary] [int] NULL,
	[exam_degree] [int] NULL,
	[exam_degree_reports] [int] NULL,
	[eda3_inkhazna] [int] NULL,
	[withdrowalfromstoke] [int] NULL,
	[stoke_reports] [int] NULL,
	[student_account] [int] NULL,
	[copy_data] [int] NULL,
	[copy_return] [int] NULL,
	[balance] [int] NULL,
	[add_stoke] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[all-student-notactivation-ina-ll-mrahel]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[all-student-notactivation-ina-ll-mrahel]
As
--طباعه درجات اختبار الطالب



select student_id as'رقم  الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',marhal_id as'رقم المرحله',student_code as'كود الطالب',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',magmo3a_id as'رقم المجموعه',magmo3a_name as'اسم المجموعه' from student_data where activation=0
GO
/****** Object:  StoredProcedure [dbo].[all-student-notactivation-ina-selected-marhala]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[all-student-notactivation-ina-selected-marhala]
As




select student_id as'رقم  الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',marhal_id as'رقم المرحله',student_code as'كود الطالب',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',magmo3a_id as'رقم المجموعه',magmo3a_name as'اسم المجموعه' from student_data where activation=0
GO
/****** Object:  StoredProcedure [dbo].[exam_degree_print]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[exam_degree_print]
As
--طباعه درجات اختبار الطالب



select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',order_id as'رقم البيان',student_id as'كود الطالب',student_name as'اسم الطالب',description as'البيان',notes as'ملاحظات',date as'التاريخ',marhala_name as'المرحله',exam_degree as'الدرجه المقرره',user_name as'المستخدم',student_code as 'كود الطالببب' from settingprinting_bills,exam_degree

GO
/****** Object:  StoredProcedure [dbo].[expenses_print]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[expenses_print]
As
--طباعه المصروفات



select deserved_id as'رقم العمليه',type_name as'نوع البيان',money as'المبلغ',notes as'ملاحظات',date as'التاريخ',user_name as'المستخدم' from deserved
GO
/****** Object:  StoredProcedure [dbo].[sand_kabd]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sand_kabd]
As
--طباعه سندات



select settingprinting_bills.logo as'اللوجو', settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.discriptionnn as'الوصف الفاتوره',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3', sand_id as'رقم البيان',student_id as'كود الطالب',student_name as'اسم الطالب',sand_type as'نوع السند', date as'التاريخ',notes as'ملاحظات',money as'المبلغ',marhal_name as'المرحله',description as'البيان',student_code as 'كود الطالببب' from sand_kabd_estrdad,settingprinting_bills
GO
/****** Object:  StoredProcedure [dbo].[student_account_print]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[student_account_print]
As
--طباعه تقرير الطلاب



select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.discriptionnn as'الوصف',settingprinting_bills.address as'العنوان', student_id as'كود الطالب',student_name as'اسم الطالب',description as'البيان',date as'التاريخ',degree as'الدرجه',user_name as'المستخدم',marhala_name as'المرحله الدراسيه',student_code as 'كود الطالببب' from student_account ,settingprinting_bills
GO
/****** Object:  StoredProcedure [dbo].[student_in_marhala]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[student_in_marhala]
As
--طباعه سندات



select student_id as'رقم  الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',marhal_id as'رقم المرحله',student_code as'كود الطالب' from student_data where activation=1
GO
/****** Object:  StoredProcedure [dbo].[student_in_marhala_and_magmou3a]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[student_in_marhala_and_magmou3a]
As
--طباعه سندات



select student_id as'رقم  الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',marhal_id as'رقم المرحله',student_code as'كود الطالب',magmo3a_id as'رقم المجموعه',magmo3a_name as'اسم المجموعه' from student_data where activation=1
GO
/****** Object:  StoredProcedure [dbo].[studentstatement_print]    Script Date: 09/02/2024 09:48:06 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[studentstatement_print]
As
--طباعه درجات اختبار الطالب



select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.address as'العنوان', student_id as'رقم الطالب',student_code as 'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',printstudentstatement.description as'الوصف',money as'المبلغ',notes as'ملاحظات' from printstudentstatement ,settingprinting_bills

GO
USE [master]
GO
ALTER DATABASE [Center__Learning] SET  READ_WRITE 
GO
