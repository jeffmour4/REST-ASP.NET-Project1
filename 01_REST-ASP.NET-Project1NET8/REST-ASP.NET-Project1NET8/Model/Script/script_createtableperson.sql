create table if not exists person (
id bigint not null auto_increment,
address varchar(100) not null,
first_name varchar(80) not null,
gender varchar(6) not null,
last_name varchar(80) not null,
primary key(id)
);