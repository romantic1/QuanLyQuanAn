use master
go
if DB_ID('QuanLiNhaHang')is not null
drop database QuanLiNhaHang
go
create database QuanLiNhaHang
go
use QuanLiNhaHang
go
create table danhMucMonAn(
	ma_danhMucMonAn char(10),
	tenDanhMuc nvarchar(100),
	primary key(ma_danhMucMonAn)
)

create table danhSachMonAn(
	ma_danhSachMonAn char(10),
	maDanhMucMonAn char(10),
	tenMonAn nvarchar(10),
	ghiChu nvarchar(10),
	giaCa char(10),
	thongTinVeMon  nvarchar(100),
	primary key(ma_danhSachMonAn)
)

create table chiNhanhMoi(
	ma_chiNhanhMoi char(10),
	tenChiNhanh nvarchar(100),
	diaChi nvarchar(100),
	primary key(ma_chiNhanhMoi)
)

create table chiTietChiNhanh(
	machiNhanhMoi char(10),
	tenChiNhanh nvarchar(100),
	coTang2 char(5),
	soBanGheTaiChiNhanh int,
	tinhTrangCuaBan char(10),
	soBanGheTang2_NeuCo int null,
	maDanhMucMonAn char(10),
	maDanhSachMonAn char(10)
)
go

alter table danhSachMonAn
add constraint FK_danhSachMonAn_danhMucMonAn
foreign key(maDanhMucMonAn)
references danhMucMonAn(ma_danhMucMonAn)

alter table chiTietChiNhanh
add constraint FK_chiTietChiNhanh_chiNhanhMoi
foreign key(machiNhanhMoi)
references chiNhanhMoi(ma_chiNhanhMoi)

alter table chiTietChiNhanh
add constraint FK_chiTietChiNhanh_danhMucMonAn
foreign key(maDanhMucMonAn)
references danhMucMonAn(ma_danhMucMonAn)

alter table chiTietChiNhanh
add constraint FK_chiTietChiNhanh_danhSachMonAn
foreign key(maDanhSachMonAn)
references danhSachMonAn(ma_danhSachMonAn)