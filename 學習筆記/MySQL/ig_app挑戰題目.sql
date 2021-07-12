 -- 題目一 最早註冊的 5 位使用者
 select * from users
 order by created_at
 limit 0,5;
 
 -- 題目二 找出一個禮拜中，最多人註冊的是禮拜幾?
 -- 1.先取得哪個星期最多註冊人數=>取得最大count(*)
 -- select DISTINCT count(*) as num from users
 -- group by dayname(created_at)
 -- order by num desc limit 0,1
 
 -- 2.取得每個星期註冊人數
 -- select dayname(created_at) from users
 -- group by dayname(created_at)
 
 -- 3.找出哪個星期註冊人數最多alter
 -- having count(*)=步驟1所得最大count(*)
 
 select dayname(created_at) from users
 group by dayname(created_at)
 having count(*)=(select DISTINCT count(*) as num from users
 group by dayname(created_at)
 order by num desc limit 0,1);

 -- 題目三 找出沒有發過照片的使用者名稱 (username)
 select users.username
 from users
 left join photos on users.id=photos.user_id
 where photos.user_id is null;
 
 -- 題目四  想要頒獎給社群內拿到最多讚照片，並查詢出那個是誰 (username) 的照片。
 -- 1.取得單張照片最多按讚數=>取得最大count(*)
 -- select DISTINCT count(*) as num from likes
 -- group by likes.photo_id
 -- order by num desc limit 0,1
 
 -- 2.取得每張照片按讚數
 -- select likes.photo_id,users.username,count(*) as '按讚次數'
 -- from likes
 -- join photos on likes.photo_id = photos.id
 -- join users on photos.user_id=users.id
 -- group by likes.photo_id
 
 -- 3.找出哪張照片按讚數最多
 -- having count(*)=步驟1所得最大count(*)
 
 select likes.photo_id,users.username,count(*) as '按讚次數'
 from likes
 join photos on likes.photo_id = photos.id
 join users on photos.user_id=users.id
 group by likes.photo_id
 having count(*)=
 (select DISTINCT count(*) as num from likes
 group by likes.photo_id
 order by num desc limit 0,1);
 
 -- 題目五 快到季報時間了，股東想看業績，於是想查看使用者貼照片的平均次數。
 -- 1.取得photos總數
 -- select count(*) as num from photos
 
 -- 2.取得users總數
 -- select count(users.id) from users
 
 -- 3.步驟1/步驟2
 
select (select count(*) as num from photos)/(select count(users.id) from users)
 
 -- 題目六 一個名牌想要打廣告，於是想要知道目前前五名 #tag  次數最多的主題。
 select tag_name from tags
 join photo_tags on tags.id=photo_tags.tag_id
 group by tags.id
 order by count(*) desc limit 0,5;
 
 -- 題目七 IT 團隊發現有機器人假帳號在每一張照片按讚，請找出這些假帳號。
 
 -- 1.取得有被按讚照片的張數
 -- select count(DISTINCT(likes.photo_id)) from likes
 
 -- 2.找出user照片按讚次數是否等於步驟1取得的張數
 
 select users.username,count(*)
 from likes
 join users on likes.user_id=users.id
 group by likes.user_id
 having count(*)=
 (select count(DISTINCT(likes.photo_id)) from likes);