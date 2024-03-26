CREATE TABLE [dbo].[DSCongViec] (
    [ID]         INT  IDENTITY (1, 1) NOT NULL,
    [IDTho]      NVARCHAR (50)  NULL,
    [IDUser]     NVARCHAR (50)  NULL,
    [TieuDe]     NVARCHAR (MAX) NULL,
    [LinhVuc]    NVARCHAR (50)  NULL,
    [KhuVuc]     NVARCHAR (50)  NULL,
    [Date]       DATETIME2 (7)  NULL,
    [TrangThai ] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


Insert into DSCongViec Values ('1', '2', N'Cần thuê thợ điện tử chuyên nghiệp cho dự án mới', N'Điện tử', N'Thủ Đức', N'2024-3-4', 'Đang thực hiện')
Insert into DSCongViec Values ('1', '1', N'Tìm kiếm thợ điện lạnh có kinh nghiệm tại khu vực đô thị mới', N'Điện lạnh', N'Quận 1', N'2024-10-4', 'Đã hoàn thành')
Insert into DSCongViec Values ('1', '1', N'Gấp! Tuyển dụng thợ sửa máy tính tại nhà', N'Điện tử', N'Quận 2', N'2024-20-4', 'Đang thực hiện')
Insert into DSCongViec Values ('1', '4', N'Cần thợ gia sư dạy kèm môn Toán lớp 10', N'Gia sư', N'Quận 3', N'2024-5-4', 'Đang thực hiện')
Insert into DSCongViec Values ('1', '2', N'Tìm thợ sửa nhà uy tín để cải thiện không gian sống', N'Sửa nhà', N'Quận 4', N'2024-30-4', 'Đã hoàn thành')
Insert into DSCongViec Values ('1', '2', N'Cần thuê thợ điện nước lành nghề cho công trình xây dựng', N'Điện nước', N'Quận 5', N'2024-27-4', 'Đang thực hiện')
