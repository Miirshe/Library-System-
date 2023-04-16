--creatting DATABASE LIBARRARYMANAGEMENT SYSTEM 

create Database LibararyManagementSystem
Use LibararyManagementSystem

--TABLES
-- 1.CATEGORY
-- 2.AUTHOR
-- 3.BOOK
-- 4.MEMBER
-- 5.LENDER BOOK
-- 6.RETURN BOOK
-- 7.USER

--CREATIG 1.CATEGORY TABLE
create table category
(
	id int identity(1,1) primary key NOT NULL,
	catname varchar(200) Not NULL UNIQUE,
	status  varchar(10),
	date  date DEFAULT GETDATE(),
)
--- inserting  CATEGORY

insert  into category(catname,status) values('History', 'Active'),
							('Programming', 'Active'),
							('Scientific Subjects', 'Active'),
							('sociality', 'Active')
--	Store procedure READING CATEGORY
create proc readallcategory
as
begin
select id 'CategoryID' , catname 'Category Name', status 'Catogory Status', date 'Date'from category
end
--end READING CATEGORY

-- CREATE STORE PROCEDURE RECODRS CATEGORY
Create proc registercategory
@name varchar(200),
@status varchar(10),
@date date
as
begin
insert  into category(catname,status,date) values(@name, @status, @date)
end

--end record category

-- UPDATING CATEGORY USING PROCEDURE
create proc updatecategory
@name varchar(200),
@status varchar(10),
@date date,
@updateid int
as
begin
update category set catname=@name, status=@status, date=@date 
where id=@updateid
end
--eding update category 

--DELETE CATEGORY USING STORE PROCEDURE
create proc deletecategory
@id int
as
begin
delete category where id=@id
end
---ENDING DELETING CATEGORY

---COUNTING CATEGORY USING PROCEDURE
create proc countcategory
as
begin
select  count(*) FROM category
end
--end 
		-- END CREATING 1. CATEGORY TABLE USING ALL FUNCATONALATIES.

--------------------------------------------

--- 2. CREATING AUTHOR  TABLE
create table author
(
	id int identity(1,1) primary key NOT NULL,
	name varchar(100) unique NOT NULL,
	address varchar(20) NOT NULL,
	sex varchar(7) NOT NULL,
	experience varchar(20) NOT NULL,
	phone varchar(20) NOT NULL unique,
	date date DEFAULT GETDATE()
)

-- CREATE PROCEDURE RECORDS AUTHOR 
CREATE PROC resgisterauthor
@name varchar(100),
@address varchar(20),
@sex varchar(7),
@experience varchar(20),
@phone int
as
begin
INSERT INTO author (name,address,sex,experience,phone)
VALUES(@name,@address,@sex,@experience,@phone)
end
-- END RECORING AUTHOR INFROMATION

--CREATE PROCEDURE UPDATING AUHTHO INFO
CREATE PROC updateauthor
@name varchar(100),
@address varchar(20),
@sex varchar(7),
@experience varchar(20),
@phone int,
@updateid int
as
begin
UPDATE author SET name = @name, address =@address, sex= @sex, experience = @experience,
phone = @phone WHERE id = @updateid

end
-- END UPDATING AUTHOR INFORMATION

--CREATE PROCEDUE THAT DELETES AUTHOR INFORMATION
CREATE PROC deleteauthor
@id int
As
begin
DELETE author WHERE id = @id
end
-- END DELETING AUTHRO INFORMATION

--CRAETE PROCEDURE THAT RAEDS OR DISPLAYS ALL AUTHOR INFORMATION STORES IN OUR DATABASE
CREATE PROC readallauthor
as
begin
select id 'Author ID' ,  name 'Author Name', address 'Author Address',sex 'Sex',experience 'Experience' , phone 'Author Phone'  , date 'Date' from author
end
-- END READING ALL INFORMATION ABOUT AUTHOR TABLE

--CRAETE PROCEDURE THAT DISPLAY OR COUNT ALL AUTHOR RECORDED
CREATE PROC countauthor
as
begin
select count(*) from author
end
-- END COUTNIG

		-- END CREATING 2. AUTHOR TABLE USING STORED PROCEDYER

--------------------------------------------------------------



-- CRAETE 3. BOOK TABLE
CREATE TABLE book(
id int identity(1,1) PRIMARY KEY NOT NULL,
name  varchar(50) NOT NULL,
cid int FOREIGN KEY REFERENCES category(id),
aid int FOREIGN KEY REFERENCES author(id),
pname varchar(250) NOT NULL,
type varchar(20) NOT NULL,
pages int NOT NULL DEFAULT 20,
qtty int NOT NULL,
aqtty int NOT NULL,
edition varchar(20),
bphoto image,
date date DEFAULT GETDATE()
)



