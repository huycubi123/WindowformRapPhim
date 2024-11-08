--create database QLRapPhim

use QLRapPhim

create table tblUser(
	UserID int IDENTITY(1,1) primary key,
	Name nvarchar(50),
	Gender nvarchar(10),
	BirthDay Date,
	TypeUser varchar(10) --HSSV:-10%,
);

CREATE TABLE tblCinema (
    CinemaID varchar(20) primary key,
    CinemaName NVARCHAR(50) NOT NULL,
	Amount int,
    Address NVARCHAR(100)
);

CREATE TABLE tblShowRoom (
    RoomID nvarchar(50) primary key,
    RoomName NVARCHAR(50) NOT NULL,
	CinemaID varchar(20)
	FOREIGN KEY (CinemaID) REFERENCES tblCinema(CinemaID),
);

create table tblStaff
(
	StaffID varchar(50) primary key,
	Name nvarchar(50),
	Gender nvarchar(10),
	BirthDay Date,
	NumberPhone varchar(12),
	WorkStartDate Date,
	Password nvarchar(20),
	Type_Account nvarchar(10),
	CinemaID varchar(20)
	foreign key (CinemaID) references tblCinema(CinemaID)
);

create table tblFilm
(
	FilmID varchar(20) primary key,
	Name nvarchar(50),
	Language nvarchar(50),
	Director nvarchar(50),
	ProductionDate Date,
	Price int,
	Status nvarchar(20),
	FilmImg nvarchar(50)
);

create table tblShowtime
(
	ShowtimeID varchar(50) primary key,
	FilmID varchar(20),
	CinemaID varchar(20),
	RoomID nvarchar(50),
	Showtime datetime,
	FOREIGN KEY (FilmID) REFERENCES tblFilm(FilmID),
    FOREIGN KEY (CinemaID) REFERENCES tblCinema(CinemaID),
	FOREIGN KEY (RoomID) REFERENCES tblShowRoom(RoomID)
	on update cascade
);


create table tblInvoice
(
	InvoiceID nvarchar(50) PRIMARY key,
    PaymentDate DATETIME NOT NULL,
    PaymentMethod NVARCHAR(50), -- Phương thức thanh toán (ví dụ: thẻ, tiền mặt)
	ToTal int,
    UserID INT,
	StaffID varchar(50),
    FOREIGN KEY (UserID) REFERENCES tblUser(UserID),
    FOREIGN KEY (StaffID) REFERENCES tblStaff(StaffID)
	on update cascade
);

CREATE TABLE tblSeat (
    SeatID nvarchar(50) primary key,
	RoomID nvarchar(50)
    FOREIGN KEY (RoomID) REFERENCES tblShowRoom(RoomID),
);

create table tblTicket
(
	TicketID nvarchar(50) primary key,
	SeatID nvarchar(50),
	TypeTicket varchar(10), --HSSV: hoc sinh sinh vien, C < 10 tuoi, N: vé bình thường 
	ShowtimeID varchar(50),
	InvoiceID nvarchar(50),
	FinalPrice int,
	FOREIGN KEY (ShowtimeID) REFERENCES tblShowtime(ShowtimeID),
	FOREIGN KEY (InvoiceID) REFERENCES tblInvoice(InvoiceID),
	FOREIGN KEY (SeatID) REFERENCES tblSeat(SeatID)
	on update cascade
);


--insert tblCinema
insert tblCinema (CinemaID,CinemaName,Amount,Address) values (N'SKPGP',N'Skope Giải Phóng',5,N'67-Định Công-Hoàng Mai-Hà Nội')
insert tblCinema (CinemaID,CinemaName,Amount,Address) values (N'SKPNT',N'Skope Nguyễn Trãi',6,N'120-Nguyễn Trãi-Thanh Xuân-Hà Nội')
insert tblCinema (CinemaID,CinemaName,Amount,Address) values (N'SKPCG',N'Skope Cầu Giấy',5,N'3-Cầu Giấy-Đống Đa-Hà Nội')
insert tblCinema (CinemaID,CinemaName,Amount,Address) values (N'SKPHD',N'Skope Hải Dương',4,N'158-Ngô Quyền-Hải Dương')
--insert tblStaff
insert tblStaff (StaffID,Name,Password,Type_Account) values ('Admin','admin','admin','Admin')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV001',N'Nguyễn Thế Định',N'Nam','5-18-2004','0984983258','2-25-2024','123','Staff','SKPHD')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV002',N'Nguyễn Văn Hải',N'Nam','8-8-2004','0947365489','4-5-2023','123','Staff','SKPNT')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV003',N'Nguyễn Tuần Linh',N'Nữ','3-8-2005','0947884783','7-4-2022','123','Staff','SKPCG')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV004',N'Vũ Đức Duy Anh',N'Nam','10-20-2004','0968473463','9-1-2024','123','Staff','SKPGP')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV005',N'Phí Gia Huy',N'Nam','9-2-2003','0875673245','1-1-2023','123','Staff','SKPGP')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV006',N'Nguyễn Minh Hiếu','Nam','4-4-2004','0985746375','2-25-2024','123','Staff','SKPHD')
--insert tblFilm
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status) values (N'PB',N'Peaky Blinders',N'Tiếng Anh',N'Steven Knight','9-12-2013',50000,N'Đang Chiếu')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status) values (N'CC',N'CoCo',N'Tiếng Anh',N'Lee Unkrich','10-20-2017',70000,'Đang Chiếu')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status) values (N'MDD',N'Mộ Đom Đóm',N'Tiếng Nhật',N'Takahata Isao','4-16-1988',70000,N'Đang Chiếu')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status) values (N'BWY',N'Be With You',N'Tiếng Hàn',N'Lee Jang-hoon','3-14-2018',70000,N'Đang Chiếu')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status) values (N'NBN',N'Nhà Bà Nữ',N'Tiếng Việt',N'Trấn Thành','1-11-2023',80000,N'Ngừng Chiếu')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status) values (N'EVT',N'Em Và Trịnh',N'Tiếng Việt',N'Phan Gia Nhật Linh','6-10-2022',70000,N'Đang Chiếu')
--insert Showtime
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime) values ('PB-SKPGP-31102024-2000','PB','SKPGP','10-31-2024 20:00:00')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime) values ('CC-SKPCG-11012024-1930','CC','SKPGP','11-1-2024 19:30:00')













