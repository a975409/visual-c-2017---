-- 新增資料庫
create database My_Shop;

-- 使用資料庫
use My_Shop;

--新增資料表
-- 以下為可選參數：
-- not null代表該欄位不允許null值
-- default值在新增資料時，如果沒有指定到該欄位，就會以default值代替
-- primary key 設定主鍵，該值不能重複，是唯一值
-- auto_increment代表該欄位的值會自動遞增，僅限數值型態，通常搭配primary key使用
create table Phone_Product
(
 ProductId int primary key auto_increment,
 ProductName varchar(50) not null default 'undifineName',
 brand varchar(50) not null default 'undifinebrand',
 Price varchar(50) not null default 'undifinePrice'
 --primary key(ProductId)=>也可另外設定primary key
);

-- 列出指定的資料表所有欄位定義
show columns from Phone_Product;
describe Phone_Product;
desc Phone_Product;

-- 新增多筆資料
insert into Phone_Product(ProductName,brand,Price)
values
('iPhone 12',' Apple', 19900),
('Pixel 5',' Google', 18900),
('Galaxy s21',' Samsung', 19800);

-- 也可指定部分欄位新增資料，未指定的欄位會為null，如果有設定default值，就會以default值代替
insert into Phone_Product(brand)
values
('Apple'),('Google'),('Samsung');

--顯示指定資料表資料
select * from Phone_Products;

-- 顯示錯誤訊息
show warnings;