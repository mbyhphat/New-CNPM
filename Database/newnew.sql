---TẠO DATABASE--
CREATE DATABASE QuanLyGaraOTo
GO 
use QuanLyGaraOTo
GO 
SET DATEFORMAT dmy
GO
CREATE TABLE THAMSO
(
	SoXeTiepNhanToiDa int NOT NULL,
	TiLeDonGiaBan numeric(4, 2) NOT NULL
)
GO

CREATE TABLE KHACHHANG
(
	MaKhachHang int identity NOT NULL,
	TenChuXe nvarchar(40) NOT NULL,
	DiaChi nvarchar(80) NOT NULL,
	Email nvarchar(80) NOT NULL,
	SDT varchar(11) NOT NULL
	PRIMARY KEY(MaKhachHang)
)
GO
CREATE TABLE HIEUXE
(
	MaHieuXe int identity NOT NULL,
	TenHieuXe nvarchar(40) NOT NULL
	PRIMARY KEY(MaHieuXe)
)
GO
CREATE TABLE XE
(
	BienSo varchar(20) NOT NULL,
	MaKhachHang int NOT NULL,
	MaHieuXe int NOT NULL,
	NgayTiepNhan date NOT NULL,
	TienNo money NOT NULL
	PRIMARY KEY(BienSo),
)
GO
CREATE TABLE PHIEUSUACHUA
(
	MaPhieuSuaChua int identity NOT NULL,
	BienSo varchar(20) NOT NULL,
	NgaySuaChua date NOT NULL,
	TongTien money NOT NULL
	PRIMARY KEY(MaPhieuSuaChua)
)
GO
CREATE TABLE TIENCONG
(
	MaTienCong int identity NOT NULL,
	NoiDung nvarchar(100) NOT NULL,
	SoTienCong money NOT NULL
	PRIMARY KEY(MaTienCong)
)
GO
CREATE TABLE CHITIETPHIEUSUACHUA
(
	MaChiTietPhieuSuaChua int identity NOT NULL,
	MaPhieuSuaChua int NOT NULL,
	MaTienCong int NOT NULL,
	TienCong money NOT NULL,
	TongTienVatTuPhuTung money NOT NULL,
	TongCong money NOT NULL
	PRIMARY KEY(MaChiTietPhieuSuaChua),
)
GO
CREATE TABLE VATTUPHUTUNG
(
	MaVatTuPhuTung int identity NOT NULL,
	TenVatTuPhuTung nvarchar(80) NOT NULL,
	DonGiaNhap money NOT NULL,
	DonGiaBan money NOT NULL,
	SoLuongTon int NOT NULL
	PRIMARY KEY(MaVatTuPhuTung)
)
GO
CREATE TABLE CHITIETSUDUNGVATTUPHUTUNG
(
	MaChiTietPhieuSuaChua int NOT NULL,
	MaVatTuPhuTung int NOT NULL,
	SoLuong int NOT NULL,
	DonGia money NOT NULL,
	ThanhTien money NOT NULL
	PRIMARY KEY(MaChiTietPhieuSuaChua, MaVatTuPhuTung)
)
GO
CREATE TABLE PHIEUNHAPVATTUPHUTUNG 
(
	MaPhieuNhap int identity NOT NULL,
	NgayNhap date NOT NULL,
	TongTien money NOT NULL,
	PRIMARY KEY(MaPhieuNhap)
)
GO
CREATE TABLE CHITIETPHIEUNHAP
(
	MaPhieuNhap int NOT NULL,
	MaVatTuPhuTung int NOT NULL,
	SoLuongNhap int NOT NULL,
	DonGiaNhap money NOT NULL,
	ThanhTien money NOT NULL,
	PRIMARY KEY(MaphieuNhap, MaVatTuPhuTung)
)
GO 
CREATE TABLE BAOCAOTONKHO  
(
	MaVatTuPhuTung int NOT NULL,
	Thang int NOT NULL,
	Nam int NOT NULL,
	TonDau int NOT NULL,
	PhatSinh int NOT NULL,
	TonCuoi int NOT NULL,
	PRIMARY KEY(Thang, Nam, MaVatTuPhuTung)
)
GO
CREATE TABLE PHIEUTHUTIEN
(
	MaPhieuThuTien int identity NOT NULL,
	BienSo varchar(20) NOT NULL,
	NgayThu date NOT NULL,
	SoTienThu money NOT NULL,
	PRIMARY KEY(MaPhieuThuTien)
)
GO
CREATE TABLE BAOCAODOANHSO
(
	MaBaoCaoDoanhSo int identity NOT NULL,
	TongDoanhThu money NOT NULL,
	Thang int NOT NULL,
	Nam int NOT NULL,
	PRIMARY KEY(MaBaoCaoDoanhSo)
)
GO
CREATE TABLE CHITIETBAOCAODOANHSO
(
	MaBaoCaoDoanhSo int NOT NULL,
	MaHieuXe int NOT NULL,
	SoLuotSua int NOT NULL,
	ThanhTien money NOT NULL,
	TiLe numeric(4,2) NOT NULL,
	PRIMARY KEY(MaBaoCaoDoanhSo, MaHieuXe)
)
GO
---Tao bang tai khoan---
CREATE TABLE TAIKHOAN
(
	Username nvarchar(100),
	Pass_word nvarchar(100),
	Type int,	---0 là nhân viên, 1 là admin
	Birthday date,
	CCCD varchar(30),
	Email nvarchar(100),
	SDT varchar(11)
)
Set dateformat dmy
INSERT INTO TAIKHOAN (Username, Pass_word, Type, Birthday, CCCD, Email, SDT) VALUES (N'Uit', N'K2022', 1, '27-11-2004', '042204001498', N'K2022@gm.uit.edu.vn', '0965378524')
INSERT INTO TAIKHOAN (Username, Pass_word, Type, Birthday, CCCD, Email, SDT) VALUES (N'sv', N'K2022', 0, '27/11/2004', '042204001498', N'K2022@gm.uit.edu.vn', '0965378524')
SELECT * FROM TAIKHOAN
---HOAC
GO
CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN 
SELECT * FROM TAIKHOAN WHERE Username = @username AND Pass_word = @password
END
GO
EXEC USP_Login @username = 'Uit'
GO
---TẠO KHÓA NGOẠI----
ALTER TABLE XE ADD
CONSTRAINT FK_XE_KH FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang),
CONSTRAINT FK_XE_HX FOREIGN KEY (MaHieuXe) REFERENCES HIEUXE(MaHieuXe)
ALTER TABLE PHIEUSUACHUA ADD
CONSTRAINT FK_PSC_BS FOREIGN KEY (BienSo) REFERENCES XE(BienSo)
ALTER TABLE CHITIETPHIEUSUACHUA ADD
CONSTRAINT FK_CT_SC FOREIGN KEY (MaPhieuSuaChua) REFERENCES PHIEUSUACHUA(MaPhieuSuaChua),
CONSTRAINT FK_CT_TC FOREIGN KEY (MaTienCong) REFERENCES TIENCONG(MaTienCong)
ALTER TABLE CHITIETSUDUNGVATTUPHUTUNG ADD
CONSTRAINT FK_CT_CTP FOREIGN KEY (MaChiTietPhieuSuaChua) REFERENCES CHITIETPHIEUSUACHUA(MaChiTietPhieuSuaChua),
CONSTRAINT FK_CT_VT FOREIGN KEY (MaVatTuPhuTung) REFERENCES VATTUPHUTUNG(MaVatTuPhuTung)
ALTER TABLE CHITIETPHIEUNHAP ADD
CONSTRAINT FK_CTPN_PN FOREIGN KEY (MaPhieuNhap) REFERENCES PHIEUNHAPVATTUPHUTUNG(MaPhieuNhap),
CONSTRAINT FK_CTPN_VT FOREIGN KEY (MaVatTuPhuTung) REFERENCES VATTUPHUTUNG(MaVatTuPhuTung)
ALTER TABLE BAOCAOTONKHO ADD
CONSTRAINT FK_BC_VT FOREIGN KEY (MaVatTuPhuTung) REFERENCES VATTUPHUTUNG(MaVatTuPhuTung)
ALTER TABLE PHIEUTHUTIEN ADD
CONSTRAINT FK_TT_XE FOREIGN KEY (BienSo) REFERENCES XE(BienSo)
ALTER TABLE CHITIETBAOCAODOANHSO ADD
CONSTRAINT FK_CT_DS FOREIGN KEY (MaBaoCaoDoanhSo) REFERENCES BAOCAODOANHSO(MaBaoCaoDoanhSo),
CONSTRAINT FK_CT_HX FOREIGN KEY (MaHieuXe) REFERENCES HIEUXE(MaHieuXe)
---TẠO TRIGGER---
GO
CREATE TRIGGER trg_ins_inxe ON XE 
FOR INSERT
AS
BEGIN
	DECLARE @soxetoida int;
	SELECT @soxetoida = SoXeTiepNhanToiDa FROM THAMSO
	IF EXISTS ( SELECT *
				FROM INSERTED
				GROUP BY NgayTiepNhan
				HAVING COUNT(BienSo) > @soxetoida)
	BEGIN 
		RAISERROR('LOI: SO XE SUA CHUA MOI NGAY VUOT QUA SO XE TIEP NHAN TOI DA!', 16, 1)
		ROLLBACK TRANSACTION 
	END
