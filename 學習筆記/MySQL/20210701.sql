create database photo_app;
use photo_app;

-- 步驟一、新增users資料表
create table users
(
	userid int primary key auto_increment,
    userName varchar(50)
);

-- 步驟二、新增資料至users
insert into users(userName)
values
('Tom'),('Ken'),('John');

-- 步驟三、新增Photos資料表
create table Photos(
	id int primary key auto_increment,
    url varchar(200),
    userid int,
    foreign key(userid) references users(userid) -- userid設定外鍵，指定到users資料表裡面的userid
);

-- 步驟三、新增資料至Photos
insert into Photos(url,userid)
values
('https://123.jpg',1),('https://456.jpg',2),('https://789.jpg',3);

-- 無法新增，因為users資料表沒有userid=66
insert into  Photos(url,userid)
values('https://123.jpg',66);

-- 可新增，外鍵設定為null
insert into  Photos(url,userid)
values('https://123.jpg',null);