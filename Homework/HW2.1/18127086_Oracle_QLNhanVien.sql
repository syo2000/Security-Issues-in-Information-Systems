-- Le Thi Thuy Duong
-- 18127086



-- Loi duoc bao cao nhung lenh van se tiep tuc
WHENEVER SQLERROR CONTINUE NONE 
-- Xoa bang EMP_18127086
DROP TABLE EMP_18127086; 

-- T?o b?ng nhân viên ( EMP_18127086 )
create table EMP_18127086
(
    EMPNO number(4) ,
    ENAME varchar2(10),
    JOB varchar2(9),
    MGR number(4), 
    HIREDATE date, 
    SAL number(7,2),
    COMM number(7,2),
    DEPTNO number(2) not null, 
    constraint EMP_pk primary key(EMPNO)
);

WHENEVER SQLERROR CONTINUE NONE
-- Xoa bang DEPT_18127086
DROP TABLE DEPT_18127086;

-- T?o b?ng phòng ban (DEPT_18127086)
create table DEPT_18127086
(
    DEPTNO number(2) ,
    DNAME varchar2(14),
    LOC varchar2(13), 
    constraint DEPT_pk primary key(DEPTNO)
);

WHENEVER SQLERROR CONTINUE NONE
-- Xoa bang SALGRADE_18127086
DROP TABLE SALGRADE_18127086;

--Tao bang SALGRADE_18127086
create table SALGRADE_18127086
(
    GRADE number not null,
    LOSAL number,
    HISAL number,
    constraint SALGRADE_pk primary key(GRADE)
    
);

--Tao khoa ngoai 
alter table EMP_18127086
add
    constraint fk_EMP_EMP 
    foreign key (MGR) 
    references EMP_18127086(EMPNO);
    
--Tao khoa ngoai
alter table EMP_18127086
add
    constraint fk_EMP_DEPT 
    foreign key(DEPTNO) 
    references DEPT_18127086(DEPTNO);

-- Nhap lieu vao bang EMP_18127086
insert into SALGRADE_18127086 values(1,700,1200);
insert into SALGRADE_18127086 values(2,1201,1400);
insert into SALGRADE_18127086 values(3,1401,2000);
insert into SALGRADE_18127086 values(4,2001,3000);
insert into SALGRADE_18127086 values(5,3001,9999);

--Nhap lieu vao bang DEPT_18127086
insert into DEPT_18127086 values(10,'ACCOUNTING','EW YORK');
insert into DEPT_18127086 values(20,'RESEARCH','DALLAS');
insert into DEPT_18127086 values(30,'SALES','CHICAGO');
insert into DEPT_18127086 values(40,'OPERATIONS','BOSTON');
   
--Nhap lieu vao bang SALGRADE_18127086
insert into EMP_18127086 values(7839,'KING','PRESIDENT',NULL,'17-NOV-1981',5000,NULL,10);
insert into EMP_18127086 values(7698,'BLAKE','MANAGER',7839,'01-MAY-1981',2850,NULL,30);
insert into EMP_18127086 values(7782,'CLARK','MANAGER',7839,'09-JUN-1981',2450,NULL,10);
insert into EMP_18127086 values(7566,'JONES','MANAGER',7839,'02-APR-1981',2975,NULL,20);
insert into EMP_18127086 values(7654,'MARTIN','SALESMAN',7698,'28-SEP-1981',1250,1400,30);
insert into EMP_18127086 values(7499,'ALLEN','SALESMAN',7698,'20-FEB-1981',1600,300,30);
insert into EMP_18127086 values(7844,'TURNER','SALESMAN',7698,'08-SEP-1981',1500,0,30);
insert into EMP_18127086 values(7900,'JAMES','CLERK',7698,'03-DEC-1981',950,NULL,30);
insert into EMP_18127086 values(7521,'WARD','SALESMAN',7698,'22-FEB-1981',1250,500,30);
insert into EMP_18127086 values(7902,'FORD','ANALYST',7566,'03-DEC-1981',3000,NULL,20);
insert into EMP_18127086 values(7369,'SMITH','CLERK',7902,'17-DEC-1981',800,NULL,20);
insert into EMP_18127086 values(7788,'SCOTT','ANALYST',7566,'09-DEC-1981',3000,NULL,20);
insert into EMP_18127086 values(7876,'ADAMS','CLERK',7788,'12-JAN-1981',1100,NULL,20);
insert into EMP_18127086 values(7934,'MILLER','CLERK',7782,'23-JAN-1981',1300,NULL,10);