END
GO
CREATE TRIGGER trg_ins_invt ON VATTUPHUTUNG
FOR INSERT
AS
BEGIN
	DECLARE @tiledongiaban numeric(4, 2);
	SELECT @tiledongiaban = TiLeDonGiaBan FROM THAMSO
	IF EXISTS (SELECT *
			   FROM INSERTED
			   WHERE INSERTED.DonGiaBan <> @tiledongiaban * INSERTED.DonGiaNhap)
	BEGIN
		RAISERROR('LOI: GIA BAN KHONG BANG TI LE GIA NHAP', 16, 1)
		ROLLBACK TRANSACTION
	END
END
GO
CREATE TRIGGER trg_ins_upphieu ON VATTUPHUTUNG
FOR UPDATE
AS
BEGIN
	DECLARE @tiledongiaban numeric(4, 2);
	SELECT @tiledongiaban = TiLeDonGiaBan FROM THAMSO
	IF EXISTS (SELECT *
			   FROM INSERTED 
			   INNER JOIN DELETED ON INSERTED.MaVatTuPhuTung = DELETED.MaVatTuPhuTung
			   WHERE INSERTED.DonGiaBan <> @tiledongiaban * INSERTED.DonGiaNhap)
	BEGIN
		RAISERROR('LOI: GIA BAN KHONG BANG TI LE GIA NHAP', 16, 1)
		ROLLBACK TRANSACTION
	END
