create database wxwpdjWeb
go

use wxwpdjWeb
go

--管理员登录信息
create table denglu
(
code nvarchar(20) not null primary key,
password nvarchar(100) not null,
name nvarchar(20) not null,
sex nvarchar(10) not null,
birthday datetime not null
)
go

insert into denglu values('admin','123456','admin',N'男','2000-01-01')
go

--危险物品
create table dangerInfo
(
id int identity(1,1) not null primary key,  --自增长主键
name nvarchar(100) not null,			    --危险物品名称
xdz_name nvarchar(20) not null,			   --携带者-姓名
xdz_sex nvarchar(10) not null,			   --携带者-性别
xdz_phone nvarchar(20) not null,		   --携带者-联系电话
xdz_sfzh nvarchar(100) not null,		   --携带者-身份证号
catagory nvarchar(50) not null,			   --危险物品分类
remark nvarchar(50) null,                  --备注
djrq datetime not null default getdate()   --登记日期
)
go
