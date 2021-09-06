--Tao user voi quyen DBA
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
Create User PH1 IDENTIFIED By 123;
GRANT CONNECT, DBA TO PH1;
GRANT UNLIMITED TABLESPACE TO PH1;
grant all privileges to PH1;

--Script tao Database
CREATE TABLE NHANVIEN(
         MANV      NUMBER(5) PRIMARY KEY,
         TENNV      VARCHAR2(10),
         CONGVIEC        VARCHAR2(20),
         LUONG        NUMBER(7,2),
         MAKHOA     NUMBER(5)
);

CREATE TABLE KHOA(
         MAKHOA      NUMBER(5) PRIMARY KEY,
         TENKHOA      VARCHAR2(10)
);
ALTER TABLE NHANVIEN ADD CONSTRAINT NHANVIEN_FK1 FOREIGN KEY(MAKHOA)REFERENCES KHOA(MAKHOA)ON DELETE CASCADE ENABLE;

CREATE TABLE BENHNHAN(
         MABN      NUMBER(5) PRIMARY KEY,
         TENBN      VARCHAR2(10),
         NGAYSINH        DATE,
         DIACHI        VARCHAR2(20),
         SDT     NUMBER(12)
);

CREATE TABLE HOSOBENHAN(
         MAKB      NUMBER(5) PRIMARY KEY,
         NGAYKB      DATE,
         MATT        NUMBER(5),
         MABS        NUMBER(5),
         MABN        NUMBER(5),
         TINHTRANGBANDAU        VARCHAR2(50),
         KETLUANCUABACSI        VARCHAR2(50)
);
ALTER TABLE HOSOBENHAN ADD CONSTRAINT HOSOBENHAN_FK1 FOREIGN KEY(MATT)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSOBENHAN ADD CONSTRAINT HOSOBENHAN_FK2 FOREIGN KEY(MABS)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSOBENHAN ADD CONSTRAINT HOSOBENHAN_FK3 FOREIGN KEY(MABN)REFERENCES BENHNHAN(MABN)ON DELETE CASCADE ENABLE;

CREATE TABLE HOSO_DICHVU(
         MAHS      NUMBER(5) PRIMARY KEY,
         MAKB      NUMBER(5),
         MADV      NUMBER(5),
         NGAYGIO        DATE,
         NGUOITHUCHIEN  NUMBER(5),
         KETLUAN        VARCHAR2(50)
);

CREATE TABLE DICHVU(
         MADV      NUMBER(5) PRIMARY KEY,
         TENDV      VARCHAR2(50),
         DONGIA     NUMBER(10)
);

ALTER TABLE HOSO_DICHVU ADD CONSTRAINT HOSO_DICHVU_FK1 FOREIGN KEY(MAKB)REFERENCES HOSOBENHAN(MAKB)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSO_DICHVU ADD CONSTRAINT HOSO_DICHVU_FK2 FOREIGN KEY(MADV)REFERENCES DICHVU(MADV)ON DELETE CASCADE ENABLE;
ALTER TABLE HOSO_DICHVU ADD CONSTRAINT HOSO_DICHVU_FK3 FOREIGN KEY(NGUOITHUCHIEN)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;

CREATE TABLE DONTHUOC(
         MADT      NUMBER(5) PRIMARY KEY,
         MAKB      NUMBER(5),
         NVPT     NUMBER(5)
);
ALTER TABLE DONTHUOC ADD CONSTRAINT DONTHUOC_FK1 FOREIGN KEY(MAKB)REFERENCES HOSOBENHAN(MAKB)ON DELETE CASCADE ENABLE;
ALTER TABLE DONTHUOC ADD CONSTRAINT DONTHUOC_FK2 FOREIGN KEY(NVPT)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;

CREATE TABLE CHITIETDONTHUOC(
         MACT      NUMBER(5) PRIMARY KEY,
         MADT      NUMBER(5),
         MATHUOC      NUMBER(5),
         SL        NUMBER(5),
         LIEUDUNG  VARCHAR2(50),
         MOTA        VARCHAR2(50)
);

