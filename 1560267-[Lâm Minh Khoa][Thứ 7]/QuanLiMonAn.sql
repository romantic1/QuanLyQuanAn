use master
go
if DB_ID('QuanLiQuanAn')is not null
drop database QuanLiQuanAn
go
create database QuanLiQuanAn
go
use QuanLiQuanAn
go
create table CHI_NHANH(
	Ma_CN char(10),
	Ten_CN nvarchar(20),
	SoDienThoai_CN char(10),
	DiaChi_CN nvarchar(20),
	TinhThanh nvarchar(10),
	primary key(Ma_CN)
)

go

create table BAN(
	Ma_Ban char(10),
	LoaiBan nvarchar(20),
	TinhTrangBan nvarchar(20),
	Ma_CN char(10),
	primary key(Ma_Ban)
)

go

create table NHAN_VIEN(
	Ma_NV char(10),
	Ma_CN char(10),
	Ten_NV nvarchar(50),
	CMND char(15) unique,
	SoDienThoai char(15),
	NgayBatDauLam datetime,
	ThamNien int,
	BoPhan nvarchar(20),
	CaLam nvarchar(20),
	Luong char(10),
	DanhGiaNhanVien nvarchar(100),
	primary key(Ma_NV)
)

go

alter table NHAN_VIEN
add constraint FK_NHAN_VIEN_CHI_NHANH
foreign key(MA_CN)
references CHI_NHANH(Ma_CN)


go

insert into CHI_NHANH
values('CN1',N'Chi Nhánh Quận 1','0909253152',N'200 Trần Hưng Đạo',N'Quận 1'),
		('CN2',N'Chi Nhánh Quận 2','0909253142',N'201 Bùi Viện',N'Quận 2'),
		('CN3',N'Chi Nhánh Quận 3','0909253115',N'204 Ung Văn Khiêm',N'Quận 3'),
		('CN4',N'Chi Nhánh Quận 4','0909253147',N'203 Lũy Bán Bích',N'Quận 4'),
		('CN5',N'Chi Nhánh Quận 5','0909253134',N'202 Nguyễn Văn Cừ',N'Quận 5'),
		('CN6',N'Chi Nhánh Quận 6','0909253172',N'206 Trần Cao Vân',N'Quận 6')

go

insert into BAN
values('B1',N'Bàn gỗ',N'Đang sử dụng','CN1'),
		('B5',N'Bàn cẩm thạch',N'Trống','CN2'),
		('B2',N'Bàn gỗ',N'Đang sử dụng','CN5'),
		('B3',N'Bàn inox',N'Trống','CN4'),
		('B6',N'Bàn gỗ',N'Đang sử dụng','CN4'),
		('B4',N'Bàn inox',N'Đang sử dụng','CN3'),
		('B8',N'Bàn gỗ',N'Trống','CN1')

go

insert into NHAN_VIEN
values('NV1','CN2',N'Nguyễn Văn A','22123654','0905232512','20100820','5',N'Bán hàng',N'Buổi sáng','15000',N'Tốt'),
		('NV2','CN3',N'Nguyễn Văn B','22123621','0905232542','20100720','3',N'Bán hàng',N'Buổi Tối','15000',N'Tốt'),
		('NV3','CN4',N'Nguyễn Văn C','22123615','0905232514','20100120','2',N'Phục Vụ',N'Buổi Chiều','15000',N'Tốt'),
		('NV4','CN5',N'Nguyễn Văn D','22123642','0905232572','20100320','4',N'Phục Vụ',N'Buổi Tối','15000',N'Tốt'),
		('NV5','CN1',N'Nguyễn Văn E','22123617','0905232592','20100420','5',N'Tạp Vụ',N'Buổi Chiều','15000',N'Tốt'),
		('NV6','CN6',N'Nguyễn Văn F','22123671','0905232545','20100520','1',N'Bán hàng',N'Buổi sáng','15000',N'Tốt')
		