-- END CREATING BOOK TABLE


-- CREATE PROC RECORDS BOOK
CREATE PROC registerbook
@name varchar(50),
@cid int,
@aid int,
@pname varchar(250),
@type varchar(20),
@pages int,
@qtty int,
@aqtty int,
@photo image,
@edition VARCHAR(20)
as
begin
INSERT INTO book(name,cid,aid,pname,type,pages,qtty,aqtty,bphoto,edition)
VALUES (@name,@cid,@aid,@pname,@type,@pages,@qtty,@aqtty,@photo,@edition)
end
-- END PROC 

--CREATE PROC RAEDS BOOK
CREATE PROC readallbook
as
begin
select book.id 'BookID', book.name 'Book Name', category.catname 'Category Name',
author.name 'Author Name', book.pname 'Publisher Name', book.type 'Book Type',
book.pages 'Pages', book.qtty 'Quantity',book.aqtty 'Available', book.edition 'Edition' ,book.date 'Date' from book INNER JOIN category ON
book.cid = category.id INNER JOIN author ON
book.aid = author.id
end
--END PROC READS ALL BOOKS


-- CREATE PROCEDURE UPDATES BOOKS
CREATE PROC updatebook
@name varchar(50),
@cid int,
@aid int,
@pname varchar(250),
@type varchar(20),
@pages int,
@qtty int,
@photo image,
@edition VARCHAR(20),
@updateid int
as
begin
UPDATE book SET name = @name , cid = @cid, aid = @aid , pname =pname , pages = @pages,
type = @type , qtty = @qtty, bphoto=@photo, edition = @edition
WHERE id = @updateid
end

--Search Book Image 
Create proc searchbookimage
@id int
as
begin
select bphoto from book where id = @id
end

-- END UPDATE PROC BOOK


-- CREATE PROC DELETE BOOK
CREATE PROC deletebook
@id int
as
begin
DELETE book WHERE id = @id;
end
-- END DELETING BOOK BY USING STORED PROCEDUER

-- CRAETE COUNTING PROCEDURE
CREATE PROC countbook
as
begin
Select count(*) from book
end
-- END COUNTING NUMBER OF BOOKS


		-- END CREATING 3. BOOK TABLE USING STORED PROCEDYER

--------------------------------------------------------------


--- 4. CREATING Member TABLE 
CREATE table member(
	id int identity(1,1) primary key NOT NULL,
	name varchar(100)  NOT NULL,
	address varchar(20) NOT NULL,
	email varchar(50) NOT NULL,
	bname varchar(70) NOT NULL,
	bphone varchar(20) NOT NULL UNIQUE,
	phone varchar(20) NOT NULL unique,
	date date DEFAULT GETDATE()
)
-- END CREATING MEMBER

-- CREATE PROCEDURE RECORDS MEMBER 
CREATE PROC registermember
@name varchar(100),
@address varchar(20),
@email varchar(50),
@bname varchar(70),
@bphone varchar(20),
@mphone varchar(50)
as
begin
INSERT INTO member(name,address,email,bname,bphone,phone)
VALUES(@name,@address,@email,@bname,@bphone,@mphone)
end
-- END RECORING AUTHOR INFROMATION

-- CRAETE PROC UPDATES MEMBERS
CREATE PROC updatemember
@name varchar(100),
@address varchar(20),
@email varchar(50),
@bname varchar(70),
@bphone varchar(20),
@mphone varchar(30),
@updateid VARCHAR(40)
as
begin
UPDATE member SET name = @name, address = @address,email = @email , bname= @bname, bphone = @bphone ,
phone = @mphone WHERE id = @updateid;
end
-- END UPDATING MEMBERS

-- CREATE PROC DELETES MEMBERS
CREATE PROC deletemember
@id int
as
begin
DELETE member WHERE id = @id
end
-- END DELETING PROC MEMBERS

--CREATE PROCEDURE RAED
CREATE PROC readallmember
as
begin
SELECT id 'ID', name 'Name', address 'Address', email 'M Email', bname 'B Name', 
bphone 'B Phone' ,phone 'Mem Phone', date 'Date' FROM member
end
--
Create proc countmember
as
begin
select COUNT(*) from member
end
-- END READING 

-- CREATE PROCEDURE COUNTS ALL MEMEBERS

-- END CREATING 4. Member TABLE USING STORED PROCEDYER

--------------------------------------------------------------

