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