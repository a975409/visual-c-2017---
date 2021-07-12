create database ig_app;

use ig_app;

create table users(
 id integer auto_increment primary key,
 username varchar(200) not null unique,
 created_at timestamp default now()
);

create table photos
(
 id integer auto_increment primary key,
 image_url varbinary(255) not null,
 user_id integer not null,
 created_at timestamp default now(),
 foreign key(user_id) references users(id)
);

CREATE TABLE comments(
 id INTEGER AUTO_INCREMENT primary key,
 comment_text varchar(255) not null,
 user_id integer not null,
 photo_id integer not null,
 created_at timestamp default now(),
 foreign key(user_id) references users(id),
 foreign key(photo_id) references photos(id)
);

create table likes(
 user_id integer not null,
 photo_id integer not null,
 created_at timestamp default now(),
 foreign key(user_id) references users(id),
 foreign key(photo_id) references photos(id),
 primary key(user_id,photo_id)
);

create table follows
(
 follower_id integer not null,
 followee_id integer not null,
 created_at timestamp default now(),
 foreign key(follower_id) references users(id),
 foreign key(followee_id) references users(id),
 primary key(follower_id,followee_id)
);

create table tags
(
 id integer primary key auto_increment,
 tag_name varchar(255) not null unique,
 created_at timestamp default now()
);

create table photo_tags
(
 photo_id integer not null,
 tag_id integer not null,
 foreign key(photo_id) references photos(id),
 foreign key(tag_id) references tags(id),
 primary key(photo_id,tag_id)
);