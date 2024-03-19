CREATE TABLE [dbo].[Tho]
(
	[Id] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [HoTen] NVARCHAR(50) NULL, 
    [CCCD] NVARCHAR(50) NULL, 
    [SDT] NVARCHAR(50) NULL, 
    [Dob] DATETIME2 NULL, 
    [KhuVuc] NVARCHAR(50) NULL, 
    [LinhVuc] NVARCHAR(50) NULL, 
    [ChuyenMon] NVARCHAR(MAX) NULL, 
    [GiaTien] INT NULL, 
    [DanhGia] FLOAT NULL
	
)

Insert into Tho Values ('1', N'Nguyễn Ngọc Hoàng', '099900134386', '08765678542', '2016-10-23', N'Quận 1', N'Điện lạnh', N'Sửa máy lạnh', N'1 - 2 năm', 500000, 4)
Insert into Tho Values ('2', N'Lê Hoài An', '071200134386', '08765678542', '2005-11-20', N'Quận 2', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values ('3', N'Trịnh Phúc Bảo', '020934623391', '08765678542', '2002-01-5', N'Quận 3', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values ('4', N'Võ Minh Hiếu', '087514705223', '08765678542', '1999-9-8', N'Quận 4', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values ('5', N'Nguyễn Hồng Sơn', '034725622094', '08765678542', '2001-8-13', N'Quận 5', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values ('6', N'Nguyễn Nhựt Tân', '011249001343', '08765678542', '2004-7-26', N'Quận 7', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values ('7', N'Hoàng Bảo Ngọc', '099870013431', '08765678542', '2004-6-23', N'Quận 8', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values ('8', N'Lê Minh Tân', '01390201343', '08765678542', '2002-12-3', N'Quận 9', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values ('9', N'Phan Phúc Bảo', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values ('10', N'Nguyễn Đức Toàn', '085700134313', '08765678542', '1998-3-9', N'Bình Thạnh', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)
