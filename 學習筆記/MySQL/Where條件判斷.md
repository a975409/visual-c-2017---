-- 新增'employee'資料表
create table employee(
emp_id int not null auto_increment,
emp_name varchar(50),
emp_department varchar(50),
emp_age int,
primary key(emp_id)
);

-- alter table employee auto_increment=100;

-- 新增資料
insert into employee(emp_name, 
emp_department, emp_age)
values('Tony','HR', 35),
('Amy','RD', 30),('Jenny', 'Sells',28),
('Tom','RD',22),('Betty','HR',25),
('John','Account',36),('Mary','Sells', 22);

搭配[[列出資料表所有資料]]使用
--where條件，在where後面加上binary，字串條件區分大小寫
select emp_name,emp_age from employee where binary emp_department='HR';

--where條件，預設字串條件不分大小寫
select emp_name as 'employee Name',emp_age as Age from employee where binary emp_department='HR';
