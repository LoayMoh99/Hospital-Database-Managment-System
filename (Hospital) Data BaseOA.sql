-------------Database creation-------------

Create database HMDS
Go
use HMDS
------------Table Creation-----------------

create table Hospital
(
H_ID int,
primary key (H_ID),
Name varchar(50) not null,
City varchar(50) not null,
District varchar(50),
Add_Line varchar(50),
Mang_SSN int
)

create table Registeration
(
SSN int,
UserType varchar(50),
FavouriteHobby varchar(50),
Username varchar(50) unique,
primary key (SSN),
PassCode varchar(50) 
)

create table Doctor
(
D_SSN int,
primary key (D_SSN),
Name varchar(50) ,
City varchar(50),
District varchar(50),
Add_Line varchar(50),
Gender char,
Ph_number int, 
DOB	date,
Dep_ID int,
)

create table Nurse
(
N_SSN int,
primary key (N_SSN),
Name varchar(50) ,
City varchar(50),
District varchar(50),
Add_Line varchar(50),
Gender char,
Ph_number int, 
DOB	date,
Experience int,
Hos_ID int,
NumOfHours int,
Foreign key (Hos_ID) references Hospital
ON DELETE CASCADE
ON UPDATE CASCADE
)

create table Patient
(
P_SSN int,
primary key (P_SSN),
Name varchar(50) ,
City varchar(50),
District varchar(50),
Add_Line varchar(50),
Gender char,
Ph_number int, 
DOB	date,
PWeight int,
Height int,
Blood_Type varchar(10)
)

create table Manager
(
M_SSN int,
M_Type varchar(50) default 'Manager',
primary key (M_SSN),
Name varchar(50) ,
City varchar(50),
District varchar(50),
Add_Line varchar(50),
Gender char,
Ph_number int, 
DOB	date,
)

create table Hospital_Complaint
(
Mang_SSN int,
Complaint varchar(50),
Foreign key (Mang_SSN) references Manager
ON DELETE CASCADE
ON UPDATE CASCADE
)
-----------inserting Hospital Foreign key--------------
alter table Hospital add foreign key (Mang_SSN) references Manager

create table Departments
(
D_ID int,
primary key (D_ID),
Name varchar(50) 
)
-----------inserting Doctor Foreign key--------------
alter table Doctor add foreign key (Dep_ID) references Departments

create table Equipment
(
E_ID int,
primary key (E_ID),
Name varchar(50) ,
Category varchar(50),
)

create table Medicine
(
M_ID int,
primary key (M_ID),
Name varchar(50) ,
)

create table Ambulance
(
A_ID int,
primary key (A_ID),
Available varchar(50) not null,
Hos_ID int,
Foreign key (Hos_ID) references Hospital
ON DELETE set NULL
ON UPDATE CASCADE
)

create table Rooms
(
R_ID int,
primary key (R_ID),
R_Type varchar(50) not null,
Available varchar(50) not null,
Hos_ID int,
Foreign key (Hos_ID) references Hospital
ON DELETE CASCADE
ON UPDATE CASCADE
)

----------------Relations Tables----------------
create table Doc_Works_on
(
Doc_SSN int,
Hos_ID int,
Foreign key (Doc_SSN) references Doctor
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign key (Hos_ID) references Hospital
ON DELETE CASCADE
ON UPDATE CASCADE
)

create table Dep_Belong_To
(
Dep_ID int,
Hos_ID int,
Foreign key (Dep_ID) references Departments
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign key (Hos_ID) references Hospital
ON DELETE CASCADE
ON UPDATE CASCADE
)


create table Eq_Belong_To
(
Eq_ID int,
Hos_ID int,
Foreign key (Eq_ID) references Equipment
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign key (Hos_ID) references Hospital
ON DELETE CASCADE
ON UPDATE CASCADE
)


