use DB_RESTAURANT_FINAL
go

--Roles
insert into tblROLE(name) values ('admin');
insert into tblROLE(name) values ('waiter');

-- Çalışanlar
insert into tblEMPLOYEE(first_name, last_name, user_name, _password,email, role_id) values ('a', 'a', 'Admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3','Admin@gmail.com', 1);
insert into tblEMPLOYEE(first_name, last_name, user_name, _password,email, role_id) values ('w', 'w','w', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3','Waiter@gmail.com',2);

-- Kategoriler
insert into tblCATEGORY(name) values('İçecekler');
insert into tblCATEGORY(name) values('Yemekler');
insert into tblCATEGORY(name) values('Tatlılar');


-- Varsayılan porsyon çeşitleri
insert into tblportion(name, calculate) values ('Yarım', 0.5);
insert into tblportion(name, calculate) values ('Bir', 1);
insert into tblportion(name, calculate) values ('Bir Buçuk',1.5);

insert into tblportion(name, calculate) values ('Küçük', 0.5);
insert into tblportion(name, calculate) values ('Orta', 1);
insert into tblportion(name, calculate) values ('Büyük', 1.5);

-- Masalar
insert into tblTABLES(id, seat_count, _status) values(1, 2, 0);
insert into tblTABLES(id, seat_count, _status) values(2, 2, 0);
insert into tblTABLES(id, seat_count, _status) values(3, 2, 0);
insert into tblTABLES(id, seat_count, _status) values(4, 2, 0);
insert into tblTABLES(id, seat_count, _status) values(5, 4, 0);
insert into tblTABLES(id, seat_count, _status) values(6, 4, 0);
insert into tblTABLES(id, seat_count, _status) values(7, 4, 0);
insert into tblTABLES(id, seat_count, _status) values(8, 4, 0);
insert into tblTABLES(id, seat_count, _status) values(9, 6, 0);
insert into tblTABLES(id, seat_count, _status) values(10, 4, 0);
insert into tblTABLES(id, seat_count, _status) values(11, 4, 0);
insert into tblTABLES(id, seat_count, _status) values(12, 6, 0);


select * from tblcategory;
select * from tbltables;
select * from tblportion;
select * from tblemployee;
select * from tblrole;