CREATE TABLE THUOC(
         MATHUOC      NUMBER(5) PRIMARY KEY,
         TENTHUOC      VARCHAR2(50),
         DONGIA      NUMBER(10),
         DVT       VARCHAR2(50),
         LUUY  VARCHAR2(50)
);
ALTER TABLE CHITIETDONTHUOC ADD CONSTRAINT CHITIETDONTHUOC_FK1 FOREIGN KEY(MADT)REFERENCES DONTHUOC(MADT)ON DELETE CASCADE ENABLE;
ALTER TABLE CHITIETDONTHUOC ADD CONSTRAINT CHITIETDONTHUOC_FK2 FOREIGN KEY(MATHUOC)REFERENCES THUOC(MATHUOC)ON DELETE CASCADE ENABLE;

--HOSO_DICHVU(MAKB, MADV, NGAYGIO, NGUOITHUCHIEN, KETLUAN)
--DICHVU(MADV, TENDV, DONGIA)
--DONTHUOC(MAKB, NVPT)
--CHITIETDONTHUOC(MAKB, MATHUOC, SL, LIEUDUNG, MOTA)
--THUOC(MATHUOC,TENTHUOC, DVT, DONGIA, LUUY)
--HOADON(SOHD, MAKB, NGAYHD, NGUOIPT, TONGTIEN)
--CTHDON(SOHD, HANGMUC, SOTIEN)
--CHAMCONG(MANV, NGAY,THOIGIAN)

CREATE TABLE HOADON(
         MAHD      NUMBER(5) PRIMARY KEY,
         MAKB      NUMBER(5),
         NGAYHD      DATE,
         NGUOIPT        NUMBER(5),
         TONGTIEN    NUMBER(10)
);
ALTER TABLE HOADON ADD CONSTRAINT HOADON_FK1 FOREIGN KEY(MAKB)REFERENCES HOSOBENHAN(MAKB)ON DELETE CASCADE ENABLE;
ALTER TABLE HOADON ADD CONSTRAINT HOADON_FK2 FOREIGN KEY(NGUOIPT)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;

CREATE TABLE CTHOADON(
         MACT_HD      NUMBER(5) PRIMARY KEY,
         MAHD      NUMBER(5),
         HANGMUC    VARCHAR2(50),
         SOTIEN    NUMBER(10)
);
ALTER TABLE CTHOADON ADD CONSTRAINT CTHOADON_FK1 FOREIGN KEY(MAHD)REFERENCES HOADON(MAHD)ON DELETE CASCADE ENABLE;

CREATE TABLE CHAMCONG(
         MACC      NUMBER(5) PRIMARY KEY,
         MANV      NUMBER(5),
         NGAY    TIMESTAMP
);
ALTER TABLE CHAMCONG ADD CONSTRAINT CHAMCONG_FK1 FOREIGN KEY(MANV)REFERENCES NHANVIEN(MANV)ON DELETE CASCADE ENABLE;


--Script Store
--1/Xem danh sach nguoi dung trong he thong
create or replace procedure sp_Xemdanhsachnguoidung
as
    temp sys_refcursor;
begin
open temp for
    SELECT * FROM all_users;
    DBMS_SQL.RETURN_RESULT(temp);
end;
--2/ Thong tin ve quyen cua moi user/role tren cac doi tuong du lieu
--Hien thi quyen cua user tren cac cot cua bang
create or replace procedure sp_UserXemQuyenTrenCot
as
    temp sys_refcursor;
begin
    open temp for
        --SELECT * FROM USER_TAB_PRIVS;
        SELECT GRANTEE, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE FROM USER_COL_PRIVS;
    DBMS_SQL.RETURN_RESULT(temp);
end;
--Hien thi quyen cua user/role tren cac bang
create or replace procedure sp_UserXemQuyenTrenBang
as
    temp sys_refcursor;
begin
    open temp for
        SELECT GRANTEE, TABLE_NAME, PRIVILEGE, GRANTABLE FROM USER_TAB_PRIVS;
    DBMS_SQL.RETURN_RESULT(temp);
