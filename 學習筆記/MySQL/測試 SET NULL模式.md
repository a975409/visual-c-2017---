create database photo_app;
use photo_app;

新增users資料表[[新增資料表]]
create table users
(
	userid int primary key auto_increment,
    userName varchar(50)
);

新增資料至users[[在資料表新增資料]]
insert into users(userName)
values
('Tom'),('Ken'),('John'),('Sary');

新增Photos資料表[[新增資料表]]
create table photos(
id int not null primary key auto_increment,
url varchar(200),
user_id int,
FOREIGN KEY (user_id) REFERENCES users(userid) on delete set null
);

新增資料至Photos[[在資料表新增資料]]
INSERT INTO photos (url, user_id)
VALUES
('http://one.jpg', 4),
('http://two.jpg', 1),
('http://25.jpg', 1),
('http://36.jpg', 1),
('http://754.jpg', 2),
('http://35.jpg', 3),
('http://256.jpg', 4);

-- 在SET NULL 模式下，刪除users資料表userid=1的資料，關聯的photos資料表的user_id=1會被寫入null
delete from users where userid=1;