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


Insert into Tho Values ('11', N'Ngô Minh An', '099900134386', '08765678542', '2016-10-23', N'Quận 2', N'Điện lạnh', N'Sửa máy lạnh', N'1 - 2 năm', 500000, 4)
Insert into Tho Values ('12', N'Trương Thị Yến Ngọc', '071200134386', '08765678542', '2005-11-20', N'Quận 1', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values ('13', N'Nguyễn Thị Thùy Dung', '020934623391', '08765678542', '2002-01-5', N'Quận 1', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values ('14', N'Nguyễn Văn Trọng', '087514705223', '08765678542', '1999-9-8', N'Quận 2', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values ('15', N'Trương Đức Hiệu', '034725622094', '08765678542', '2001-8-13', N'Quận 3', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values ('16', N'Nguyễn Thiên Nga', '011249001343', '08765678542', '2004-7-26', N'Quận 5', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values ('17', N'Trần Phú Quang', '099870013431', '08765678542', '2004-6-23', N'Quận 8', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values ('18', N'Phạm Thị Đăng Thơ', '01390201343', '08765678542', '2002-12-3', N'Quận 9', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values ('19', N'Lê Hữu Thắng', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values ('20', N'Lê Thị Thanh Phương', '085700134313', '08765678542', '1998-3-9', N'Bình Thạnh', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)


Insert into Tho Values ('21', N'Trần Nguyễn Minh Tuyền', '099900134386', '08765678542', '2016-10-23', N'Quận 4', N'Điện lạnh', N'Sửa máy lạnh', N'1 - 2 năm', 500000, 4)
Insert into Tho Values ('22', N'Nguyễn Thị Khánh', '071200134386', '08765678542', '2005-11-20', N'Quận 7', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values ('23', N'Nguyễn Gia Thuật', '020934623391', '08765678542', '2002-01-5', N'Quận 8', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values ('24', N'Nguyễn Ngọc Thơ', '087514705223', '08765678542', '1999-9-8', N'Quận 9', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values ('25', N'Nguyễn Văn Đông Nhi', '034725622094', '08765678542', '2001-8-13', N'Quận 2', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values ('26', N'Đỗ Thị Mai', '011249001343', '08765678542', '2004-7-26', N'Quận 1', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values ('27', N'Trương Phi Lâm', '099870013431', '08765678542', '2004-6-23', N'Quận 5', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values ('28', N'Lê Thị Diệu Linh', '01390201343', '08765678542', '2002-12-3', N'Quận 6', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values ('29', N'Bùi Thị Anh Tuyên', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values ('30', N'Nguyễn Văn Chuyển', '085700134313', '08765678542', '1998-3-9', N'Bình Thạnh', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)

Insert into Tho Values ('31', N'Trần Ngọc Nguyệt Nga', '099900134386', '08765678542', '2016-10-23', N'Quận 1', N'Điện lạnh', N'Sửa máy lạnh', N'1 - 2 năm', 500000, 4)
Insert into Tho Values ('32', N'Đặng Xuân Nhi', '071200134386', '08765678542', '2005-11-20', N'Quận 2', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values ('33', N'Ngô Công Huy', '020934623391', '08765678542', '2002-01-5', N'Quận 3', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values ('34', N'Lê Quang Anh', '087514705223', '08765678542', '1999-9-8', N'Quận 4', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values ('35', N'Ngô Văn Tư', '034725622094', '08765678542', '2001-8-13', N'Quận 5', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values ('36', N'Nguyễn Đình Huynh', '011249001343', '08765678542', '2004-7-26', N'Quận ', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values ('37', N'Lê Hoàng Kim Uyên', '099870013431', '08765678542', '2004-6-23', N'Quận 5', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values ('38', N'Ngô Minh An', '01390201343', '08765678542', '2002-12-3', N'Quận 6', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values ('39', N'Phan Anh Nhất', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values ('40', N'Đoàn Đại Dương', '085700134313', '08765678542', '1998-3-9', N'Quận 6', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)


Insert into Tho Values ('41', N'Lê Hoàng Kim Uyên', '099900134386', '08765678542', '2016-10-23', N'Quận 6', N'Điện lạnh', N'Sửa máy lạnh', N'1 - 2 năm', 500000, 4)
Insert into Tho Values ('42', N'Trần Đình Mạnh', '071200134386', '08765678542', '2005-11-20', N'Thủ Đức', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values ('43', N'Trần Tố Trinh', '020934623391', '08765678542', '2002-01-5', N'Quận 3', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values ('44', N'Võ Thị Thùy An', '087514705223', '08765678542', '1999-9-8', N'Quận 2', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values ('45', N'Sầm Hữu Thắng', '034725622094', '08765678542', '2001-8-13', N'Quận 4', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values ('46', N'Lê Thị Thuý Kiều', '011249001343', '08765678542', '2004-7-26', N'Quận ', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values ('47', N'Doãn Khắc Quân', '099870013431', '08765678542', '2004-6-23', N'Quận 5', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values ('48', N'Nguyễn Lê Thùy Duyên', '01390201343', '08765678542', '2002-12-3', N'Quận 6', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values ('49', N'Phạm Thị Thanh Bình', '011290013433', '08765678542', '2003-4-2', N'Bình Thạnh', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values ('50', N'Đỗ Thị Thảo Nguyên', '085700134313', '08765678542', '1998-3-9', N'Quận 6', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)