end;
--Hien thi role cua user
create or replace procedure sp_XemRoleCuaUser
as
    temp sys_refcursor;
begin
    open temp for
        SELECT USERNAME, GRANTED_ROLE FROM USER_ROLE_PRIVS;
    DBMS_SQL.RETURN_RESULT(temp);
end;
--Hien thi quyen cua role tren system
create or replace procedure sp_RoleXemQuyenHeThong
as
    temp sys_refcursor;
begin
    open temp for
        SELECT ROLE, PRIVILEGE FROM ROLE_SYS_PRIVS;
    DBMS_SQL.RETURN_RESULT(temp);
end;
--Hien thi quyen cua role tren bang
create or replace procedure sp_RoleXemQuyenTrenBang
as
    temp sys_refcursor;
begin
    open temp for
        SELECT ROLE, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE FROM ROLE_TAB_PRIVS;
    DBMS_SQL.RETURN_RESULT(temp);
end;
--3/Cho phep tao moi, xoa, sua user/role
--Tao user 
create or replace procedure sp_TaoUser(user_name in varchar2, password varchar2, tablespace_name varchar2, quota varchar2)
as
temp varchar2(100);
begin
    temp:= 'CREATE USER ' || user_name || ' IDENTIFIED BY ' || password || ' default tablespace ' || tablespace_name || ' quota ' || quota || ' on ' || tablespace_name;
    execute immediate temp;
end;
--exec sp_TaoUser('smith', '123', 'SYSTEM', '1M');

--Tao role 
create or replace procedure sp_Taorole(role_name in varchar2)
IS
begin
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'CREATE ROLE ' || role_name;
end;

--Xoa user
create or replace procedure sp_Xoauser(user_name in varchar2)
as
begin
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'DROP USER ' || user_name;
end;
--Xoa role
create or replace procedure sp_Xoarole(role_name in varchar2)
IS
begin
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'DROP ROLE ' || role_name;
end;

--Sua password user
create or replace procedure sp_Suauser(user_name in varchar2, new_user_password in varchar2)
as
begin
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE 'ALTER USER ' || user_name || ' IDENTIFIED BY ' || new_user_password;
end;

--Chinh sua tablespace cua user
create or replace procedure sp_UpdateTablespaceUser(user_name in varchar2, new_tablespace varchar2)
as
temp VARCHAR2(500);
temp1 VARCHAR2(100);
BEGIN
    temp1 := 'alter session set "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE temp1;
    temp := 'alter user ' || user_name || ' default tablespace ' || new_tablespace;
    EXECUTE IMMEDIATE temp;
END;
--exec sp_UpdateTablespaceUser('JOHN', 'SYSTEM');

--Chinh sua quota cua user
create or replace procedure sp_UpdateQuotaUser(user_name in varchar2, new_Quota varchar2, tablespace_name varchar2)
as
temp VARCHAR2(500);
temp1 VARCHAR2(100);
BEGIN
    temp1 := 'alter session set "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE temp1;
    temp := 'alter user ' || user_name || ' quota ' || new_Quota || ' on ' || tablespace_name;
    EXECUTE IMMEDIATE temp;
END;
--exec sp_UpdateQuotaUser('JOHN', '1M', 'SYSTEM');

--4/Cho phep thuc hien viec cap quyen
--Cap role cho user
create or replace procedure sp_GrantRoleToUser(user_name in varchar2, role_name in varchar2)
as
temp VARCHAR2(500);
BEGIN
    temp := 'grant ' || role_name || ' TO ' || user_name;
    EXECUTE IMMEDIATE temp;
END;
--Cap quyen select tren cot
create or replace procedure sp_GrantSelectOnTable(user_name in varchar2, table_name in varchar2, column_name in varchar2, grant_option in varchar2)
as
    temp VARCHAR2(500);
    temp1 VARCHAR2(500);
    temp2 VARCHAR2(500);