END
GO
CREATE TRIGGER trg_ins_inphieu ON PHIEUTHUTIEN
FOR INSERT
AS 
BEGIN
    IF EXISTS (SELECT *
			   FROM INSERTED
			   inner join xe on inserted.BienSo = xe.BienSo 
			   where inserted.SoTienThu > TienNo)
    BEGIN 
        RAISERROR('LOI: SO TIEN THU VUOT QUA SO TIEN KHACH HANG DANG NO', 16, 1)
        ROLLBACK TRANSACTION
    END
END
GO

CREATE TRIGGER trg_ins_upxe ON XE
FOR UPDATE
AS
BEGIN
	IF EXISTS (SELECT *
			   FROM deleted
			   WHERE deleted.TienNo < (SELECT SoTienThu
										FROM PHIEUTHUTIEN PT
										Where deleted.BienSo = PT.BienSo And MaPhieuThuTien = (Select IDENT_CURRENT('PHIEUTHUTIEN'))))
	BEGIN 
		RAISERROR('LOI: SO TIEN THU VUOT QUA SO TIEN KHACH HANG DANG NO!', 16, 1)
		ROLLBACK TRANSACTION
	END
END
drop trigger trg_ins_upxe
GO

---Thêm dữ liệu vào các bảng---
INSERT INTO THAMSO(SoXeTiepNhanToiDa, TiLeDonGiaBan)
VALUES
('30', '1.05')
INSERT INTO KHACHHANG(TenChuXe, DiaChi, Email, SDT)
VALUES
(N'Bùi Tuấn Tâm', N'123/78 Lê Văn Chí, Q5, TpHCM547/11 Nguyễn Đình Chiểu, Q5, TpHCM', N'TamBui@gmail.com', '0988234512'), 
(N'Phạm Minh Thanh', N'123 Võ Văn Ngân, Thủ Đức, Q9, TpHCM', N'ThanhPham478@gmail.com', '0908256478'), 
(N'Vũ Văn Phi', N'123 Võ Văn Ngân, Thủ Đức, Q9, TpHCM', N'PhiVu626@gmail.com', '0903877626'), 
(N'Bùi Duy Thanh', N'260/18 Nguyễn Duy Trinh, Q2, TpHCM', N'ThanhDuyBui@gmail.com', '0916783565'), 
(N'Đặng Ngọc Trúc', N'123 Võ Văn Ngân, Thủ Đức, Q9, TpHCM', N'TrucNgocDang@gmail.com', '0908654763'), 
(N'Phan Huy Phi', N'34/34B Nguyễn Trãi, Q1, TpHCM', N'PhiPhan@gmail.com', '0910946996'), 
(N'Bùi Văn Trúc', N'227 Nguyễn Văn Cừ, Q5, TpHCM', N'TrucBui@gmail.com', '0974977169'), 
(N'Nguyễn Chí Tâm', N'251/11 Điện Biên Phủ, Q1, TpHCM', N'TamChiNguyen@gmail.com', '0930471185'), 
(N'Vũ Tuấn Vinh', N'251/11 Điện Biên Phủ, Q1, TpHCM', N'VinhVu@gmail.com', '0941451982'), 
(N'Vũ Văn Trung', N'45/2 An Dương Vương, Q5, TpHCM', N'TrungVu@gmail.com', '0905132204')

