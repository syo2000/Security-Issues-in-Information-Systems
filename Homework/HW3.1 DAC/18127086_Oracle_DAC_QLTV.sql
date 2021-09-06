--Le Thi Thuy Duong
-- 18127086


--Tao bang chi tiet phieu muon
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE  Chitietphieumuon;
create table Chitietphieumuon
(
    Maphieumuonsach char(3) ,
    Masach char(4),
    Soluong number(2)
);


--Tao bang phieu muon sach
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE Phieumuonsach;
create table Phieumuonsach
(
    Maphieumuonsach char(3),
    Mathuvien char(3),
    Madocgia char(4),
    Thoigian date,
    Soluong number(2),
    Mathuthukymuon char(2),
    constraint Phieumuonsach_pk primary key(Maphieumuonsach)
    
);


--Tao bang Nhan vien
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE  Nhanvien;
create table Nhanvien
(
    Manhanvien char(2),
    Mathuvien char(3),
    Loai_nhan_vien char(3),
    Hoten varchar2(20),
    Ngaysinh date,
    Sdt char(10),
    Email varchar2(30),
    Luong number(7,2),
    constraint Nhanvien_pk primary key (Manhanvien)
    
);


--Tao bang SACH
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE Sach; 
create table Sach
(
    Masach char(4),
    Mathuvien char(3),
    Tensach varchar2(50),
    Loai_sach char(5),
    constraint Sach_pk primary key(Masach)
);


--Tao bang Loai sach
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE Loaisach;
create table Loaisach
(
    Maloaisach char(5),
    Tenloaisach varchar2(20),
    constraint Loaisach_pk primary key (Maloaisach)
);


--Tao bang Doc gia
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE Docgia;
create table Docgia
(
    Madocgia char(4),
    Hoten varchar2(20),
    CMND char(12),
    Sodienthoai char(10),
    Ngaysinh date,
    constraint Docgia_pk primary key (Madocgia)
);


--Tao bang thu vien
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE  Thuvien;
create table Thuvien
(
    Mathuvien char(3),
    Tenthuvien varchar2(40),
    constraint Thuvien_pk primary key(Mathuvien)
);


--Tao bang Loai nhan vien
WHENEVER SQLERROR CONTINUE NONE
DROP TABLE  Loainhanvien;
create table Loainhanvien
(
    Maloainhanvien char(3),
    Tenloainhanvien varchar2(20),
    constraint Loainhanvien_pk primary key(Maloainhanvien)
);


--Tao khoa ngoai
alter table Sach
add
    constraint Sach_Thuvien_fk
    foreign key (Mathuvien)
    references Thuvien(Mathuvien);


--Tao khoa ngoai
alter table Sach
add
    constraint Sach_Loaisach_fk
    foreign key (Loai_sach)
    references Loaisach(Maloaisach);


--Tao khoa ngoai    
alter table Phieumuonsach
add
    constraint Phieumuonsach_Thuvien_fk
    foreign key(Mathuvien)
    references Thuvien(Mathuvien);


--Tao khoa ngoai
alter table Phieumuonsach
add
    constraint Phieumuonsach_Docgia_fk
    foreign key(Madocgia)
    references Docgia(Madocgia);
    
    
--Tao khoa ngoai
alter table Phieumuonsach
add
    constraint Phieumuonsach_Nhanvien_fk
    foreign key(Mathuthukymuon)
    references Nhanvien(Manhanvien);
    
    
--Tao khoa ngoai
alter table Chitietphieumuon
add
    constraint Chitietphieumuon_Phieumuonsach_fk
    foreign key(Maphieumuonsach)
    references Phieumuonsach(Maphieumuonsach);
    
    
--Tao khoa ngoai
alter table Chitietphieumuon
add
    constraint Chitietphieumuon_Sach_fk
    foreign key(Masach)
    references Sach(Masach);
    
    
--Tao khoa ngoai
alter table Nhanvien
add
    constraint Nhanvien_Thuvien_fk
    foreign key(Mathuvien)
    references Thuvien(Mathuvien);
    
    
--Tao khoa ngoai
alter table Nhanvien
add
    constraint Nhanvien_Loainhanvien_fk
    foreign key(Loai_nhan_vien)
    references Loainhanvien(Maloainhanvien);