BEGIN
   if grant_option = 1 then
        temp2 := 'grant insert ' || 'ON ' || table_name || ' TO ' || user_name || ' with grant option';
    else
        temp2 := 'grant insert ' || 'ON ' || table_name || ' TO ' || user_name;
    end if;
    temp := 'CREATE or REPLACE VIEW ' || user_name || table_name || ' AS SELECT ' || column_name || ' FROM ' || table_name;
    EXECUTE IMMEDIATE temp;
    temp1 := 'GRANT SELECT ON ' || user_name || table_name || ' TO ' || user_name;
    EXECUTE IMMEDIATE temp1;
END;
--Phan quyen insert cho user/role
create or replace procedure sp_Insert(user_name in varchar2, table_name in varchar2, grant_option in int)
as
temp VARCHAR2(500);
BEGIN
    if grant_option = 1 then
        temp := 'grant insert ' || 'ON ' || table_name || ' TO ' || user_name || ' with grant option';
    else
        temp := 'grant insert ' || 'ON ' || table_name || ' TO ' || user_name;
    end if;
    EXECUTE IMMEDIATE temp;
END;

--Cap quyen select tren cot va grant thanh view
create or replace procedure sp_GrantSelectOnTable(user_name in varchar2, table_name in varchar2, column_name in varchar2, grant_option in int)
as
    temp VARCHAR2(500);
    temp1 VARCHAR2(500);
BEGIN
    temp := 'CREATE or REPLACE VIEW ' || user_name || table_name || ' AS SELECT ' || column_name || ' FROM ' || table_name;
    EXECUTE IMMEDIATE temp;
    if grant_option=0 then
        temp1 := 'GRANT SELECT ON ' || user_name || table_name || ' TO ' || user_name;
    else
        temp1 := 'GRANT SELECT ON ' || user_name || table_name || ' TO ' || user_name || ' with grant option';
    end if;
    EXECUTE IMMEDIATE temp1;
END;
--exec sp_GrantSelectOnTable('JOHN', 'ATTENDANCE', 'ID, NAME', 1);

--Cap select tren table
create or replace procedure sp_prSelect(table_name in varchar2, user_name in varchar2)
as
BEGIN
        EXECUTE IMMEDIATE 'GRANT SELECT ON ' || table_name || ' TO ' || user_name;
END;

--Cap quyen delete 
create or replace procedure sp_Delete(user_name in varchar2, table_name in varchar2, grant_option in int)
as
temp VARCHAR2(500);
BEGIN
    if grant_option=1 then
        temp := 'grant delete ' || 'ON ' || table_name || ' TO ' || user_name || ' with grant option';
    else
        temp := 'grant delete ' || 'ON ' || table_name || ' TO ' || user_name;
    end if;
    EXECUTE IMMEDIATE temp;
END;

--Cap quyen update 
create or replace NONEDITIONABLE procedure sp_Update(user_name in varchar2, column_name in varchar2, table_name in varchar2, grant_option in int)
as
temp VARCHAR2(500);
BEGIN
    if grant_option=1 then
        temp := 'grant update(' || column_name  || ') ON ' || table_name || ' TO ' || user_name || ' with grant option';
    else
        temp := 'grant update(' || column_name  || ') ON ' || table_name || ' TO ' || user_name;
    end if;
    EXECUTE IMMEDIATE temp;
END;

--5/Thu hoi quyen cua user/role
--Thu hoi quyen cua user/role
create or replace procedure sp_Revoke(user_name in varchar2, table_name in varchar2, type in int)
as
temp VARCHAR2(500);
BEGIN
    if type = 1 then
        temp := 'revoke select ' || 'ON ' || table_name || ' from ' || user_name;
    elsif type = 2 then
        temp := 'revoke insert ' || 'ON ' || table_name || ' from ' || user_name;
    elsif type = 3 then
        temp := 'revoke update ' || 'ON ' || table_name || ' from ' || user_name;
    elsif type = 4 then
        temp := 'revoke delete ' || 'ON ' || table_name || ' from ' || user_name;
    end if;
    EXECUTE IMMEDIATE temp;
END;