---DBCC CHECKIDENT ('KHACHHANG', RESEED, 0);
SELECT * FROM KHACHHANG

INSERT INTO HIEUXE(TenHieuXe)
VALUES
('HonDa'), 
('ToYoTa'), 
('SuZuKi'), 
('Ford'), 
('Hyundai'), 
('Mazda'), 
('Kia'), 
('Mercedes-Benz'), 
('Chevrolet'), 
('Mitsubishi')

SELECT * FROM HIEUXE

INSERT INTO XE(BienSo, MaKhachHang, MaHieuXe, NgayTiepNhan, TienNo)
VALUES
('59H1-869.60', '1', '3', '01/01/2024', '0'),
('59X1-200.70', '2', '4', '01/01/2024', '0'),
('59X1-312.49', '3', '7', '01/01/2024', '0'),
('59B1-398.68', '4', '4', '01/01/2024', '0'),
('59X1-871.98', '5', '2', '01/01/2024', '0'),
('59T1-747.11', '6', '2', '01/01/2024', '0'),
('59H1-021.17', '7', '9', '01/01/2024', '0'),
('59T1-925.22', '8', '10', '01/01/2024', '0'),
('59T1-181.56', '9', '1', '01/01/2024', '0'),
('59H1-808.68', '10', '3', '01/01/2024', '0')

