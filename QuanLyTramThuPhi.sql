Create database QuanLyTramThuPhi
Use QuanLyTramThuPhi
GO

Drop table Xe;
Drop table Ve;
Drop table TramThuPhi;
Drop table PhongBan;
Drop table NhanVien;
Drop table HauKiem;
Drop table XuLySaiPham;

Create table Xe(
	bienso char(10) primary key,
	tenloai nvarchar(20) not null,
	trongtai float check (trongtai >= 0));

Create table Ve(
	mave char(10) primary key,
	loaive nvarchar(5),
	ngayinve date,
	giatien int,
	bienso char(10),
	foreign key (bienso) references Xe(bienso));

Create table TramThuPhi(
	matram char(15) primary key,
	tentram nvarchar(20) not null,
	diachi nvarchar(20));

Create table PhongBan(
	mapb char(10) primary key,
	tenpb nvarchar(20) not null,
	matram char(15),
	foreign key (matram) references TramThuPhi(matram));

Create table NhanVien(
	manv char(10) primary key,
	tennv nvarchar(20) not null,
	ngaysinh date,
	mapb char(10),
	foreign key (mapb) references PhongBan(mapb));

Create table HauKiem(
	mahaukiem char(10) primary key,
	matram char(15),
	soxequatram int,
	tongtien float,
	manv char(10),
	foreign key (matram) references TramThuPhi(matram),
	foreign key (manv) references NhanVien(manv));

Create table XuLySaiPham(
	maloi char(10) primary key,
	tenloi nvarchar(20) not null,
	mucphat float,
	mave char(10),
	bienso char(10),
	foreign key (mave) references Ve(mave),
	foreign key (bienso) references Xe(bienso));