--6/Cho phep kiem tra quyen cua chu the vua duoc cap quyen

--Kiem tra quyen update tren cot vua cap cho user
create or replace procedure sp_UserKTraQuyenTrenCot(user_name varchar2)
as
    temp sys_refcursor;
begin
    open temp for
        --SELECT * FROM USER_TAB_PRIVS;
        SELECT GRANTEE, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE FROM USER_COL_PRIVS where grantee = user_name;
    DBMS_SQL.RETURN_RESULT(temp);
end;


--Kiem tra quyen them xem xoa vua cap cho user
create or replace procedure sp_UserKtraQuyenTrenBang(user_name varchar2)
as
    temp sys_refcursor;
begin
    open temp for
        SELECT GRANTEE, TABLE_NAME, PRIVILEGE, GRANTABLE FROM USER_TAB_PRIVS where grantee = user_name;
    DBMS_SQL.RETURN_RESULT(temp);
end;


--Kiem tra quyen cua role vua duoc cap
create or replace procedure sp_RoleKtraQuyenTrenBang(role_name varchar2)
as
    temp sys_refcursor;
begin
    open temp for
        SELECT ROLE, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE FROM ROLE_TAB_PRIVS where ROLE = role_name;
    DBMS_SQL.RETURN_RESULT(temp);
end;


--7/Chinh sua quyen cua user (bang cach revoke va grant lai quyen)
--Chinh sua quyen update tren cot cho user/role
create or replace procedure sp_ChinhSuaUpdateTrenCot(user_name in varchar2, column_name in varchar2, table_name in varchar2, grant_option in int)
as
temp VARCHAR2(500);
BEGIN
    sp_Revoke(user_name,table_name, 3);
    if grant_option=1 then
        temp := 'grant update(' || column_name  || ') ON ' || table_name || ' TO ' || user_name || ' with grant option';
    else
        temp := 'grant update(' || column_name  || ') ON ' || table_name || ' TO ' || user_name;
    end if;
    EXECUTE IMMEDIATE temp;
END;

--Chinh sua quyen insert cho user/role
create or replace procedure sp_ChinhSuaInsert(user_name in varchar2, table_name in varchar2, grant_option in int)
as
temp VARCHAR2(500);
BEGIN
    sp_Revoke(user_name,table_name, 2);
    if grant_option=1 then
        temp := 'grant insert ' || 'ON ' || table_name || ' TO ' || user_name || ' with grant option';
    else
        temp := 'grant insert ' || 'ON ' || table_name || ' TO ' || user_name;
    end if;
    EXECUTE IMMEDIATE temp;
END;


--Chinh sua quyen delete cho user/role
create or replace procedure sp_ChinhSuaDelete(user_name in varchar2, table_name in varchar2, grant_option in int)
as
temp VARCHAR2(500);
BEGIN
    sp_Revoke(user_name,table_name, 4);
    if grant_option=1 then
        temp := 'grant delete ' || 'ON ' || table_name || ' TO ' || user_name || ' with grant option';
    else
        temp := 'grant delete ' || 'ON ' || table_name || ' TO ' || user_name;
    end if;
    EXECUTE IMMEDIATE temp;
END;

--Chinh sua quyen select tren view
create or replace procedure sp_ChinhSuaSelectTrenView(user_name in varchar2, table_name in varchar2, column_name in varchar2, grant_option in int)
as
    temp VARCHAR2(500);
    temp1 VARCHAR2(500);
BEGIN
    sp_Revoke(user_name, user_name || table_name, 1);
    temp := 'CREATE or REPLACE VIEW ' || user_name || table_name || ' AS SELECT ' || column_name || ' FROM ' || table_name;
    EXECUTE IMMEDIATE temp;
    if grant_option=0 then
        temp1 := 'GRANT SELECT ON ' || user_name || table_name || ' TO ' || user_name;
    else
        temp1 := 'GRANT SELECT ON ' || user_name || table_name || ' TO ' || user_name || ' with grant option';
    end if;
    EXECUTE IMMEDIATE temp1;
END;
