USE [DB_ASP]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 10/18/2019 8:45:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MASP] [bigint] NOT NULL,
	[MAHD] [bigint] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [real] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC,
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETSANPHAM]    Script Date: 10/18/2019 8:45:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETSANPHAM](
	[MASP] [bigint] NULL,
	[ID] [bigint] NOT NULL,
	[MAUSAC] [nvarchar](20) NULL,
	[KICHCO] [varchar](5) NULL,
	[GIATIEN] [float] NULL,
	[TONKHO] [int] NULL,
	[HINHANH_1] [text] NULL,
	[HINHANH_2] [text] NULL,
	[HINHANH_3] [text] NULL,
 CONSTRAINT [PK_CHITIETSANPHAM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIO_HANG]    Script Date: 10/18/2019 8:45:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIO_HANG](
	[MASP] [bigint] NOT NULL,
	[TENTK] [varchar](30) NOT NULL,
	[SOLUONG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MASP] ASC,
	[TENTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 10/18/2019 8:45:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [bigint] NOT NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [real] NULL,
	[TRANGTHAI] [nchar](10) NULL,
	[MAKH] [int] NULL,
	[NGAYMUA] [datetime] NULL,
	[DIACHIGIAO] [nvarchar](max) NULL,
	[SDTGIAOHANG] [varchar](20) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAISP]    Script Date: 10/18/2019 8:45:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISP](
	[ID] [int] NOT NULL,
	[TENLOAI] [nvarchar](20) NULL,
 CONSTRAINT [PK_LOAISP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 10/18/2019 8:45:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [bigint] NOT NULL,
	[TENSP] [nvarchar](30) NULL,
	[MOTA] [text] NULL,
	[LOAI] [int] NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 10/18/2019 8:45:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENTK] [varchar](30) NOT NULL,
	[MATKHAU] [varchar](20) NULL,
	[EMAIL] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[DIACHI] [varchar](max) NULL,
	[HOTEN] [nvarchar](100) NULL,
	[LAADMIN] [bit] NULL,
	[ANHDAIDIEN] [nvarchar](max) NULL,
	[TRANGTHAI] [bit] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TENTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETSANPHAM_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETSANPHAM] CHECK CONSTRAINT [FK_CHITIETSANPHAM_SANPHAM]
GO
ALTER TABLE [dbo].[GIO_HANG]  WITH CHECK ADD  CONSTRAINT [FK_GIOHANG_SANPHAM_MASP] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[GIO_HANG] CHECK CONSTRAINT [FK_GIOHANG_SANPHAM_MASP]
GO
ALTER TABLE [dbo].[GIO_HANG]  WITH CHECK ADD  CONSTRAINT [FK_GIOHANG_TAIKHOAN_TENTK] FOREIGN KEY([TENTK])
REFERENCES [dbo].[TAIKHOAN] ([TENTK])
GO
ALTER TABLE [dbo].[GIO_HANG] CHECK CONSTRAINT [FK_GIOHANG_TAIKHOAN_TENTK]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISP] FOREIGN KEY([LOAI])
REFERENCES [dbo].[LOAISP] ([ID])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISP]
GO
