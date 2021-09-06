/*ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
Create User PH4 IDENTIFIED By 1;
GRANT CONNECT, DBA TO PH4;
GRANT UNLIMITED TABLESPACE TO PH4;
grant all privileges to PH4;*/

CREATE TABLE NHANVIEN(
         MANV      VARCHAR2(5) PRIMARY KEY,
         TENNV      VARCHAR2(30),
         CONGVIEC    VARCHAR2(20),
         LUONGCOBAN        varchar2(60),
         PHUCAP     varchar2(60),
         MAKHOA     VARCHAR2(3)
);

CREATE TABLE KHOA(
         MAKHOA      VARCHAR2(3) PRIMARY KEY,
         TENKHOA      VARCHAR2(20)
);
ALTER TABLE NHANVIEN ADD CONSTRAINT NHANVIEN_FK1 FOREIGN KEY(MAKHOA)REFERENCES KHOA(MAKHOA)ON DELETE CASCADE ENABLE;

CREATE TABLE BENHNHAN(
         MABN      VARCHAR2(5) PRIMARY KEY,
         TENBN      VARCHAR2(30),
         NGAYSINH        DATE,
         DIACHI        VARCHAR2(40),
         SDT     NUMBER(12)
);

CREATE TABLE HOSOBENHAN(
         MAKB      VARCHAR2(5) PRIMARY KEY,
         NGAYKB      DATE,
         MATT        NUMBER(5),
         MABS        VARCHAR2(5),
         MABN       VARCHAR2(5),
         TINHTRANGBANDAU        VARCHAR2(50),
         KETLUANCUABACSI        VARCHAR2(50)
);
--ALTER TABLE HOSOBENHAN ADD CONSTRAINT HOSOBENHAN_FK1 FOREIGN KEY(MATT)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSOBENHAN ADD CONSTRAINT HOSOBENHAN_FK2 FOREIGN KEY(MABS)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSOBENHAN ADD CONSTRAINT HOSOBENHAN_FK3 FOREIGN KEY(MABN)REFERENCES BENHNHAN(MABN)ON DELETE CASCADE ENABLE;

CREATE TABLE HOSO_DICHVU(
         MAHS      VARCHAR2(5) PRIMARY KEY,
         MAKB      VARCHAR2(5),
         MADV      VARCHAR2(5),
         NGAYGIO        DATE,
         NGUOITHUCHIEN  VARCHAR2(5),
         KETLUAN        VARCHAR2(50)
);

CREATE TABLE DICHVU(
         MADV       VARCHAR2(5) PRIMARY KEY,
         TENDV      VARCHAR2(50),
         DONGIA     NUMBER(10)
);

ALTER TABLE HOSO_DICHVU ADD CONSTRAINT HOSO_DICHVU_FK1 FOREIGN KEY(MAKB)REFERENCES HOSOBENHAN(MAKB)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSO_DICHVU ADD CONSTRAINT HOSO_DICHVU_FK2 FOREIGN KEY(MADV)REFERENCES DICHVU(MADV)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSO_DICHVU ADD CONSTRAINT HOSO_DICHVU_FK3 FOREIGN KEY(NGUOITHUCHIEN)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;

CREATE TABLE DONTHUOC(
         MADT      VARCHAR2(5) PRIMARY KEY,
         MAKB      VARCHAR2(5),
         NVPT     VARCHAR2(5)
);
ALTER TABLE DONTHUOC ADD CONSTRAINT DONTHUOC_FK1 FOREIGN KEY(MAKB)REFERENCES HOSOBENHAN(MAKB)ON DELETE CASCADE ENABLE;
ALTER TABLE DONTHUOC ADD CONSTRAINT DONTHUOC_FK2 FOREIGN KEY(NVPT)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;

CREATE TABLE CHITIETDONTHUOC(
         MACT      NUMBER(5) PRIMARY KEY,
         MADT      VARCHAR2(5),
         MATHUOC      VARCHAR2(4),
         SL        NUMBER(5),
         LIEUDUNG  VARCHAR2(50),
         MOTA        VARCHAR2(50)
);