create table Pat_Takes_Med  --Prescription
(
Pat_SSN int,
Med_ID int,
Foreign key (Pat_SSN) references Patient
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign key (Med_ID) references Medicine
ON DELETE CASCADE
ON UPDATE CASCADE,
NoTimes varchar(50),
Notes varchar(50)
)

----------------Medical Record Tables ----------------
create table Medical_Record
(
MR_ID int,
primary key (MR_ID),
Pat_SSN int,
Foreign key (Pat_SSN) references Patient
ON DELETE CASCADE
ON UPDATE CASCADE
)

create table MR_CronDisease
(
MR_ID int,
Disease_Name varchar(50),
Foreign key (MR_ID) references Medical_Record
ON DELETE CASCADE
ON UPDATE CASCADE
)

create table MR_Recds  --Records and its Date
(
MR_ID int,
R_Date Date,
Description varchar(MAX),
Doc_SSN int,
Foreign key (MR_ID) references Medical_Record
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign key (Doc_SSN) references Doctor
ON DELETE CASCADE
ON UPDATE CASCADE
)

create table MR_xray_Analysis
(
MR_ID int,
XrA_Data image,
Foreign key (MR_ID) references Medical_Record
ON DELETE CASCADE
ON UPDATE CASCADE
)

create table MR_BelongsTo_Hos
(
MR_ID int,
Hos_ID int,
Foreign key (MR_ID) references Medical_Record
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign key (Hos_ID) references Hospital
ON DELETE CASCADE
ON UPDATE CASCADE
)

create table Doc_Alter_MR
(
MR_ID int,
Doc_SSN int,
Foreign key (MR_ID) references Medical_Record
ON DELETE CASCADE
ON UPDATE CASCADE,
Foreign key (Doc_SSN) references Doctor
ON DELETE CASCADE
ON UPDATE CASCADE
)