-- CRAETE 5. LENDBOOK TABLE
CREATE TABLE lendbook(
id int identity(1,1) PRIMARY KEY NOT NULL,
mid int  NOT NULL,
mname varchar(50),
madd varchar(50),
mphone varchar(20),
memail varchar(50),
bname varchar(30) NOT NULL,
idate date DEFAULT GETDATE(),
rdate date DEFAULT GETDATE()
)
-- END CRAETING LEND BOOK TABLE


-- CREATE PROC RECORDS LENDED BOOKS
CREATE PROC registerlendbook
@mid int,
@mname varchar(50),
@madd varchar(50),
@mphone varchar(20),
@memail varchar(50),
@bname varchar(40),
@issuedate date,
@rdate date
as
begin
INSERT INTO lendbook (mid,mname,madd,mphone,memail,bname,idate,rdate)
values(@mid,@mname,@madd,@mphone,@memail,@bname,@issuedate,@rdate)

update book set book.aqtty = aqtty-1 where book.name = @bname
end


--TEST

-- END CREATING LENDED BOOK



-- CREATE PROC UPDATES LENDED BOOKS
CREATE PROC updatelendbook
@mid int,
@mname varchar(50),
@madd varchar(50),
@mphone varchar(20),
@memail varchar(50),
@bname varchar(50),
@issuedate date,
@rdate date,
@updateid int
as
begin

UPDATE lendbook SET mid = @mid,mname = @mname, madd = @madd, @mphone=mphone ,
memail=@memail, bname = @bname ,
idate = @issuedate, rdate = @rdate WHERE id = @updateid
end



-- END CREATING LENDED BOOK

--CREATE PROC DELETES LENDED BOOK
CREATE PROC deletelendbook
@id int
as
begin
DELETE lendbook WHERE id = @id;
end
--END DELETING LENDED BOOK


-- CREATE COUNTING ALL DATE STORES IN THE DATABASE
CREATE PROC countlendbook
as
begin
select COUNT(*) FROM lendbook
end



-- CREATE PROCEDURE RAEDS ALL INFRMATION
CREATE PROC readalllendbook
as
begin
Select id 'ID', mid 'MID', mname 'M Name',madd 'M Address', mphone 'M Phone'
, memail 'M Email', bname 'Book Name', 
lendbook.idate 'Issue Date' , rdate 'Return Date' from lendbook;
end

--END READING DATA


-- END CREATING 5. LendBook TABLE USING STORED PROCEDYER

--------------------------------------------------------------

--CREATE 6. RETURNBOOK TABLE
CREATE TABLE returnbook(
id int identity(1,1) PRIMARY KEY NOT NULL,
mid int  NOT NULL,
mname varchar(50),
madd varchar(50),
mphone varchar(20),
memail varchar(50),
bname varchar(50) NOT NULL,
rdate varchar(50) NOT NULL,
elap int NOT NULL,
fine float
)
-- END CRAETING TABLE RETURN BOOK

-- CREATE PROC RECORDS 
Create PROC registerreturnbook
@mid int,
@mname varchar(50),
@madd varchar(50),
@mphone varchar(20),
@memail varchar(50),
@bname varchar(40),
@rdate varchar(50),
@elap int,
@fine float
as
begin
INSERT INTO returnbook(mid,mname,madd,mphone,memail,bname,rdate,elap,fine)
values(@mid,@mname,@madd,@mphone,@memail,@bname,@rdate,@elap,@fine)

end 
-- END RECORDING

-- CREATE UPDATING PROC 
CREATE  PROC updatereturnbook
@bname varchar(40),
@id int
as
begin
update book set book.aqtty = aqtty+1 where book.name = @bname
Delete returnbook where id = @id
end
-- END UPDATEING

--CREATE PROCEDURE DELETES RETUNED BOOKS
CREATE PROC deletereturnbook 
@id int
as
begin
DELETE returnbook where @id = @id
end
-- END DELETIG 
-- CREATE PROC RAEDS ALL RETURNED BOOKS
CREATE PROC readallreturnbook
as
begin
Select mid 'MID', mname 'M Name',madd 'M Address', mphone 'M Phone'
, memail 'M Email', bname 'Book Name',rdate 'Retrun Date', 
elap 'Day Elapsed', fine 'Fine' from returnbook
end
-- END READING

-- CREATE COUNTING RETURN BOOKS
CREATE PROC countreturnbook
as
begin
select count(*) from returnbook
end


-- END CREATING 6. RETURN BOOK TABLE 
--------------------------------------------------------------