CREATE TABLE THUOC(
         MATHUOC      VARCHAR2(4) PRIMARY KEY,
         TENTHUOC      VARCHAR2(50),
         DONGIA      NUMBER(10),
         DVT       VARCHAR2(50),
         LUUY  VARCHAR2(50)
);

ALTER TABLE CHITIETDONTHUOC ADD CONSTRAINT CHITIETDONTHUOC_FK1 FOREIGN KEY(MADT)REFERENCES DONTHUOC(MADT)ON DELETE CASCADE ENABLE;
ALTER TABLE CHITIETDONTHUOC ADD CONSTRAINT CHITIETDONTHUOC_FK2 FOREIGN KEY(MATHUOC)REFERENCES THUOC(MATHUOC)ON DELETE CASCADE ENABLE;

CREATE TABLE HOADON(
         MAHD      VARCHAR2(5) PRIMARY KEY,
         MAKB      VARCHAR2(5),
         NGAYHD      DATE,
         NGUOIPT   VARCHAR2(5),
         TONGTIEN    NUMBER(10)
);
ALTER TABLE HOADON ADD CONSTRAINT HOADON_FK1 FOREIGN KEY(MAKB)REFERENCES HOSOBENHAN(MAKB)ON DELETE CASCADE ENABLE;
ALTER TABLE HOADON ADD CONSTRAINT HOADON_FK2 FOREIGN KEY(NGUOIPT)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;

CREATE TABLE CTHOADON(
         MACT_HD      VARCHAR2(5) PRIMARY KEY,
         MAHD      VARCHAR2(5),
         HANGMUC    VARCHAR2(50),
         SOTIEN    NUMBER(10)
);
ALTER TABLE CTHOADON ADD CONSTRAINT CTHOADON_FK1 FOREIGN KEY(MAHD)REFERENCES HOADON(MAHD)ON DELETE CASCADE ENABLE;

CREATE TABLE CHAMCONG(
         MACC      VARCHAR2(5) PRIMARY KEY,
         MANV      VARCHAR2(5),
         NGAY    DATE
);
ALTER TABLE CHAMCONG ADD CONSTRAINT CHAMCONG_FK1 FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;

CREATE TABLE TAIKHOAN(
         TENDN      VARCHAR2(5) PRIMARY KEY,
         MATKHAU      VARCHAR2(12),
         ROLENAME     VARCHAR2(12)
);
--------------------------------------------------------------------------MAHOA-----------------------------------------------------------------------
CREATE TABLE TEMP(
         ABC      VARCHAR2(5) PRIMARY KEY,
         XYZ      VARCHAR2(300)
);
INSERT INTO TEMP VALUES('1', 'KEYMAHOADLANTOANHETHONGTHONGTIN1');
--TAO FUNCTION DE AP DUNG VPD HAN CHE VIEC TRUY CAP LEN TABLE TEMP
create or replace FUNCTION VPD_TEMP(
p_schema IN VARCHAR2 DEFAULT NULL,
p_object IN VARCHAR2 DEFAULT NULL)
return varchar2 as
begin
    --CHI ADMIN DUOC QUYEN TRUY CAP
    if user = 'PH4' then
        return '1=1';
    else
        return '1=0';
    END IF;
end;
--TAO POLICY DE AP DUNG HAN CHE VIEC TRUY CAP LEN TABLE TEMP
BEGIN
    DBMS_RLS.add_policy
        (object_name => 'TEMP',
        policy_name => 'PREVENT_SELECT_ON_TEMP',
        policy_function => 'VPD_TEMP',
        statement_types => 'SELECT, INSERT, UPDATE, DELETE',
        update_check => TRUE);