SELECT * FROM XE
---LOAD DỮ LIỆU VÀ SẮP XẾP THEO MaKhachHang
SELECT *
FROM XE
ORDER BY MaKhachHang

SELECT * FROM PHIEUSUACHUA

INSERT INTO TIENCONG(NoiDung, SoTienCong)
VALUES
(N'Thay', '750000'),
(N'Sửa chữa', '900000'),
(N'Lắp đặt', '500000'),
(N'Vệ sinh', '550000'),
(N'Sơn', '350000')

SELECT * FROM TIENCONG

SELECT SoTienCong
FROM TIENCONG

---DBCC CHECKIDENT ('CHITIETPHIEUSUACHUA', RESEED, 0);
---DELETE FROM CHITIETPHIEUSUACHUA;
---LOAD DỮ LIỆU
SELECT * FROM CHITIETPHIEUSUACHUA

INSERT INTO VATTUPHUTUNG(TenVatTuPhuTung, DonGiaNhap, DonGiaBan, SoLuongTon)
VALUES
(N'Ắc quy AGM (Absorbent Glass Mat)', '1500000', '1575000', '0'), 
(N'Ắc quy Hybrid', '1500000', '1575000', '4'), 
(N'Ắc quy Bosch', '1500000', '1575000', '6'), 
(N'Ắc quy Varta', '1500000', '1575000', '6'), 
(N'Ắc quy Pinaco', '1500000', '1575000', '0'), 
(N'Kính chắn gió ô tô HonDa', '2000000', '2100000', '5'), 
(N'Kính chắn gió ô tô ToYoTa', '2100000', '2205000', '2'), 
(N'Kính chắn gió ô tô SuZuKi', '2110000', '2215500', '6'), 
(N'Kính chắn gió ô tô Ford', '2010000', '2110500', '2'), 
(N'Kính chắn gió ô tô Hyundai', '2500000', '2625000', '4'), 
(N'Kính chắn gió ô tô Mazda', '4000000', '4200000', '6'), 
(N'Kính chắn gió ô tô Kia', '2001000', '2101050', '0'), 
(N'Kính chắn gió ô tô Mercedes-Benz', '5000000', '5250000', '1'), 
(N'Kính chắn gió ô tô Chevrolet', '3000000', '3150000', '4'), 
(N'Kính chắn gió ô tô Mitsubishi', '2800000', '2940000', '6'), 
(N'Vô lăng ô tô HonDa', '2000000', '2100000', '6'), 
(N'Vô lăng ô tô ToYoTa', '2100000', '2205000', '6'), 
(N'Vô lăng ô tô SuZuKi', '2110000', '2215500', '2'), 
(N'Vô lăng ô tô Ford', '2010000', '2110500', '1'), 
(N'Vô lăng ô tô Hyundai', '2500000', '2625000', '0'), 
(N'Vô lăng ô tô Mazda', '4000000', '4200000', '2'), 
(N'Vô lăng ô tô Kia', '2001000', '2101050', '4'), 
(N'Vô lăng ô tô Mercedes-Benz', '5000000', '5250000', '5'), 
(N'Vô lăng ô tô Chevrolet', '3000000', '3150000', '3'), 
(N'Vô lăng ô tô Mitsubishi', '2800000', '2940000', '5'), 
(N'Lốp vỏ xe ô tô HonDa', '2000000', '2100000', '2'), 
(N'Lốp vỏ xe ô tô ToYoTa', '2100000', '2205000', '0'), 
(N'Lốp vỏ xe ô tô SuZuKi', '2110000', '2215500', '3'), 
(N'Lốp vỏ xe ô tô Ford', '2010000', '2110500', '6'), 
(N'Lốp vỏ xe ô tô Hyundai', '2500000', '2625000', '1'), 
(N'Lốp vỏ xe ô tô Mazda', '4000000', '4200000', '1'), 
(N'Lốp vỏ xe ô tô Kia', '2001000', '2101050', '0'), 
(N'Lốp vỏ xe ô tô Mercedes-Benz', '5000000', '5250000', '5'), 
(N'Lốp vỏ xe ô tô Chevrolet', '3000000', '3150000', '3'), 
(N'Lốp vỏ xe ô tô Mitsubishi', '2800000', '2940000', '6'), 
(N'Gương chiếu hậu ô tô HonDa', '2000000', '2100000', '6'), 
(N'Gương chiếu hậu ô tô ToYoTa', '2100000', '2205000', '4'), 
(N'Gương chiếu hậu ô tô SuZuKi', '2110000', '2215500', '3'), 
(N'Gương chiếu hậu ô tô Ford', '2010000', '2110500', '3'), 
(N'Gương chiếu hậu ô tô Hyundai', '2500000', '2625000', '3'), 
(N'Gương chiếu hậu ô tô Mazda', '4000000', '4200000', '3'), 
(N'Gương chiếu hậu ô tô Kia', '2001000', '2101050', '0'), 
(N'Gương chiếu hậu ô tô Mercedes-Benz', '5000000', '5250000', '1'), 
(N'Gương chiếu hậu ô tô Chevrolet', '3000000', '3150000', '6'), 
(N'Gương chiếu hậu ô tô Mitsubishi', '2800000', '2940000', '1'), 
(N'Cửa xe ô tô HonDa', '2000000', '2100000', '4'), 
(N'Cửa xe ô tô ToYoTa', '2100000', '2205000', '1'), 
(N'Cửa xe ô tô SuZuKi', '2110000', '2215500', '0'), 
(N'Cửa xe ô tô Ford', '2010000', '2110500', '3'), 
(N'Cửa xe ô tô Hyundai', '2500000', '2625000', '3')
---DBCC CHECKIDENT ('VATTUPHUTUNG', RESEED, 0);
---DELETE FROM VATTUPHUTUNG;

