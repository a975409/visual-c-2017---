1.修改資料表名：
alter table 舊資料表名 RENAME  新資料表名

2.修改欄位資料類型：
alter table 資料表 MODIFY 欄位名稱 資料型態

3.修改欄位的排列位置：
※排至第一個欄位：
alter table 資料表 MODIFY 欄位名稱 資料型態 FIRST

※排至指定欄位之後：
alter table 資料表 MODIFY 欄位名稱 資料型態 AFTER 指定欄位名稱

3.修改欄位名稱：
alter table 資料表 CHANGE 舊欄位名稱 新欄位名稱 新資料型態

4.增加欄位：
alter table 資料表 ADD 欄位名稱 資料型態

※新增至第一個欄位：
alter table 資料表 ADD 欄位名稱 資料型態 FIRST

※新增至指定欄位之後：
alter table 資料表 ADD 欄位名稱 資料型態 AFTER 指定欄位名稱

5.刪除欄位：
alter table 資料表 DROP 欄位名稱

6.刪除外鍵：
※先執行以下指令，取得CONSTRAINT 之後的參數：
show create table 資料表;

alter table 資料表 DROP FOREIGN KEY CONSTRAINT 之後的參數

7.指定欄位新增外鍵(FOREIGN KEY)：

alter table 資料表 add  foreign key(指定欄位) references 參考資料表(參考欄位)