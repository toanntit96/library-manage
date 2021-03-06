USE [quanlythuvien]
GO
/****** Object:  Table [dbo].[tbl_docgia]    Script Date: 5/23/2017 9:32:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_docgia](
	[madocgia] [varchar](50) NOT NULL,
	[hoten] [nvarchar](100) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[makhoa] [varchar](50) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[ngaylapthe] [date] NOT NULL,
	[matkhau] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_docgia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_khoa]    Script Date: 5/23/2017 9:32:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_khoa](
	[makhoa] [varchar](50) NOT NULL,
	[tenkhoa] [nvarchar](100) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[sdt] [varchar](11) NOT NULL,
 CONSTRAINT [PK_tbl_khoa] PRIMARY KEY CLUSTERED 
(
	[makhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_nhanvien]    Script Date: 5/23/2017 9:32:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_nhanvien](
	[manhanvien] [varchar](50) NOT NULL,
	[hoten] [nvarchar](100) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[matkhau] [varchar](50) NOT NULL,
	[quyenhan] [int] NOT NULL,
 CONSTRAINT [PK_tbl_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_phanloai]    Script Date: 5/23/2017 9:32:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_phanloai](
	[maloai] [int] IDENTITY(1,1) NOT NULL,
	[tenloai] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_phanloai] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_phieumuon]    Script Date: 5/23/2017 9:32:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_phieumuon](
	[madocgia] [varchar](50) NOT NULL,
	[ngaymuon] [date] NOT NULL,
	[masach] [int] NOT NULL,
	[manhanvien] [varchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[trangthai] [bit] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_sach]    Script Date: 5/23/2017 9:32:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sach](
	[masach] [int] IDENTITY(1,1) NOT NULL,
	[nhande] [nvarchar](100) NOT NULL,
	[sotrang] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[namxb] [int] NOT NULL,
	[lanxb] [int] NOT NULL,
	[solanmuon] [int] NOT NULL,
	[maloai] [int] NOT NULL,
	[nxb] [nvarchar](100) NOT NULL,
	[tacgia] [nvarchar](100) NOT NULL,
	[ngaynhap] [date] NOT NULL,
 CONSTRAINT [PK_tbl_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG001', N'ĐỌC GIẢ 1', CAST(0xB51F0B00 AS Date), N'CTT', N'Vĩnh Long', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG002', N'ĐỌC GIẢ 2', CAST(0xB51F0B00 AS Date), N'DDT', N'Cần Thơ', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG003', N'ĐỌC GIẢ 3', CAST(0xB51F0B00 AS Date), N'CTT', N'Đồng Tháp', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG004', N'ĐỌC GIẢ 4', CAST(0xB51F0B00 AS Date), N'DDT', N'Bến Tre', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG005', N'ĐỌC GIẢ 5', CAST(0xB51F0B00 AS Date), N'DDT', N'Vĩnh Long', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG006', N'ĐỌC GIẢ 6', CAST(0xB51F0B00 AS Date), N'CTM', N'Hà Tiên', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG007', N'ĐỌC GIẢ 7', CAST(0xB51F0B00 AS Date), N'CTM', N'Hậu Giang', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_docgia] ([madocgia], [hoten], [ngaysinh], [makhoa], [diachi], [ngaylapthe], [matkhau]) VALUES (N'DG008', N'ĐỌC GIẢ 8', CAST(0xB51F0B00 AS Date), N'CTT', N'Trà Vinh', CAST(0xC43C0B00 AS Date), N'á
Ü9IºY«¾VàWòˆ>')
INSERT [dbo].[tbl_khoa] ([makhoa], [tenkhoa], [diachi], [sdt]) VALUES (N'CTM', N'Chế tạo máy', N'Vĩnh Long', N'0123456789')
INSERT [dbo].[tbl_khoa] ([makhoa], [tenkhoa], [diachi], [sdt]) VALUES (N'CTP', N'Công nghệ thực phẩm', N'Vĩnh Long', N'0123456789')
INSERT [dbo].[tbl_khoa] ([makhoa], [tenkhoa], [diachi], [sdt]) VALUES (N'CTT', N'Công nghệ thông tin', N'Vĩnh Long', N'0123456789')
INSERT [dbo].[tbl_khoa] ([makhoa], [tenkhoa], [diachi], [sdt]) VALUES (N'DDT', N'Điện tử', N'Vĩnh Long', N'0123456789')
INSERT [dbo].[tbl_nhanvien] ([manhanvien], [hoten], [diachi], [matkhau], [quyenhan]) VALUES (N'admin', N'admin', N'vĩnh long', N'á
Ü9IºY«¾VàWòˆ>', 0)
INSERT [dbo].[tbl_nhanvien] ([manhanvien], [hoten], [diachi], [matkhau], [quyenhan]) VALUES (N'nv001', N'nhân viên 1', N'trà vinh', N'á
Ü9IºY«¾VàWòˆ>', 1)
INSERT [dbo].[tbl_nhanvien] ([manhanvien], [hoten], [diachi], [matkhau], [quyenhan]) VALUES (N'nv002', N'nhân viên 2', N'vĩnh long', N'á
Ü9IºY«¾VàWòˆ>', 1)
INSERT [dbo].[tbl_nhanvien] ([manhanvien], [hoten], [diachi], [matkhau], [quyenhan]) VALUES (N'nv003', N'nhân viên 3', N'cần thơ', N'á
Ü9IºY«¾VàWòˆ>', 1)
SET IDENTITY_INSERT [dbo].[tbl_phanloai] ON 

INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (1, N'Chính trị')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (2, N'Giáo dục')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (3, N'Giáo trình')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (4, N'Kinh doanh')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (5, N'Khoa học')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (6, N'Kỹ năng sống')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (7, N'Kinh tế')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (8, N'Lịch sử')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (9, N'Ngoại ngữ')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (10, N'Sách giáo khoa')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (11, N'Thiếu nhi')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (12, N'Văn học')
INSERT [dbo].[tbl_phanloai] ([maloai], [tenloai]) VALUES (13, N'Văn hóa - Xã hội')
SET IDENTITY_INSERT [dbo].[tbl_phanloai] OFF
SET IDENTITY_INSERT [dbo].[tbl_sach] ON 

INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (1, N'Trật tự thế giới', 220, 13, 2014, 1, 0, 1, N'NXB Thế Giới', N'Henry Kissinger', CAST(0xC73C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (2, N'Chính trị luận', 150, 14, 2013, 1, 0, 1, N'Alpha Book', N'Aristotle', CAST(0xC73C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (3, N'Giáo dục mầm non', 100, 10, 2012, 1, 0, 2, N'Nhà xuất bản Giáo dục', N'Giáo dục', CAST(0xC73C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (4, N'Tuần làm việc 4 giờ', 350, 30, 2015, 1, 0, 3, N'First New', N'Timothy Ferriss', CAST(0xC73C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (5, N'Hoàn thành mọi việc không hề khó: Nghệ thuật thực thi không căng thẳng', 420, 25, 2014, 1, 0, 3, N'First New', N'David Allen', CAST(0xC43C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (6, N'Để xây dựng doanh nghiệp hiệu quả', 320, 10, 2013, 1, 0, 3, N'First New', N'Michael E.Gerber', CAST(0xC43C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (7, N'Tony Buổi Sáng - Trên Đường Băng', 420, 40, 2016, 1, 0, 6, N'Trẻ', N'Tony Buổi Sáng', CAST(0xC33C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (8, N'Tony Buổi Sáng - Cafe Cùng Tony', 380, 35, 2016, 1, 0, 6, N'Trẻ', N'Tony Buổi Sáng', CAST(0xC33C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (9, N'Những điều thú vị về các Vua Triều Lý', 300, 15, 2014, 1, 0, 12, N'NHÀ XUẤT BẢN LAO ĐỘNG', N'Lê Thái Dũng', CAST(0xC73C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (10, N'Oxford thương yêu', 250, 20, 2014, 1, 0, 12, N'Trẻ', N'Dương Thụy', CAST(0xC73C0B00 AS Date))
INSERT [dbo].[tbl_sach] ([masach], [nhande], [sotrang], [soluong], [namxb], [lanxb], [solanmuon], [maloai], [nxb], [tacgia], [ngaynhap]) VALUES (11, N'"Mưa" thơ', 260, 25, 2013, 1, 0, 12, N'Nhà xuất bản Hội Nhà Văn', N'Trần Ngọc Minh', CAST(0xC73C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[tbl_sach] OFF
ALTER TABLE [dbo].[tbl_docgia]  WITH CHECK ADD  CONSTRAINT [FK_tbl_docgia_tbl_khoa] FOREIGN KEY([makhoa])
REFERENCES [dbo].[tbl_khoa] ([makhoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_docgia] CHECK CONSTRAINT [FK_tbl_docgia_tbl_khoa]
GO
ALTER TABLE [dbo].[tbl_phieumuon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_phieumuon_tbl_docgia] FOREIGN KEY([madocgia])
REFERENCES [dbo].[tbl_docgia] ([madocgia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_phieumuon] CHECK CONSTRAINT [FK_tbl_phieumuon_tbl_docgia]
GO
ALTER TABLE [dbo].[tbl_phieumuon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_phieumuon_tbl_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[tbl_nhanvien] ([manhanvien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_phieumuon] CHECK CONSTRAINT [FK_tbl_phieumuon_tbl_nhanvien]
GO
ALTER TABLE [dbo].[tbl_phieumuon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_phieumuon_tbl_sach] FOREIGN KEY([masach])
REFERENCES [dbo].[tbl_sach] ([masach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_phieumuon] CHECK CONSTRAINT [FK_tbl_phieumuon_tbl_sach]
GO
ALTER TABLE [dbo].[tbl_sach]  WITH CHECK ADD  CONSTRAINT [FK_tbl_sach_tbl_phanloai] FOREIGN KEY([maloai])
REFERENCES [dbo].[tbl_phanloai] ([maloai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_sach] CHECK CONSTRAINT [FK_tbl_sach_tbl_phanloai]
GO