---LOAD DỮ LIỆU
SELECT * FROM VATTUPHUTUNG


---LOAD DỮ LIỆU
SELECT * FROM CHITIETSUDUNGVATTUPHUTUNG


--DBCC CHECKIDENT ('PHIEUNHAPVATTUPHUTUNG', RESEED, 0);
--DELETE FROM PHIEUNHAPVATTUPHUTUNG
---LOAD DỮ LIỆU
SELECT * FROM PHIEUNHAPVATTUPHUTUNG


SELECT * FROM CHITIETPHIEUNHAP

--SELECT CT.SoLuongNhap - VT.SoLuongTon AS SoLuongSD
--FROM CHITIETPHIEUNHAP CT, VATTUPHUTUNG VT
--WHERE CT.MaVatTuPhuTung = VT.MaVatTuPhuTung

--SELECT DonGiaBan + 0.2*DonGiaBan
--FROM VATTUPHUTUNG

INSERT INTO BAOCAOTONKHO(MaVatTuPhuTung,Thang,Nam,TonDau,PhatSinh,TonCuoi)
VAlUES
('1','12','2023','0','0','0'),
('2','12','2023','0','0','0'),
('3','12','2023','0','0','0'),
('4','12','2023','0','0','0'),
('5','12','2023','0','0','0'),
('6','12','2023','0','0','0'),
('7','12','2023','0','0','0'),
('8','12','2023','0','0','0'),
('9','12','2023','0','0','0'),
('10','12','2023','0','0','0'),
('11','12','2023','0','0','0'),
('12','12','2023','0','0','0'),
('13','12','2023','0','0','0'),
('14','12','2023','0','0','0'),
('15','12','2023','0','0','0'),
('16','12','2023','0','0','0'),
('17','12','2023','0','0','0'),
('18','12','2023','0','0','0'),
('19','12','2023','0','0','0'),
('20','12','2023','0','0','0'),
('21','12','2023','0','0','0'),   
('22','12','2023','0','0','0'),   
('23','12','2023','0','0','0'), 
('24','12','2023','0','0','0'), 
('25','12','2023','0','0','0'), 
('26','12','2023','0','0','0'), 
('27','12','2023','0','0','0'), 
('28','12','2023','0','0','0'), 
('29','12','2023','0','0','0'), 
('30','12','2023','0','0','0'),
('31','12','2023','0','0','0'),   
('32','12','2023','0','0','0'),   
('33','12','2023','0','0','0'), 
('34','12','2023','0','0','0'), 
('35','12','2023','0','0','0'), 
('36','12','2023','0','0','0'), 
('37','12','2023','0','0','0'), 
('38','12','2023','0','0','0'), 
('39','12','2023','0','0','0'), 
('40','12','2023','0','0','0'),
('41','12','2023','0','0','0'),   
('42','12','2023','0','0','0'),   
('43','12','2023','0','0','0'), 
('44','12','2023','0','0','0'), 
('45','12','2023','0','0','0'), 
('46','12','2023','0','0','0'), 
('47','12','2023','0','0','0'), 
('48','12','2023','0','0','0'), 
('49','12','2023','0','0','0'), 
('50','12','2023','0','0','0')
---LOAD DỮ LIỆU
SELECT * FROM BAOCAOTONKHO

