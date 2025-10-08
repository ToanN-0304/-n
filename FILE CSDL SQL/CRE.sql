create database QLSV

use QLSV 
GO

CREATE TABLE NGANH
 (   MANGANH VARCHAR(20) NOT NULL PRIMARY KEY,
     TENNGANH NVARCHAR(50) NOT NULL , 
 )

 CREATE TABLE LOP
 ( MALOP VARCHAR(20) NOT NULL PRIMARY KEY,
   TENLOP NVARCHAR(10) NOT NULL,
   MANGANH VARCHAR(20) FOREIGN KEY (MANGANH) REFERENCES NGANH(MANGANH),
   KHOAHOC NVARCHAR(10) NOT NULL,
   HEDT NVARCHAR(50) NOT NULL 
 )

 CREATE TABLE SINHVIEN
  (  MASV VARCHAR(20) NOT NULL PRIMARY KEY,
     HOTEN NVARCHAR(60) NOT NULL,
	 MALOP VARCHAR(20) FOREIGN KEY (MALOP) REFERENCES LOP(MALOP),
	 GT NVARCHAR(5) NOT NULL,
	 NGAYSINH DATE NOT NULL,
	 DIACHI NVARCHAR(100) NOT NULL,
  )

 Alter Table SINHVIEN
 ADD MANGANH VARCHAR(20) FOREIGN KEY (MANGANH) REFERENCES NGANH(MANGANH)

CREATE TABLE LG
 (   TK VARCHAR(20) NOT NULL PRIMARY KEY,
     PASS NVARCHAR(50) NOT NULL , 
	 TEN NVARCHAR(50) NOT NULL,
	 SDT NVARCHAR(10) NOT NULL,
	 MAGV VARCHAR(20) NOT NULL
 )

 INSERT INTO LG ([TK],[PASS],[TEN],[SDT],[MAGV])
VALUES (N'Test01',N'123456',N'Nguyễn Bá T',N'0912867xxx',686868),
       (N'T2',N'123',N'Trần Thanh X',N'091233xxx',121212),
	   (N'T3',N'123',N'Nguyễn Phú V',N'093243xxx',232323)



 INSERT INTO NGANH (MANGANH,TENNGANH)
 VALUES (N'TH',N'Công nghệ thông tin'),
        (N'CO',N'Công nghệ kỹ thuật ô tô'),
		(N'TA',N'Ngôn ngữ anh')
 
INSERT INTO LOP ([MALOP],[TENLOP],[MANGANH],[KHOAHOC],HEDT)
VALUES (001,N'TH29.34',N'TH',29,N'Chính quy'),
       (002,N'TH29.03',N'TH',29,N'Chính quy'),
	   (003,N'CO28.15',N'CO',28,N'Chính quy'),
       (004,N'TA29.21',N'TA',29,N'Chính quy'),
	   (005,N'TA29.05',N'TA',29,N'Chính quy'),
       (006,N'TH27.04',N'TH',27,N'Chính quy')

INSERT INTO SINHVIEN ([MASV],[MALOP],[GT],[NGAYSINH],[DIACHI],[HOTEN],MANGANH)
 VALUES (28231570,001,N'Nam','2005-04-03',N'Hà Nam',N'Nguyễn Bá Toàn',N'TH'),
        (29240001,001,N'Nam','2006-11-06',N'Hà Nội',N'Nguyễn Văn A',N'TH'),
        (29240002,001,N'Nam','2006-10-15',N'Thanh Hóa',N'Trần Văn B',N'TH'),
		(29240003,001,N'Nữ','2006-05-23',N'Hưng Yên',N'Nguyễn Thị H',N'TH'),
        (29240004,001,N'Nam','2006-09-06',N'Hà Nội',N'Bùi Quốc A',N'TH'),

        (29240011,002,N'Nam','2006-11-02',N'Hà Nội',N'Đào Quang H',N'TH'),
        (29240012,002,N'Nam','2006-10-03',N'Hà Nam',N'Trần Văn L',N'TH'),
		(29240013,002,N'Nữ','2006-04-23',N'Hưng Yên',N'Bùi Thị A',N'TH'),
        (29240014,002,N'Nam','2006-09-16',N'Hà Nội',N'Bùi Xuân H',N'TH'),
		(29240015,002,N'Nữ','2006-05-12',N'Hưng Yên',N'Phạm Thanh H',N'TH'),

        (28230001,003,N'Nam','2005-09-13',N'Bắc Ninh',N'Nguyễn Bá T',N'CO'),
        (28230002,003,N'Nam','2005-05-06',N'Bắc Giang',N'Trần Quang X',N'CO'),
		(28230003,003,N'Nam','2005-11-23',N'Tuyên Quang',N'Nguyễn Đình T',N'CO'),
        (28230004,003,N'Nam','2005-05-05',N'Hà Nam',N'Bùi Văn C',N'CO'),
        (28230005,003,N'Nam','2005-12-03',N'Hà Nội',N'Phạm Văn K',N'CO'),

		(29240111,004,N'Nam','2006-08-12',N'Bắc Giang',N'Đào Quang X',N'TA'),
        (29240112,004,N'Nam','2006-11-23',N'Hà Nam',N'Trần Văn D',N'TA'),
		(29240113,004,N'Nữ','2006-08-04',N'Hưng Yên',N'Bùi Thị B',N'TA'),
        (29240114,004,N'Nam','2006-07-16',N'Hà Nội',N'Bùi Xuân N',N'TA'),
		(29240115,004,N'Nữ','2006-02-12',N'Bắc Ninh',N'Phạm Thanh M',N'TA'),

		(29241111,005,N'Nam','2006-03-22',N'Bắc Giang',N'Vũ Xuân T',N'TA'),
        (29241112,005,N'Nam','2006-10-20',N'Hà Nam',N'Trần Văn V',N'TA'),
		(29241113,005,N'Nữ','2006-01-14',N'Hưng Yên',N'Bùi Thanh H',N'TA'),
        (29241114,005,N'Nam','2006-08-26',N'Hà Nội',N'Trần Xuân N',N'TA'),
		(29241115,005,N'Nữ','2006-02-15',N'Bắc Ninh',N'Phạm Kiều N',N'TA'),

		(27220001,006,N'Nam','2004-06-07',N'Hà Nam',N'Nguyễn Bá C',N'TH'),
		(27220002,006,N'Nam','2004-03-17',N'Hà Nam',N'Nguyễn Trọng P',N'TH'),
		(27220003,006,N'Nam','2004-11-08',N'Bắc Ninh',N'Trần Văn Q',N'TH'),
		(27220004,006,N'Nam','2004-04-04',N'Hà Nội',N'Lý Sự C',N'TH'),
		(27220005,006,N'Nam','2004-05-25',N'Hà Nội',N'Nguyễn Thị O',N'TH')
        
UPDATE SINHVIEN
SET MANGANH = N'TH'
WHERE MALOP = 001

