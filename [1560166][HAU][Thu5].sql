CREATE TABLE DANH_MUC_MON_AN
(
	ID char(10),
	TenDM nvarchar(30),
	Soluongmonan int,
	constraint PK_DANH_MUC_MON_AN
	primary key (ID)
)
CREATE TABLE DANH_SACH_MON_AN
(
	ID char(10),
	TenMA nvarchar(30),
	GIA float,
	IDDANHMUC char(10),
	constraint PK_DANH_SACH_MON_AN
	primary key (ID)
)
CREATE TABLE CHINHANH
(
	ID char(10),
	TenCNHANH nvarchar(30),
	DIACHI nvarchar(50),
	DIENTHOAI int,
	SOlUONGBAN int,
	constraint PK_CHINHANH
	primary key (ID)
)
CREATE TABLE MENU
(
	IDCHINHANH char(10),
	IDMONAN	char(10),
)

CREATE TABLE NHAN_VIEN
(
	IDNV char(10),
	TEN_NV varchar(20),
	CMND char(9),
	SDT_NV char(10),
	IDCN char(10),
	CALAM varchar(5),
	BOPHAN varchar(10),
	DANHGIA_NV float,
	THAMNIEN varchar(6),
	NGAYBATDAULAM datetime,
	LUONG float
	constraint PK_NHAN_VIEN
	primary key(IDNV)
)


CREATE TABLE KHACH_HANG
(
	IDKH char(10),
	TEN_KH varchar(20),
	DIACHI_KH varchar(30),
	SDT_KH char(10),
	constraint PK_KHACH_HANG
	primary key(IDKH)
)

CREATE TABLE ORDERMONAN
(	
	IDORDER char(10),
	IDCHINHANH char(10),
	IDMONAN	char(10),
	IDNV char(10),
	IDKHACHHANG char(10),
	constraint PK_ORDERMONAN
	primary key(IDORDER)
)

CREATE TABLE DON_HANG
(	IDDH char(10),
	IDORDER char(10),
	NGAYDAT datetime,
	KHUYENMAI varchar(20),
	PHISHIP float
	constraint PK_DON_HANG
	primary key(IDDH)
)

CREATE TABLE HOA_DON
(
	IDHD char(10),
	IDDH char(10),
	NGAYLAP_HD datetime,
	MATHE char(10),
	NGANHANG varchar(10),
	THUE float
	PRIMARY KEY(IDHD)
)

alter table DANH_SACH_MON_AN
add constraint PK_DANH_MUC_MON_AN_SACH_MUC_MON_AN
foreign key (IDDANHMUC)
references DANH_MUC_MON_AN(ID)

alter table MENU
add constraint PK_CHINHANH_MENU
foreign key (IDCHINHANH)
references CHINHANH(ID)

alter table MENU
add constraint PK_DANH_SACH_MON_AN_MENU
foreign key (IDMONAN)
references DANH_SACH_MON_AN(ID)

alter table NHAN_VIEN
add constraint PK_CHINHANH_NHAN_VIEN
foreign key (IDCN)
references CHINHANH(ID)

alter table DON_HANG
add constraint PK_ORDERMONAN_DON_HANG
foreign key (IDORDER)
references ORDERMONAN(IDORDER)

alter table HOA_DON
add constraint PK_DON_HANG_HOA_DON
foreign key (IDDH)
references DON_HANG(IDDH)

alter table ORDERMONAN
add constraint PK_CHINHANH_ORDERMONAN
foreign key (IDCHINHANH)
references CHINHANH(ID),
constraint PK_KHAC_HANG_ORDERMONAN
foreign key (IDKHACHHANG)
references KHACH_HANG(IDKH),
constraint PK_DANH_SACH_MON_AN_ORDERMONAN
foreign key (IDMONAN)
references DANH_SACH_MON_AN(ID),
constraint PK_NHAN_VIEN_ORDERMONAN
foreign key (IDNV)
references NHAN_VIEN(IDNV)