END;
--Tao ham ma hoa chuoi
CREATE OR REPLACE FUNCTION Encryption(input_string IN VARCHAR2 DEFAULT NULL)
return RAW 
as
    KEY VARCHAR2(300);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    key_bytes_raw RAW (32); -- stores 256-bit encryption key 
    encryption_type PLS_INTEGER := -- total encryption type
    DBMS_CRYPTO.ENCRYPT_AES256
    + DBMS_CRYPTO.CHAIN_CBC
    + DBMS_CRYPTO.PAD_PKCS5;
begin
    --LAY KHOA TU TABLE LUU VAO BIEN KEY
    SELECT XYZ INTO KEY FROM TEMP;
    key_bytes_raw := UTL_RAW.cast_to_raw(KEY);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
    ( src => UTL_I18N.STRING_TO_RAW (input_string, 'AL32UTF8'),
    typ => encryption_type,
    key => key_bytes_raw
    );
    return encrypted_raw;
end;
/

--Tao ham giai ma chuoi
CREATE OR REPLACE FUNCTION Decryption(encrypted_raw IN RAW DEFAULT NULL)
return VARCHAR2 
as
    KEY VARCHAR2(300);
    output_string VARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    key_bytes_raw RAW (32); -- stores 256-bit encryption key 
    encryption_type PLS_INTEGER := -- total encryption type
    DBMS_CRYPTO.ENCRYPT_AES256
    + DBMS_CRYPTO.CHAIN_CBC
    + DBMS_CRYPTO.PAD_PKCS5;
begin
    --LAY KHOA TU TABLE LUU VAO BIEN KEY
    SELECT XYZ INTO KEY FROM TEMP;
    key_bytes_raw := UTL_RAW.cast_to_raw(KEY);
    decrypted_raw := DBMS_CRYPTO.DECRYPT
    (
    src => encrypted_raw,
    typ => encryption_type,
    key => key_bytes_raw
    );
    output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    return output_string;
end;
/
insert into KHOA values ('KH1','Bo phan quan ly');
insert into KHOA values ('KH2','TT dieu phoi benh');
insert into KHOA values ('KH3','?ieu tri');
insert into KHOA values ('KH4','Tai vu');
insert into KHOA values ('KH5','Ban thuoc');
insert into KHOA values ('KH6','Ke toan');


