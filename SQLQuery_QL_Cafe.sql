CREATE DATABASE SQL_QLCafe
GO

USE SQL_QLCafe
GO

CREATE TABLE NHANVIEN
(
	MaNV varchar(20) PRIMARY KEY,
	HoTen nvarchar(50),
	ChucVu nvarchar(50),
	TenDN nvarchar(50) NOT NULL,
	MatKhau nvarchar(50) NOT NULL,
)
GO

INSERT INTO NHANVIEN(MaNV,HoTen,ChucVu,TenDN,MatKhau) VALUES
('4701104094',N'Đặng Quốc Hưng',N'Quản lý','4701104094','4701104094'),
('4701104109',N'Trần Nguyên Khang',N'Thu ngân','4701104109','4701104109'),
('4701104150',N'Đặng Minh Nhật',N'Pha chế','4701104150','4701104050'),
('4701104238',N'Nguyễn Hoàng Quốc Việt',N'Phục Vụ','4701104238','4701104238')
GO
