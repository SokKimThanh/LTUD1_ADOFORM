--use master;
--drop database QUANLYBANHANG;
--create database QUANLYBANHANG;
--use QUANLYBANHANG;
--go

-- tao bang san pham
create table sanpham(
	ma nvarchar(11) not null,
	ten nvarchar(256),
	gia money,
	soluong int,
	nhacungcap nvarchar(11) null,
	danhmuc nvarchar(11) null
)
go

-- tao bang danh muc
create table danhmuc(
	ma nvarchar(11) not null,
	ten nvarchar(256),
	ghichu nvarchar(256)
)
go

-- tao bang nhacungcap
create table nhacungcap(
	ma nvarchar(11) not null,
	ten nvarchar(256),
	ghichu nvarchar(256)
)
go

-- khoa chinh
alter table sanpham add constraint pk_sanpham primary key (ma);
alter table nhacungcap add constraint pk_nhacungcap primary key (ma);
alter table danhmuc add constraint pk_danhmuc primary key (ma);
go

-- khoa ngoai
alter table sanpham add constraint fk_sanpham_nhacungcap foreign key(nhacungcap) references nhacungcap(ma);
alter table sanpham add constraint fk_sanpham_danhmuc foreign key(danhmuc) references danhmuc(ma);
go

-- gia tri mac dinh
alter table sanpham add constraint df_gia default 0 for gia;
alter table sanpham add constraint df_soluong default 0 for soluong;
go

-- gia tri duy nhat
alter table sanpham add constraint uq_ten unique(ten);
go



-- insert into 
insert into danhmuc (ma,ten,ghichu) values
('dm0111','danhmuc 1', 'danhmuc 00111'),
('dm0112','danhmuc 2', 'danhmuc 00112')

insert into nhacungcap (ma,ten,ghichu) values
('ncc0111','nhacungcap 1', 'nhacungcap 00111'),
('ncc0112','nhacungcap 2', 'nhacungcap 00112')

insert into sanpham (ma,ten,gia,soluong, nhacungcap,danhmuc) values
('sp1','sanpham1',333, 3000, 'ncc0111', 'dm0111'),
('sp2','sanpham2',334, 4000, 'ncc0111', 'dm0111'),
('sp3','sanpham3',336, 1000, 'ncc0112', 'dm0111'),
('sp4','sanpham4',335, 2000, 'ncc0112', 'dm0111')