--Nhap lieu cho bang Doc gia
insert into Docgia values ('DG01','KEN','301742145','0357489324','15-FEB-1998');
insert into Docgia values ('DG02','HALEN','301784156','0357119635','12-MAY-1989');
insert into Docgia values ('DG03','ZEN','301784129','0354771186','01-JUN-1986');


--Nhap lieu cho bang Loai sach
insert into Loaisach values ('MLS01','Novel');
insert into Loaisach values ('MLS02','Books and newspapers');
insert into Loaisach values ('MLS03','Journa');


--Nhap lieu cho bang loai nhan vien
insert into Loainhanvien values ('ML1','Librarian');
insert into Loainhanvien values ('ML2','Manager');


--Nhap lieu cho bang thu vien
insert into Thuvien values ('TV1','Book Mountain and Library Quarter');
insert into Thuvien values ('TV2','Library Birmingham');
insert into Thuvien values ('TV3','Vennesla Library and Culture House');


--Nhap lieu cho bang Sach
insert into Sach values ('MS01','TV1','The Little Prince','MLS01');
insert into Sach values ('MS02','TV2','The Catcher In The Rye','MLS01');
insert into Sach values ('MS03','TV3','To Kill a Mockingbird','MLS01');
insert into Sach values ('MS04','TV2','Life Of Pi','MLS01');
insert into Sach values ('MS05','TV3','The Alchemist','MLS01');
insert into Sach values ('MS06','TV1','Harry Potter','MLS01');
insert into Sach values ('MS07','TV2','The Lord Of The Rings','MLS01');


--Nhap lieu cho bang Nhan vien
insert into Nhanvien values('N1','TV2','ML1','DEN','02-FEB-1992','0354771145','587hy@gmail.com',1000);
insert into Nhanvien values('N2','TV1','ML1','ANNI','05-JUN-1987','0356881126','tthu@gmail.com',1000);
insert into Nhanvien values('N3','TV1','ML2','TEN','25-FEB-1993','0357778894','25hy@gmail.com',2000);
insert into Nhanvien values('N4','TV3','ML2','JENLY','26-MAY-1984','0354112269','httg@gmail.com',2000);
insert into Nhanvien values('N5','TV2','ML2','HANG','24-FEB-1988','0354884469','89tg@gmail.com',2000);
insert into Nhanvien values('N6','TV2','ML1','JONG','26-JUN-1983','0354112698','h7tg@gmail.com',1000);
insert into Nhanvien values('N7','TV1','ML1','NORTON','08-MAY-1994','0351118841','h7tg@gmail.com',1000);
insert into Nhanvien values('N8','TV3','ML1','FISCHL','01-FEB-1992','0357883356','ht15@gmail.com',2000);
insert into Nhanvien values('N9','TV3','ML1','JENNY','09-JUN-1985','0357114456','g7zg@gmail.com',1000);


--Nhap lieu cho bang phieu muon sach
insert into Phieumuonsach values('PM1','TV1','DG01','15-FEB-2020',1,'N2');
insert into Phieumuonsach values('PM2','TV3','DG02','05-MAY-2020',1,'N8');
insert into Phieumuonsach values('PM3','TV2','DG03','26-JUN-2020',1,'N1');


--Nhap lieu cho bang Chi tiet phieu muon
insert into Chitietphieumuon values('PM1','MS01',1);
insert into Chitietphieumuon values('PM2','MS05',1);
insert into Chitietphieumuon values('PM3','MS07',1);

alter session set "_ORACLE_SCRIPT"=true; 


--Tao nhom nguoi dung
create role Doc_gia;
create role Thu_thu;
create role Quan_li;


--Tao va cap quyen
create user DG01 identified by docgia1; 
grant connect to DG01;
grant create session to DG01;
grant Doc_gia to DG01;


--Tao va cap quyen
create user DG02 identified by docgia2; 
grant connect to DG02;
grant create session to DG02;
grant Doc_gia to DG02;


--Tao va cap quyen
create user DG03 identified by docgia3; 
grant connect to DG03;
grant create session to DG03;
grant Doc_gia to DG03;


--Doc gia xem lai cac phieu muon sach da muon: Ma phieu muon sach, Ma doc gia, So luong, 
--Ma sach, Ten sach da muon cung so luong. Khong duoc phep xem nhung phieu
--muon sach cua doc gia khac
create or replace view Xem_DS_phieu_muon as
    select Phieumuonsach.Madocgia, Chitietphieumuon.Maphieumuonsach , Phieumuonsach.Soluong as Soluongphieu,
    Chitietphieumuon.Masach , Chitietphieumuon.Soluong as Soluongsach
    , Sach.Tensach as Tensach 
    from Chitietphieumuon  
    join Sach 
    on Chitietphieumuon.Masach = Sach.Masach
    join Phieumuonsach  
    on Phieumuonsach.Maphieumuonsach = Chitietphieumuon.Maphieumuonsach 
    where Phieumuonsach.Madocgia = user; 
  
  