---DBCC CHECKIDENT ('PHIEUTHUTIEN', RESEED, 0);
----DELETE FROM PHIEUTHUTIEN
---LOAD DỮ LIỆU
SELECT * FROM PHIEUTHUTIEN

---LOAD DỮ LIỆU
SELECT * FROM BAOCAODOANHSO


--LOAD DỮ LIỆU
SELECT * FROM CHITIETBAOCAODOANHSO
GO 

---Xóa hàng dữ liệu---
---DELETE FROM XE
---WHERE MaKhachHang = '1'
---DELETE FROM PHIEUTHUTIEN
---WHERE MaPhieuThuTien = '1'


---Cập nhật dữ liệu
---UPDATE KHACHHANG KH, XE
---SET TienNo += 150000
---WHERE KH.MaKhachHang = XE.MaKhachHang

---In ra ngày định dạng dd-mm-yyyy
---SELECT FORMAT(NgayNhap, 'dd/MM/yyyy') AS NgayNhapFormatted
---FROM PHIEUNHAPVATTUPHUTUNG;

-- Tìm kiếm không dấu 
CREATE FUNCTION [fuConvertToUnsign1] 
( 
	@strInput NVARCHAR(4000) 
) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput 
	IF @strInput = '' RETURN @strInput 
	DECLARE @RT NVARCHAR(4000), @SIGN_CHARS NCHAR(136), @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int, @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN 
				IF @COUNTER=1 
					SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE 
					SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
				BREAK 
			END 
			SET @COUNTER1 = @COUNTER1 +1 
		END 
		SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-') RETURN @strInput 
END
GO

CREATE PROC USP_UpdateThayDoiThongTin
    @TenChuXe NVARCHAR(40),
    @Hieuxe NVARCHAR(40),
    @SDT VARCHAR(11),
    @Ngaytiepnhan DATE,
    @Diachi NVARCHAR(80),
    @Bienso VARCHAR(20)
AS
BEGIN
    -- Cập nhật thông tin cho bảng KHACHHANG
    UPDATE KHACHHANG
    SET TenChuXe = @TenChuXe,
        DiaChi = @Diachi,
        SDT = @SDT
    WHERE MaKhachHang = (
        SELECT MaKhachHang
        FROM XE
        WHERE BienSo = @Bienso
    )

    -- Cập nhật thông tin cho bảng XE
    UPDATE XE
    SET MaHieuXe = (
        SELECT MaHieuXe
        FROM HIEUXE
        WHERE TenHieuXe = @Hieuxe
    ),
        NgayTiepNhan = @Ngaytiepnhan
    WHERE BienSo = @Bienso
END
GO