-- CRAETE 7. USER TABLE
CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50) NOT NULL,
	sex varchar(10) NOT NULL,
	username VARCHAR(50) UNIQUE NOT NULL,
	password VARCHAR(50) NOT NULL,
	utype varchar(12) DEFAULT user,
	phone varchar(30) UNIQUE NOT NULL,
	photo image,
	date date DEFAULT GETDATE()
)

-- CREATE PROC RECORDS USERS
CREATE PROC registeruser
@name varchar(50),
@sex varchar(30),
@username varchar(30),
@password varchar(40),
@utype varchar(20),
@phone varchar(30),
@photo image
as
begin 
Insert Into users(name,sex,username,password,utype,phone,photo)
VALUES(@name,@sex,@username,@password,@utype,@phone,@photo)
end
-- END REGISTERING USERS

-- CREATE PROC UPDATES USERS
CREATE PROC updateuser
@name varchar(50),
@sex varchar(30),
@username varchar(30),
@password varchar(40),
@utype varchar(20),
@phone varchar(30),
@photo image,
@updateId int
as
begin 
UPDATE users SET name= @name , sex = @sex , username = @username , 
password = @password, utype = @utype , phone = @phone, photo = @photo WHERE id = @updateId
end
-- END UPDATES 

--CREATE PROC DELETES USERS

CREATE PROC deleteuser
@id int
as
begin
Delete users Where id =@id
end

--END DELEEING USERS

-- CREATE PROC READS ALL USERS
CREATE PROC readusersepical
@username varchar(30)
as   
begin
SELECT id 'ID', name 'Full name', sex 'Sex', username 'Username',
password 'Password',utype 'Role', phone 'Phone No', date 'Date' from users 
WHERE username != @username
end

CREATE PROC readusers
as   
begin
SELECT id 'ID', name 'Full name', sex 'Sex', username 'Username',
password 'Password',utype 'Role', phone 'Phone No', date 'Date' from users 
end
-- Search User Image
create proc searchuserimage
@id int
as
begin
select photo from users where id=@id;
end
-- END RAEDING USERS

--CREATE COUNTING USERS
CREATE PROC countUser
as
begin
select count(*) FROM users
end
-- END COUNTING USERS

-- update user profile image and name
Create proc updateProfile
@name varchar(50),
@sex varchar(10),
@phone varchar(30),
@photo image,
@username varchar(100)
as
begin
 update users set name=@name, sex=@sex, phone =@phone, photo=@photo 
 where username=@username
end
--	
-- searchuserimage by username
create proc searchimage
@username varchar(20)
as
begin
select photo from users where username = @username;
end
-- END 7. User Tabel
---------------------------------------------------------------

-- 8.CREATE REPORT

--  PREPARING DOCUMENT TO LEND BOOOK
CREATE PROC reportLendBook
@id int
as
begin
Select mid 'MID', mname 'M Name',madd 'M Address', mphone 'M Phone'
, memail 'M Email', bname 'Book Name', 
lendbook.idate 'Issue Date' , rdate 'Return Date' from lendbook where mid = @id;
end

CREATE PROC reportLendBookALL
as
begin
Select mid 'MID', mname 'M Name',madd 'M Address', mphone 'M Phone'
, memail 'M Email', bname 'Book Name', 
lendbook.idate 'Issue Date' , rdate 'Return Date' from lendbook
end



CREATE PROC readAuthorReport 
@name varchar(50)
as
begin
	
Select a.id 'Author ID',a.name 'Author Name',
a.address 'Address', 
a.experience 'Experience',
b.name 'Book Name',
b.type 'Type',
b.qtty 'Quantity',
b.aqtty 'Avalibale Qtty',
b.qtty-b.aqtty 'Lended'
from author a  INNER JOIN book b on 
a.id = b.id where a.name = @name ;
end



CREATE PROC readAllAthorReports
as
begin
Select a.id 'Author ID',a.name 'Author Name',
a.address 'Address', 
a.experience 'Experience',
b.name 'Book Name',
b.type 'Type',
b.qtty 'Quantity',
b.aqtty 'Avalibale Qtty',
b.qtty-b.aqtty 'Lended'
from book b INNER JOIN author a 
on
a.id = b.id;
end

------------------
CREATE PROC invoceLendBook
as
begin
Select top 1 id, mid 'MID', mname 'M Name',madd 'M Address', mphone 'M Phone'
, memail 'M Email', bname 'Book Name', 
lendbook.idate 'Issue Date' , rdate 'Return Date' from lendbook order by 1 desc
end

-- END 8- REPORT.


--END OUR DATABASE QUERY ✔✔✔✔