insert into NHANVIEN values ('NV001','Tran Truc','NVQLTainguyennhanSu',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH1');
insert into NHANVIEN values ('NV002','Le Minh','NVQLTaivu',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH1');
insert into NHANVIEN values ('NV003','Nguyen Hoai Nam','NVQLChuyenmon',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH1');
insert into NHANVIEN values ('NV004','Nguyen Tran Minh Truc','NVBPTieptandieuphoi',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH2');
insert into NHANVIEN values ('NV005','Le Thi Be','NVBPTieptandieuphoi',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH2');
insert into NHANVIEN values ('NV006','Nguyen Nam','NVTaivu',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH4');
insert into NHANVIEN values ('NV007','Nguyen Thi My','NVTaivu',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH4');
insert into NHANVIEN values ('NV008','Le Hoang','Bac si',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH3');
insert into NHANVIEN values ('NV009','Le Hoang Nam','Bac si',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH3');
insert into NHANVIEN values ('NV010','Tran Trung Kien','Bac si',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH3');
insert into NHANVIEN values ('NV011','Le Hoang Thai','Bac si',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH3');
insert into NHANVIEN values ('NV012','Le Thi Duyen','Bac si',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH3');
insert into NHANVIEN values ('NV013','Nguyen Tran Minh','NVBanthuoc',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH5');
insert into NHANVIEN values ('NV014','Vo Van Dai','NVBanthuoc',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH5');
insert into NHANVIEN values ('NV015','Vo Van Hoai','NVKetoan',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH6');
insert into NHANVIEN values ('NV016','Nguyen Thi Ha','NVKetoan',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH6');
insert into NHANVIEN values ('NV017','Nguyen Thi Hong','NVChamcong',ENCRYPTION('5000000'), ENCRYPTION('50000'),'KH1');


insert into BENHNHAN values ('BN001','Nguyen Hoai','17-NOV-1981','225 Nguyen Van Cu, TPHCM','0899795714');
insert into BENHNHAN values ('BN002','Nguyen Tran Trung','14-JUN-1984','214 Hung Vuong, TPHCM','0357225598');
insert into BENHNHAN values ('BN003','Le Thi Hien','23-JUL-1998','114 Truong Chinh, TPHCM','0351225589');
insert into BENHNHAN values ('BN004','Nguyen Vo Van','25-SEP-1997','116 Vo Van Kiet, TPHCM','0352778815');
insert into BENHNHAN values ('BN005','Le Hoang Nam','14-DEC-1988','256 Nguyen Thi Minh Khai, TPHCM','0351559935');
insert into BENHNHAN values ('BN006','Le Vo Van Son','04-JAN-1983','236 Nguyen Tri Phuong, TPHCM','0354112258');


insert into HOSOBENHAN values('MK001','17-MAY-2021',12,'NV008','BN001','xuat hien ban,mun nuoc toan than, met moi, sot','Benh thuy dau');
insert into HOSOBENHAN values('MK002','17-MAY-2021',13,'NV009','BN002','cung ham, co that hau hong thanh quan','Benh uon van');
insert into HOSOBENHAN values('MK003','17-MAY-2021',14,'NV010','BN003','Sot, roi loan y thuc, thieu mau, da xanh','Benh sot ret');

insert into DICHVU values('DV001','Xet nghiem huyet thanh hoc',50000);
insert into DICHVU values('DV002','Xet nghiem dich not phong',100000);
insert into DICHVU values('DV003','Xet nghiem KSTSR',100000);

insert into HOSO_DICHVU values('HS001','MK001','DV001','17-MAY-2021','NV004','Khong co');
insert into HOSO_DICHVU values('HS002','MK001','DV002','17-MAY-2021','NV004','Khong co');
insert into HOSO_DICHVU values('HS003','MK003','DV003','17-MAY-2021','NV004','Khong co');

insert into DONTHUOC values ('DT001','MK001','NV013');
insert into DONTHUOC values ('DT002','MK002','NV013');
insert into DONTHUOC values ('DT003','MK003','NV013');


insert into THUOC values ('T001','Acyclovir',150000,'mg','Khong co');
insert into THUOC values ('T002','Metronidazol',150000,'mg','Khong co');
insert into THUOC values ('T003','Diazepam',100000,'mg','Khong co');
insert into THUOC values ('T004','Midazolamm',100000,'mg','Khong co');
insert into THUOC values ('T005','Quinin',100000,'mg','Khong co');
insert into THUOC values ('T006','Doxycylin',100000,'mg','Khong co');

insert into CHITIETDONTHUOC values('001', 'DT001','T001',800,'800mg/ngay/5lan','Khong co');
insert into CHITIETDONTHUOC values('002', 'DT002','T002',500,'500mg/8h/lan','Khong co');
insert into CHITIETDONTHUOC values('003', 'DT002','T003',48,'2mg/1h/24h','Khong co');
insert into CHITIETDONTHUOC values('004', 'DT002','T004',5,'5mg/h','Khong co');
insert into CHITIETDONTHUOC values('005', 'DT003','T005',240,'30mg/ngay/7ngay','Khong co');
insert into CHITIETDONTHUOC values('006', 'DT003','T006',24,'3mg/ngay/7ngay','Khong co');

insert into HOADON values ('HD001','MK001','17-MAY-2021','NV014',300000);
insert into HOADON values ('HD002','MK002','17-MAY-2021','NV014',500000);
insert into HOADON values ('HD003','MK003','17-MAY-2021','NV014',500000);

insert into CTHOADON values ('CT001','HD001', 'Khong co', 300000);
insert into CTHOADON values ('CT002','HD002', 'Khong co', 500000);
insert into CTHOADON values ('CT003','HD003', 'Khong co', 500000);

insert into CHAMCONG values ('CC001','NV017','17-MAY-2021');
insert into CHAMCONG values ('CC002','NV017','18-MAY-2021');
insert into CHAMCONG values ('CC003','NV017','19-MAY-2021');

insert into CHAMCONG values ('CC004','NV016','17-MAY-2021');
insert into CHAMCONG values ('CC005','NV016','18-MAY-2021');
insert into CHAMCONG values ('CC006','NV016','19-MAY-2021');

insert into CHAMCONG values ('CC007','NV016','20-MAY-2021');
insert into CHAMCONG values ('CC008','NV016','21-MAY-2021');
insert into CHAMCONG values ('CC009','NV016','22-MAY-2021');

insert into CHAMCONG values ('CC010','NV015','20-JUNE-2021');
insert into CHAMCONG values ('CC011','NV015','21-JUNE-2021');
insert into CHAMCONG values ('CC012','NV015','22-JUNE-2021');

---------------------------------------------------------------------------DAC------------------------------------------------------------------------
--Tao va cap quyen
create user NV013 identified by 123456; 
grant connect to NV013;
grant create session to NV013;


create user NV014 identified by 123456; 
grant connect to NV014;
grant create session to NV014;


create user NV004 identified by 123456; 
grant connect to NV004;
grant create session to NV004;


create user NV005 identified by 123456; 
grant connect to NV005;
grant create session to NV005;



create or replace view Xem_thong_tin_toa_thuoc 
as
    select BENHNHAN.TENBN, THUOC.TENTHUOC, THUOC.DONGIA, CHITIETDONTHUOC.SL, CHITIETDONTHUOC.LIEUDUNG
    from THUOC 
    join CHITIETDONTHUOC 
    on CHITIETDONTHUOC.MATHUOC = THUOC.MATHUOC 
    join DONTHUOC 
    on CHITIETDONTHUOC.MADT = DONTHUOC.MADT
    join HOSOBENHAN 
    on HOSOBENHAN.MAKB = DONTHUOC.MAKB 
    join BENHNHAN 
    on BENHNHAN.MABN = HOSOBENHAN.MABN
    join NHANVIEN
    on NHANVIEN.MANV = DONTHUOC.NVPT 
    where CONGVIEC = 'NVBanthuoc';
grant select on Xem_thong_tin_toa_thuoc  to NV013;
grant select on Xem_thong_tin_toa_thuoc  to NV014;
-- them cot thuoc tinh luong
alter table DONTHUOC add SALARY NUMBER(10);
create or replace view Xem_chinh_sua_don_thuoc
as
	select *
	from DONTHUOC;
--
grant select on Xem_chinh_sua_don_thuoc to NV013;
grant update (NVPT,SALARY) on Xem_chinh_sua_don_thuoc to NV013;
grant select on Xem_chinh_sua_don_thuoc to NV014;
grant update (NVPT,SALARY) on Xem_chinh_sua_don_thuoc to NV014;


create or replace view Xem_chinh_sua_thong_tin_BN 
as
	select *from BENHNHAN;
grant select, insert, update on Xem_chinh_sua_thong_tin_BN to NV004;
grant select, insert, update on Xem_chinh_sua_thong_tin_BN to NV005;


create or replace view Xem_ho_so_benh_an
as
	select MAKB, NGAYKB, MATT,MABS, MABN, TINHTRANGBANDAU
	from HOSOBENHAN;
grant select on Xem_ho_so_benh_an to NV004;
grant select on Xem_ho_so_benh_an to NV005;



create or replace view Xem_ho_so_dich_vu
as
	select MAHS, MAKB, MADV, NGAYGIO, NGUOITHUCHIEN
	from HOSO_DICHVU;
grant select on Xem_ho_so_dich_vu to NV004;
grant select on Xem_ho_so_dich_vu to NV005;
---------------------------------------------------------------------------RBAC------------------------------------------------------------------------
--tao role quan ly chuyen mon
create role QLCHUYENMON;
--tao user thuoc role QLCHUYENMON 
CREATE USER QLCM1 IDENTIFIED BY 1;
GRANT CONNECT TO QLCM1;
GRANT QLCHUYENMON TO QLCM1;
--tao role nvketoan
create role nvketoan;
--tao user thuoc role nvketoan 
CREATE USER nvkt1 IDENTIFIED BY 1;
GRANT CONNECT TO nvkt1;
GRANT nvketoan TO nvkt1;
--procedure xem t?t c? b?ng c?a role QLCM.
create or replace procedure sp_Viewalltable(role_name in varchar2)
as
BEGIN
    EXECUTE IMMEDIATE 'GRANT SELECT ON NHANVIEN TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON BENHNHAN TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON CHAMCONG TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON CHITIETDONTHUOC TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON CTHOADON TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON DICHVU TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON DONTHUOC TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON HOADON TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON HOSO_DICHVU TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON HOSOBENHAN TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON KHOA TO ' || role_name;
    EXECUTE IMMEDIATE 'GRANT SELECT ON THUOC TO ' || role_name;     
END;
--proc c?p quy?n xem b?ng ch?m công và s?a b?ng nhân viên.
create or replace procedure sp_Grant_select_chamcong_update_nhanvien(rolename in varchar2)
as
BEGIN
    EXECUTE IMMEDIATE 'GRANT SELECT ON CHAMCONG TO ' || rolename;
    EXECUTE IMMEDIATE 'GRANT UPDATE ON NHANVIEN TO ' || rolename;
END;
--proc c?p quy?n xem b?ng nhân viên.
create or replace procedure sp_Grant_select_nhanvien
as
    temp sys_refcursor;
begin
open temp for
    select MANV, TENNV, CONGVIEC, LUONGCOBAN, PHUCAP, MAKHOA, LUONGCOBAN + PHUCAP AS LUONG from NHANVIEN;
    DBMS_SQL.RETURN_RESULT(temp);
end;
--cap quy?n
grant select on sp_Grant_select_nhanvien to NVKETOAN;
GRANT SELECT CHAMCONG TO NVKETOAN;
GRANT SELECT ON TEMP TO NVKETOAN;
grant select on tinhluong to NVKETOAN;
grant execute on decryption to NVKETOAN;
grant execute on Update_nhanvien to NVKETOAN;
---------------------------------------------------------------------------VPD------------------------------------------------------------------------
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
DROP USER NV008;
CREATE USER NV008 IDENTIFIED BY 123;
GRANT CONNECT TO NV008;
grant select, UPDATE on HOSOBENHAN TO NV008;

--VIEW BACSI_HOSO_DICHVU CHI HO TRO VIEC SELECT
grant select on BACSI_HOSO_DICHVU TO NV008;
--TABLE HOSO_DICHVU HO TRO VIEC INSERT UPDATE
GRANT INSERT, UPDATE ON HOSO_DICHVU TO NV008;
--VPD CHO CHINH SACH BACSI
--BAC SI CHI DUOC XEM HOSOBENHAN CO MABS CUA MINH
create or replace FUNCTION BacSi1(
p_schema IN VARCHAR2 DEFAULT NULL,
p_object IN VARCHAR2 DEFAULT NULL)
return varchar2 as
begin
    --LOAI USER ADMIN RA KHOI POLICY
    if user = 'PH4' then
        return '1=1';
    else
        return 'MABS=USER';
    END IF;
end;

--TAO POLICY VA GAN FUNCTION BACSI1 VAO
BEGIN
    DBMS_RLS.add_policy
        (object_name => 'HOSOBENHAN',
        policy_name => 'BACSIHOSOBENHAN',
        policy_function => 'BACSI1',
        statement_types => 'SELECT, UPDATE',
        update_check => TRUE);
END;
/
--TAO VIEW HOSODICHVU DE GAN THEM COT MABS VAO DE GIUP CHO VIEC SELECT VDP CUA BACSI
CREATE or REPLACE VIEW BACSI_HOSO_DICHVU AS 
    SELECT DV.*, BA.MABS 
    FROM HOSOBENHAN BA, HOSO_DICHVU DV 
    WHERE BA.MAKB=DV.MAKB;
--TAO FUNCTION BAC SI CHI DUOC XEM, THEM, SUA HO SO DICH VU MINH THUC HIEN HOAC CUA BENH NHAN MINH KHAM BENH
create or replace FUNCTION BacSi2(
p_schema IN VARCHAR2 DEFAULT NULL,
p_object IN VARCHAR2 DEFAULT NULL)
return varchar2 as
begin
    --LOAI USER ADMIN RA KHOI POLICY
    if user = 'PH1' then
        return '1=1';
    else
        return 'MABS=USER OR NGUOITHUCHIEN=USER';
    END IF;
end;
--TAO POLICY SELECT DOI VOI HOSODICHVU CUA BACSI
BEGIN
    DBMS_RLS.add_policy
        (object_name => 'BACSI_HOSO_DICHVU',
        policy_name => 'BACSIHOSODICHVU',
        policy_function => 'BACSI2',
        statement_types => 'SELECT',
        update_check => TRUE);
END;
/
--TAO POLICY INSERT, UPDATE DOI VOI HOSODICHVU CUA BACSI
BEGIN
    DBMS_RLS.add_policy
        (object_name => 'HOSO_DICHVU',
        policy_name => 'BACSIHOSODICHVU2',
        policy_function => 'BACSI2',
        statement_types => 'INSERT, UPDATE',
        update_check => TRUE);
END;
/
---------------------------------------------------------------------------AUDIT------------------------------------------------------------------------
--standard audit
alter system set audit_trail = db scope = spfile;

audit select, update on bacsi_hoso_dichvu;
audit update on nhanvien;
--xem d? li?u audit
select username, action_name from dba_audit_trail;
--fga audit 
BEGIN
    DBMS_FGA.ADD_POLICY(
    object_name => 'NHANVIEN',
    policy_name => 'CHECK_NHANVIEN',
    audit_column => 'LUONGCOBAN, PHUCAP',
    statement_types=> 'update,delete');
END;
--xem d? li?u audit
select * from dba_fga_audit_trail; 

---các proc và view h? tr? cho giao di?n
--Tao user 
create or replace procedure sp_TaoUser(user_name in varchar2, pass in varchar2)
as
temp varchar2(100);
begin
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    temp:= 'CREATE USER ' || user_name || ' IDENTIFIED BY ' || pass;
    execute immediate temp;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || user_name;
    INSERT INTO TAIKHOAN(TENDN, MATKHAU, ROLENAME) VALUES (user_name, pass, null);
end;
--proc kiem tra dang nhap
create or replace procedure SP_Check_Login(user_name varchar2, pass varchar2, checktype OUT int)
as
    temp number;
BEGIN
    select count(*) into temp from TAIKHOAN where TENDN = user_name and MATKHAU = pass;
    if temp > 0 then
        checktype := 1;
    else 
        checktype := 0;
    end if;
END;
--proc lay role cua user
create or replace procedure SP_GetRoleOfUser(user_name varchar2, temp_rolename OUT varchar2)
as
BEGIN
    select rolename into temp_rolename from TAIKHOAN WHERE TENDN = user_name;
END;
select ROLENAME from TAIKHOAN WHERE TENDN = 'QLCM1'
--Tao role 
create or replace procedure sp_Taorole(role_name in varchar2)
IS
begin
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'CREATE ROLE ' || role_name;
end;
--Cap role cho user
create or replace procedure sp_GrantRoleToUser(user_name in varchar2, role_name in varchar2)
as
temp VARCHAR2(500);
BEGIN
    temp := 'grant ' || role_name || ' TO ' || user_name;
    EXECUTE IMMEDIATE temp;
    UPDATE TAIKHOAN SET ROLENAME = role_name where TENDN = user_name;
END;
----------------------------------------------------------------------------------------------------------------------------------------------------------

