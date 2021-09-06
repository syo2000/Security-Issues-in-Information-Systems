--Le Thi Thuy Duong
--18127086
alter session set "_ORACLE_SCRIPT"=true; 
--Tao user John voi mat khau JOHN
create user John identified by JOHN;


--Tao user Joe voi mat khau JOE
create user Joe identified by JOE;

--Tao user Fred voi mat khau FRED
create user Fred identified by FRED;

--Tao user Lynn voi mat khau LYNN
create user Lynn identified by LYNN;

--Tao user Amy voi mat khau AMY
create user Amy identified by AMY;

--Tao user Beth voi mat khau BETH
create user Beth identified by BETH;

--John co the tao bat ky bang nao trong tablespace voi quota 10M
alter user John default tablespace system
quota 10M on system;

--Joe co the tao bat ky bang nao trong tablespace voi quota 10M
alter user Joe default tablespace system
quota 10M on system;

--Fred co the tao bat ky bang nao trong tablespace voi quota 10M
alter user Fred default tablespace system
quota 10M on system;

--Lynn co the tao bat ky bang nao trong tablespace voi quota 10M
alter user Lynn default tablespace system
quota 10M on system;

--Amy co the tao bat ky bang nao trong tablespace voi quota 10M
alter user Amy default tablespace system
quota 10M on system;

--Beth co the tao bat ky bang nao trong tablespace voi quota 10M
alter user Beth default tablespace system
quota 10M on system;

declare
   c int;
begin
   select count(*) into c from user_tables where table_name = upper('Attendance');
   if c = 1 then
      execute immediate 'drop table Attendance';
   end if;
end;
/
create table Attendance
(
    ID int,
    NAME nvarchar2(20),
    constraint Attendance_pk primary key(ID)
);

--Tao role DataEntry
create role DataEntry;

--Tao role Supervisor
create role Supervisor;

--Tao role Management
create role Management;

--Gan user John vao role DataEntry
grant DataEntry to John;

--Gan user Joe vao role DataEntry
grant DataEntry to Joe;

--Gan user Lynn vao role DataEntry
grant DataEntry to Lynn;

--Gan user Fred cho role Supervisor
grant Supervisor to Fred;

--Gan user Amy vao role Management
grant Management to Amy;

--Gan user Beth vao role Management
grant Management to Beth;

--Gan cac quyen select, insert, update cho role DataEntry tren bang attentance
grant select, insert, update on Attendance to DataEntry;

--Gan cac quyen select, delete cho role Supervisor tren bang attendance
grant select, delete on Attendance to Supervisor;

--Gan cac quyen select cho role Management tren bang attendance
grant select on Attendance to Management;

--Tao user NameManager voi mat khau pc123
create user NameManager identified by pc123;

--Gan quyen update cho user NameManager tren cot Name bang Attendance
grant update(NAME) on Attandance to NameManager;

--Tim quyen ma trong ten quyen co CONTEXT
select *
from dba_sys_privs
where privilege like '%CONTEXT%';

--Liet ke tat ca cac user co quyen select any table
select *
from dba_sys_privs
where privilege = 'SELECT ANY TABLE';

--Gan mat khau cho DataEntry la mgt
alter role DataEntry identified by mgt;

--User John quyen cap quyen cho cac user khac
grant John to Joe WITH ADMIN OPTION;
grant John to Fred WITH ADMIN OPTION;
grant John to Lynn WITH ADMIN OPTION;
grant John to Amy WITH ADMIN OPTION;
grant John to Beth WITH ADMIN OPTION;
--John thuoc role DataEntry co cac quyen select ,insert,update 
--Neu John duoc cap quyen With admin option
--John gan cho Beth thi Beth co quyen Insert và Update tren bang Attendance

