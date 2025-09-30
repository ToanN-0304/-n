create database QLSV

use QLSV 
GO

CREATE TABLE NGANH
 (   MANGANH VARCHAR(20) PRIMARY KEY,
     TENNGANH NVARCHAR(50) , 
 )

 CREATE TABLE LOP
 ( MALOP VARCHAR(20) PRIMARY KEY,
   TENLOP NVARCHAR(10),
   MANGANH VARCHAR(20) FOREIGN KEY (MANGANH) REFERENCES NGANH(MANGANH),
   KHOAHOC NVARCHAR(10),
   HEDT NVARCHAR(50), 
 )

 CREATE TABLE SINHVIEN
  (  MASV VARCHAR(20) PRIMARY KEY,
     HOTEN NVARCHAR(60) ,
	 MALOP VARCHAR(20) FOREIGN KEY (MALOP) REFERENCES LOP(MALOP),
	 GT NVARCHAR(5) DEFAULT N'Nam',
	 NGAYSINH DATE DEFAULT GETDATE(),
	 DIACHI NVARCHAR(100),
  )

 Alter Table SINHVIEN
 ADD MANGANH VARCHAR(20) FOREIGN KEY (MANGANH) REFERENCES NGANH(MANGANH)

 INSERT INTO NGANH (MANGANH,TENNGANH)
 VALUES (N'TH',N'Công nghệ thông tin'),
        (N'CO',N'Công nghệ kỹ thuật ô tô'),
		(N'TA',N'Ngôn ngữ anh')
 
INSERT INTO LOP ([MALOP],[TENLOP],[MANGANH],[KHOAHOC])
VALUES (001,N'TH29.34',N'TH',29),
       (002,N'TH29.03',N'TH',29),
	   (003,N'CO28.15',N'CO',28),
       (004,N'TA29.21',N'TA',29),
	   (005,N'TA29.05',N'TA',29),
       (006,N'TH27.04',N'TH',27)

INSERT INTO SINHVIEN ([MASV],[MALOP],[GT],[NGAYSINH],[DIACHI],[HOTEN])
 VALUES (28231570,001,N'Nam','2005-04-03',N'Hà Nam',N'Nguyễn Bá Toàn'),
        (29240001,001,N'Nam','2006-11-06',N'Hà Nội',N'Nguyễn Văn A'),
        (29240002,001,N'Nam','2006-10-15',N'Thanh Hóa',N'Trần Văn B'),
		(29240003,001,N'Nữ','2006-05-23',N'Hưng Yên',N'Nguyễn Thị H'),
        (29240004,001,N'Nam','2006-09-06',N'Hà Nội',N'Bùi Quốc A'),

        (29240011,002,N'Nam','2006-11-02',N'Hà Nội',N'Đào Quang H'),
        (29240012,002,N'Nam','2006-10-03',N'Hà Nam',N'Trần Văn L'),
		(29240013,002,N'Nữ','2006-04-23',N'Hưng Yên',N'Bùi Thị A'),
        (29240014,002,N'Nam','2006-09-16',N'Hà Nội',N'Bùi Xuân H'),
		(29240015,002,N'Nữ','2006-05-12',N'Hưng Yên',N'Phạm Thanh H'),

        (28230001,003,N'Nam','2005-09-13',N'Bắc Ninh',N'Nguyễn Bá T'),
        (28230002,003,N'Nam','2005-05-06',N'Bắc Giang',N'Trần Quang X'),
		(28230003,003,N'Nam','2005-11-23',N'Tuyên Quang',N'Nguyễn Đình T'),
        (28230004,003,N'Nam','2005-05-05',N'Hà Nam',N'Bùi Văn C'),
        (28230005,003,N'Nam','2005-12-03',N'Hà Nội',N'Phạm Văn K'),

		(29240111,004,N'Nam','2006-08-12',N'Bắc Giang',N'Đào Quang X'),
        (29240112,004,N'Nam','2006-11-23',N'Hà Nam',N'Trần Văn D'),
		(29240113,004,N'Nữ','2006-08-04',N'Hưng Yên',N'Bùi Thị B'),
        (29240114,004,N'Nam','2006-07-16',N'Hà Nội',N'Bùi Xuân N'),
		(29240115,004,N'Nữ','2006-02-12',N'Bắc Ninh',N'Phạm Thanh M'),

		(29241111,005,N'Nam','2006-03-22',N'Bắc Giang',N'Vũ Xuân T'),
        (29241112,005,N'Nam','2006-10-20',N'Hà Nam',N'Trần Văn V'),
		(29241113,005,N'Nữ','2006-01-14',N'Hưng Yên',N'Bùi Thanh H'),
        (29241114,005,N'Nam','2006-08-26',N'Hà Nội',N'Trần Xuân N'),
		(29241115,005,N'Nữ','2006-02-15',N'Bắc Ninh',N'Phạm Kiều N'),

		(27220001,006,N'Nam','2004-06-07',N'Hà Nam',N'Nguyễn Bá C'),
		(27220002,006,N'Nam','2004-03-17',N'Hà Nam',N'Nguyễn Trọng P'),
		(27220003,006,N'Nam','2004-11-08',N'Bắc Ninh',N'Trần Văn Q'),
		(27220004,006,N'Nam','2004-04-04',N'Hà Nội',N'Lý Sự C'),
		(27220005,006,N'Nam','2004-05-25',N'Hà Nội',N'Nguyễn Thị O')
        
UPDATE SINHVIEN
SET MANGANH = N'TH'
WHERE MALOP = 001

