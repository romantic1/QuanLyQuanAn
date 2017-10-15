use master
if DB_ID('HoatDongTongDai')is not null
drop database HoatDongTongDai
go
create database HoatDongTongDai
go
use HoatDongTongDai
go
create table NhanVien(
	ma_nhanVien char(10),
	tenNhanVien nvarchar(100),
	caLamViec int,
	chucVu char(10),
	primary key(ma_nhanVien)
)

create table khachHang(
	ma_khachHang char(10),
	tenKhachHang nvarchar(100),
	tuoi int,
	diaChi nvarchar(100),
	soDienThoai char(15),
	soLanGiaoDich int,
	primary key(ma_khachHang)
)

create table hoaDon(
	ma_hoaDon char(10),
	maKhachHang char(10),
	tenHoaDon nvarchar(100),
	primary key(ma_hoaDon)
)

create table chiTietHoaDon(
	maHoaDon char(10),
	tenHoaDon nvarchar(100),
	maDanhSachMonAn char(10),
	donGia char(10),
	thanhTien char(10),
	tinhTrangSuDung char(10),
	thoiGian datetime,
	maNhanVien char(10),
	chiNhanh char(10)
)

create table danhSachMonAn(
	ma_danhSachMonAn char(10),
	tenMonAn char(10),
	donGia char(10),
	primary key(ma_danhSachMonAn)
)

alter table hoaDon
add constraint FK_hoaDon_khachHang
foreign key(makhachHang)
references khachHang(ma_khachHang)

alter table chiTietHoaDon
add constraint FK_chiTietHoaDon_hoaDon
foreign key(maHoaDon)
references hoaDon(ma_hoaDon)

alter table chiTietHoaDon
add constraint FK_chiTietHoaDon_danhSachMonAn
foreign key(maDanhSachMonAn)
references danhSachMonAn(ma_danhSachMonAn)

alter table chiTietHoaDon
add constraint FK_chiTietHoaDon_nhanVien
foreign key(maNhanVien)
references nhanVien(ma_nhanVien)