﻿CREATE TABLE DEPT (
 DEPTNO              integer NOT NULL,
 DNAME               varchar(14),
 LOC                 varchar(13),
 CONSTRAINT DEPT_PRIMARY_KEY PRIMARY KEY (DEPTNO));

INSERT INTO DEPT VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO DEPT VALUES (20,'RESEARCH','DALLAS');
INSERT INTO DEPT VALUES (30,'SALES','CHICAGO');
INSERT INTO DEPT VALUES (40,'OPERATIONS','BOSTON');

CREATE TABLE EMP (
 EMPNO               integer NOT NULL,
 ENAME               varchar(10),
 JOB                 varchar(9),
 MGR                 integer CONSTRAINT EMP_SELF_KEY REFERENCES EMP (EMPNO),
 HIREDATE            DATEtime,
 SAL                 money,
 COMM                money,
 DEPT_DEPTNO              integer NOT NULL,
 CONSTRAINT EMP_FOREIGN_KEY FOREIGN KEY (DEPT_DEPTNO) REFERENCES DEPT (DEPTNO),
 CONSTRAINT EMP_PRIMARY_KEY PRIMARY KEY (EMPNO));

INSERT INTO EMP VALUES (7839,'KING','PRESIDENT',NULL,'17-NOV-81',5000,NULL,10);
INSERT INTO EMP VALUES (7698,'BLAKE','MANAGER',7839,'1-MAY-81',2850,NULL,30);
INSERT INTO EMP VALUES (7782,'CLARK','MANAGER',7839,'9-JUN-81',2450,NULL,10);
INSERT INTO EMP VALUES (7566,'JONES','MANAGER',7839,'2-APR-81',2975,NULL,20);
INSERT INTO EMP VALUES (7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30);
INSERT INTO EMP VALUES (7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30);
INSERT INTO EMP VALUES (7844,'TURNER','SALESMAN',7698,'8-SEP-81',1500,0,30);
INSERT INTO EMP VALUES (7900,'JAMES','CLERK',7698,'3-DEC-81',950,NULL,30);
INSERT INTO EMP VALUES (7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30);
INSERT INTO EMP VALUES (7902,'FORD','ANALYST',7566,'3-DEC-81',3000,NULL,20);
INSERT INTO EMP VALUES (7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20);
INSERT INTO EMP VALUES (7788,'SCOTT','ANALYST',7566,'09-DEC-82',3000,NULL,20);
INSERT INTO EMP VALUES (7876,'ADAMS','CLERK',7788,'12-JAN-83',1100,NULL,20);
INSERT INTO EMP VALUES (7934,'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10);



--- Display all ename in descending order (ctrl+shif+u)
SELECT ENAME 
FROM EMP 
ORDER BY ENAME DESC

-- display all ename,slary ,commision of emp in deptno 10,sory by ename desc
SELECT ENAME,SAL,COMM,DEPT_DEPTNO
FROM EMP
WHERE DEPT_DEPTNO=10
ORDER BY ENAME DESC
-- display all employees in dept 10 as well as in dept 20

SELECT * 
FROM EMP 
WHERE DEPT_DEPTNO=10 OR DEPT_DEPTNO=20

SELECT * 
FROM EMP 
WHERE DEPT_DEPTNO in (10 ,20)

-- display all employess who are managers
SELECT *
FROM EMP
WHERE JOB = 'manager'

-- display all employee who does not have commision
SELECT *
FROM EMP
WHERE COMM is NULL

-- calculate annaul ctc of the employee
SELECT ISNULL(COMM,0),COMM
FROM EMP;

SELECT 12 * (ISNULL(COMM,0) + SAL) AS CTC , COMM,SAL
FROM EMP

-- display min,max ,avg and sum of salary
select MIN(sal) as 'MIN',max(sal) as 'MAX' ,avg(sal) as 'AVG',sum(sal) as 'SUM'
from emp;

-- display current date
SELECT GETDATE()
PRINT 'HELLO WORLD'

SELECT GETDATE() as 'today',ENAME 
FROM EMP

-- deptwise number of employees
select count(*) from EMP;

SELECT DEPT_DEPTNO,COUNT(*)
FROM EMP
GROUP BY DEPT_DEPTNO

SELECT DEPT_DEPTNO,COUNT(*) as [count]
FROM EMP
GROUP BY DEPT_DEPTNO
order by [count] desc

select count(DEPT_DEPTNO)
from emp where DEPT_DEPTNO=10;

-- distinct , uqniet dnot form emp
select distinct DEPT_DEPTNO
from emp
select * from dept


select DEPT.DNAME,EMP.ENAME
FROM EMP INNER JOIN DEPT
ON EMP.DEPT_DEPTNO = DEPT.DEPTNO


select DEPT.DNAME,EMP.ENAME
FROM EMP RIGHT OUTER JOIN DEPT
ON EMP.DEPT_DEPTNO = DEPT.DEPTNO



select DEPT.DEPTNO, DEPT.DNAME,EMP.ENAME
FROM DEPT LEFT OUTER JOIN EMP
ON EMP.DEPT_DEPTNO = DEPT.DEPTNO

select DEPT.DEPTNO, DEPT.DNAME,EMP.ENAME
FROM DEPT LEFT OUTER JOIN EMP
ON EMP.DEPT_DEPTNO = DEPT.DEPTNO
where EMP.ENAME is null

select d.DEPTNO, d.DNAME,e.ENAME
FROM DEPT d LEFT OUTER JOIN EMP e
ON e.DEPT_DEPTNO = d.DEPTNO
where e.ENAME is null

select * from emp;

-- all employee name and thier manager names
select x.ENAME,x.MGR,y.ENAME as Manager,y.EMPNO
from EMP x inner join EMP y
on x.MGR = y.EMPNO

select x.ENAME,x.MGR,y.ENAME as Manager,y.EMPNO
from EMP x left join EMP y
on x.MGR = y.EMPNO
order by x.ENAME

SELECT E.ENAME,D.DNAME--,MGR.ENAME as 'Manager'
FROM EMP E JOIN DEPT D
ON E.DEPT_DEPTNO = D.DEPTNO
JOIN EMP MGR
ON  E.MGR = MGR.EMPNO
ORDER BY E.ENAME
--- tasnactions
create table dummy (id int)

insert into dummy values(100);
select * from dummy;
insert into dummy values(5);
insert into dummy values(51);
insert into dummy values(3);


begin transaction txn
  begin try 
   insert into dummy values(566);
   insert into dept values(10,'it','locaiton');
   select * from dummy

   commit
   end try
   begin catch
     rollback
   end catch
 commit

 select * from dummy
 -- insert,update,delete
 alter procedure GEtEmpDetails 
 as
begin
  SELECT E.ENAME,D.DNAME,MGR.ENAME--,MGR.ENAME as 'Manager'
	FROM EMP E JOIN DEPT D
	ON E.DEPT_DEPTNO = D.DEPTNO
	JOIN EMP MGR
	ON  E.MGR = MGR.EMPNO
	ORDER BY E.ENAME
 end

 exec GEtEmpDetails

 sp_helptext 'GEtEmpDetails'
 
 select getDate();