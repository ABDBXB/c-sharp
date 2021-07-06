use master
go
create database DB_RESTAURANT_FINAL

use DB_RESTAURANT_FINAL
go


create table tblrole(

	id		bigint				primary key identity(1,1),
	name	varchar(30)		not null

	);


create table tblemployee(

	id			bigint			primary key identity(1,1),
	first_name	nvarchar(30)		not null,
	last_name	nvarchar(50)		not null,
	user_name	nvarchar(50)		not null,
	_password	char(64)		not null,
	phone_num	char(11),
	email		nvarchar(150),
	role_id		bigint				foreign key references tblrole(id),
	deleted		bit				default(0)	

);


create table tblcategory(
	id			bigint				identity(1,1) primary key,
    name		nvarchar(50)		not null,
	deleted		bit				default(0)
);


create table tbltables(
	id			bigint				not null primary key,
    seat_count	int				not null,
    _status		bit				not null,
	deleted 	bit				default(0)
);

create table tblimage( 
	id			bigint identity(1,1) primary key not null,
	image_name	nvarchar(50),
	picture		image
)

create table tblfooditem(
	id				bigint				identity(1,1) primary key,
    item_name		nvarchar(100)	not null,
    quantity		float			not null,
    category_id		bigint				foreign key references tblcategory(id),
	_image			bigint				foreign key references tblimage(id),
	deleted 		bit				default(0)
);

create table tblportion(
	id		  bigint		primary key identity(1,1),
	name	  nvarchar(30),
	calculate float
)

create table tblfooditem_portion(
	id				bigint		identity(1,1) primary key,
	food_item_id	bigint		foreign key references tblfooditem(id),
	portion_id		bigint		foreign key references tblportion(id),
	unit_price		float		not null,
	deleted			bit			default(0)
)




create table tblorder(
	id				bigint			identity(1,1) primary key,
	_status			bit,
	table_id		bigint			not null foreign key references tbltables(id),
	starting_date	datetime	default(getdate()),
	closing_date	datetime	default(getdate())
);

create table tblfooditem_order(
	id				bigint			primary key identity(1,1),
	order_id		bigint			foreign key references tblorder(id),
	fp_id			bigint			foreign key references tblfooditem_portion(id),
	quantity		float		not null,
	price			float		not null,
	_date			datetime	not null,
	employee_id		bigint			not null foreign key references tblemployee(id),
);




select * from tblcategory;
select * from tbltables;
select * from tblfooditem;
select * from tblorder;
select * from tblfooditem_order;
select * from tblfooditem_portion;
select * from tblemployee;
select * from tblrole;
select * from tblimage