-----------------Inserting values into tables----------------
insert into Manager
values
(111,'A','Loay','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'M',01067732282,'1-11-1999'),
(12340,'M','Mohamed','Cairo' , 'Dokki' , '166 Street Before Koshk a5o 3abdo' ,'M',01222332222,'1-2-1998'),
(12345,'M','Hamed','Cairo' , 'Maadii' , '21 Street Before Koshk abo 3abdo' ,'M',01033433333,'2-1-1999'),
(12349,'M','Abdallah','Cairo' , 'Mo2atam' , '99 Street Before Koshk om 7assan' ,'M',0114554444,'4-11-2000')

insert into Hospital 
values
(1,'Dar Elfouad','Cairo' , 'Madinet Nasr' , '37 Street Before Koshk abo 3abdo' , 12340),
(2,'57357','Cairo' , '6 Octobre' , '23 Street Before Koshk om 3abdo' , 12345),
(3,'500 500','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' , 12349)

insert into Registeration
values
(111,'Admin','13424722855250165167252225932922018523423423455118','loay99','24983171213285120988244110144521771471236056144176'),
(441,'Doctor','22221048249213402201392156613318479882171911284520','doc1','14081457839238225193184196188101214425415019724223'),
(442,'Doctor','22221048249213402201392156613318479882171911284520','doc2','19620822724024319910635372322441231411691601491010'),
(443,'Doctor','22221048249213402201392156613318479882171911284520','doc3','92240120193197237208213132186278524389317286112594'),
(444,'Doctor','22221048249213402201392156613318479882171911284520','doc4','20913925126661612231142825053302151381175203381572'),
(551,'Nurse','22221048249213402201392156613318479882171911284520','roro1','1521341676112153128502181915782870238452261732211'),
(552,'Nurse','22221048249213402201392156613318479882171911284520','roro2','12541249485213925574104902382016280176512081635620'),
(553,'Nurse','22221048249213402201392156613318479882171911284520','roro3','24217023115912321616498150638115123213291766020513'),
(554,'Nurse','22221048249213402201392156613318479882171911284520','roro4','3627811023514215723181208136112453997624919913183'),
(555,'Nurse','22221048249213402201392156613318479882171911284520','roro5','16162612004424184133124981141911001861219916178431'),
(556,'Nurse','22221048249213402201392156613318479882171911284520','roro6','030178957254572137321716901061674748201104212128'),
(557,'Nurse','22221048249213402201392156613318479882171911284520','roro7','90253196171841201023751243160190991991675314212389'),
(661,'Patient','79251241531671391321724120772171641541010923107153','pat1','16915022014141921298725416024413819752362322541472'),
(662,'Patient','79251241531671391321724120772171641541010923107153','pat2','14587244341752002462492151931952011682222287235183'),
(663,'Patient','79251241531671391321724120772171641541010923107153','pat3','54163958784240170188751164422315225423623213623418'),
(664,'Patient','79251241531671391321724120772171641541010923107153','pat4','5611143332261871883192881209147249671451741363237'),
(665,'Patient','79251241531671391321724120772171641541010923107153','pat5','43211183250252942081492009596181229695735671061957'),
(666,'Patient','79251241531671391321724120772171641541010923107153','pat6','79174134222383224319815799237243136229181763823100'),
(12340,'Manager','645738361027821212235520319082135183199194103250','man1','12318929124824692166332421501422145856552401589911'),
(12345,'Manager','645738361027821212235520319082135183199194103250','man2','38256284109193124225181911862322551622535596197120'),
(12349,'Manager','645738361027821212235520319082135183199194103250','man3','9232147476486236124811282268868146140145601467036')

insert into Departments
values
(331,'Dentistary'),
(334,'Surgery'),
(335,'Opthalmology'),
(338,'Urinary Tracts')

insert into Doctor
values
(441,'Loay','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'M',01067732982,'1999-11-1', 331),
(442,'Osama','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'M',01222222222,'1999-11-1', 334),
(443,'Adham','Cairo' , 'Maadii' , '21 Street Before Koshk abo 3abdo' ,'M',01033333333,'1999-11-1', 335),
(444,'Kareem','Cairo' , 'Mo2atam' , '99 Street Before Koshk om 7assan' ,'M',0114444444,'1999-11-1', 338)

insert into Nurse
values
(551,'Rehan','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'F',01067732282,'2009-11-06',3, 1,8),
(552,'Reham','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'F',01222332222,'2009-11-06', 2,1,6),
(553,'Abeer','Cairo' , 'Maadii' , '21 Street Before Koshk abo 3abdo' ,'F',01033433333,'2009-11-06', 2,1,6),
(554,'Kareema','Cairo' , 'Mo2atam' , '99 Street Before Koshk om 7assan' ,'F',0114554444,'2009-11-06',2, 2,8),
(555,'Gehan','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'F',01063322982,'2009-11-06', 1,2,8),
(556,'Hosneya','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'F',01221122222,'2009-11-06',2, 3,8),
(557,'Malak','Cairo' , 'Maadii' , '21 Street Before Koshk abo 3abdo' ,'F',01033933333,'2009-11-06',4, 3,8)

insert into Patient
values
(661,'Rehan','Cairo' , 'Dokki' , '11 Street Before Koshk a5o 3abdo' ,'F',01167732282,'1999-11-1',60.6,180,'O-'),
(662,'Reham','Cairo' , 'Dokki' , '12 Street Before Koshk a5o 3abdo' ,'F',01122332222,'1999-11-1',60.6,162,'B-'),
(663,'Ahmed','Cairo' , 'Maadii' , '61 Street Before Koshk abo 3abdo' ,'M',01133433333,'1999-11-1',60.6,159,'A-'),
(664,'Attia','Cairo' , 'Mo2atam' , '99 Street Before Koshk om 7assan' ,'M',0124554444,'1999-11-1',60.6,176,'A+'),
(665,'Hend','Cairo' , 'Dokki' , '21 Street Before Koshk a5o samah' ,'F',01263322982,'1999-11-1',60.6,170,'O+'),
(666,'Hosny','Cairo' , 'Dokki' , '13 Street Before Koshk a5o samah' ,'M',01231122222,'1999-11-1',60.6,183,'AB')

insert into Equipment
values
(701,'Dentist Equ','Dentistary'),
(702,'Surgery Equ','Surgery'),
(703,'Eyes Equ','Opthalmology'),
(704,'Tracts Equ','Urinary Tracts')

insert into Medicine
values
(801,'Ativan'),
(802,'Codeine'),
(803,'Lexapro'),
(804,'Omeprazole'),
(805,'Zoloft')

insert into Ambulance
values
(901,'Y',1),
(902,'Y',1),
(903,'Y',2),
(904,'Y',2),
(905,'Y',3),
(906,'Y',3)

insert into Rooms
values
(1001,'Normal','Y',1),
(1002,'Intensive Care','Y',1),
(1003,'Normal','Y',2),
(1004,'Intensive Care','Y',2),
(1005,'Normal','Y',3),
(1006,'Intensive Care','Y',3)

insert into Doc_Works_on
values
(441,1),
(442,1),
(443,1),
(444,1),
(441,2),
(442,2),
(443,2),
(444,2),
(441,3),
(442,3),
(443,3),
(444,3)

insert into Dep_Belong_To
values
(331,1),
(334,1),
(335,1),
(338,1),
(331,2),
(334,2),
(335,2),
(338,2),
(331,3),
(334,3),
(335,3),
(338,3)

insert into Eq_Belong_To
values
(701,1),
(702,1),
(703,1),
(704,1),
(701,2),
(702,2),
(703,2),
(704,2),
(701,3),
(702,3),
(703,3),
(704,3)

insert into Pat_Takes_Med
values 
(661,801,2,'After Lunch and Before Sleep'),
(661,803,2,'After Lunch and Before Sleep'),
(662,801,2,'After Lunch and Before Sleep'),
(662,804,2,'After Lunch and Before Sleep'),
(662,805,2,'After Lunch and Before Sleep'),
(663,802,2,'After Lunch and Before Sleep'),
(663,803,2,'After Lunch and Before Sleep'),
(663,805,2,'After Lunch and Before Sleep'),
(664,802,2,'After Lunch and Before Sleep'),
(665,801,2,'After Lunch and Before Sleep'),
(666,801,2,'After Lunch and Before Sleep'),
(666,805,2,'After Lunch and Before Sleep')

insert into Medical_Record
values
(221,661),
(222,662),
(223,663),
(224,664),
(225,665),
(226,666)

insert into MR_CronDisease
values
(221,'Hepatits'),

(222,'Kidney Disese'),
(222,'Heart Disese'),

(223,'Hepatits'),
(223,'Diabetes'),
(223,'Depression'),

(224,'Depression'),
(224,'Kidney Disese'),

(225,'Kidney Disese'),
(225,'Heart Disese'),

(226,'Hepatits'),
(226,'Diabetes'),
(225,'Heart Disese')

insert into MR_Recds
values
(221,'2009-11-06','Made a surgery' ,441),
(222,'2009-11-06','Made a surgery' ,441),
(223,'2009-11-06','Made a surgery' ,442),
(224,'2009-11-06','Made a surgery' ,442),
(225,'2009-11-06','Made a surgery' ,443),
(226,'2009-11-06','Made a surgery' ,444)

insert into MR_xray_Analysis
values
(221,null),
(222,null),
(223,null),
(224,null),
(225,null),
(226,null)

insert into MR_BelongsTo_Hos
values
(221,1),
(222,1),
(223,2),
(224,2),
(225,3),
(226,3)

insert into Doc_Alter_MR
values
(221,441),
(222,441),
(223,441),
(224,442),
(225,443),
(226,444)

--insert into Hospital_Complaint 
--values
--(12340,null),
--(12345,'Hospital is dirty!'),
--(12349,null)