--Cap quyen xem view Xem_DS_phieu_muon cho Doc gia    
grant select on Xem_DS_phieu_muon to Doc_gia;


--Doc gia xem thong tin tai khoan: khong duoc phep xem thong tin tai khoan cua doc gia khac
create or replace view Xem_Thong_tin_TK as
    select *
    from Docgia
    where Madocgia = user;


--Cap quyen xem view  Xem_Thong_tin_TK cho Doc gia
grant select on Xem_Thong_tin_TK to Doc_gia;


--Tao va cap quyen
create user N1 identified by thuthu1; 
grant connect to N1;
grant create session to N1;
grant Thu_thu to N1;


--Tao va cap quyen
create user N2 identified by thuthu2; 
grant connect to N2;
grant create session to N2;
grant Thu_thu to N2;


--Tao va cap quyen
create user N6 identified by thuthu6; 
grant connect to N6;
grant create session to N6;
grant Thu_thu to N6;


--Tao va cap quyen
create user N7 identified by thuthu7; 
grant connect to N7;
grant create session to N7;
grant Thu_thu to N7;


--Tao va cap quyen
create user N8 identified by thuthu8; 
grant connect to N8;
grant create session to N8;
grant Thu_thu to N8;


--Tao va cap quyen
create user N9 identified by thuthu9; 
grant connect to N9;
grant create session to N9;
grant Thu_thu to N9;


-- Thu thu xem thong tin ca nhan
--Khong duoc phep xem thong tin tai khoan cua nhan vien khac
create or replace view Xem_Thong_tin_TK_TT as
    select *
    from Nhanvien
    where Manhanvien = user;   
    
    
--Cap quyen xem view Xem_Thong_tin_TK_TT cho thu thu
grant select on Xem_Thong_tin_TK_TT to Thu_thu;


--Thu thu xem danh sach cac phieu muon
--Chi duoc phep xem thong tin phieu muon o thu vien cua chinh minh
--Chi duoc phep xem thong tin phieu muon do chinh thu thu do da ki
create or replace view DS_phieumuon_TT as
    select *
    from Phieumuonsach
    where Mathuthukymuon = user;
    
    
--Cap quyen xem view DS_phieumuon_TT cho Thu thu
grant select on DS_phieumuon_TT to Thu_thu;

    
--Tao use va cap quyen
create user N3 identified by quanli3; 
grant connect to N3;
grant create session to N3;
grant Quan_li to N3;


--Tao user va cap quyen
create user N4 identified by quanli4; 
grant connect to N4;
grant create session to N4;
grant Quan_li to N4;


--Tao user va cap quyen
create user N5 identified by quanli5; 
grant connect to N5;
grant create session to N5;
grant Quan_li to N5;


--View
--Quan li xem thong tin ca nhan
--Khong duoc phep xem thong tai khoan cua nhan vien khac
create or replace view Xem_Thong_tin_TK_QL as
    select *
    from Nhanvien
    where Manhanvien = user;  
    
    
--Cap quyen xem view Xem_Thong_tin_TK_QL cho Quan li
grant select on Xem_Thong_tin_TK_QL to Quan_Li;


--View
--Quan li xem thong tin tat ca thu thu
--Khong duoc xem thuoc tinh luong
--Chi duoc xem nhung thu thulam viec tai thu vien cua minh
create or replace view Xem_Thong_tin_thu_thu as
    select NV.Manhanvien, NV.Mathuvien,NV.Loai_nhan_vien,NV.Hoten,NV.Ngaysinh,NV.SDT,NV.Email
    from Nhanvien NV
    join Nhanvien NV1
    on NV.Mathuvien = NV1.Mathuvien
    join Loainhanvien LNV
    on NV.Loai_nhan_vien = LNV.Maloainhanvien   
    where LNV.Tenloainhanvien = 'Librarian' and NV1.Manhanvien = user;


--Cap quyen xem view Xem_Thong_tin_thu_thu cho Quan li
grant select on Xem_Thong_tin_thu_thu to Quan_Li;

