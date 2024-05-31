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
(N'Vũ Văn Trung', N'45/2 An Dương Vương, Q5, TpHCM', N'TrungVu@gmail.com', '0905132204'), 
(N'Bùi Huy Linh', N'45/2 An Dương Vương, Q5, TpHCM', N'LinhHuyBui@gmail.com', '0959766164'), 
(N'Đỗ Nhật Trúc', N'45 Nguyễn Cảnh Chân, Q1, TpHCM', N'TrucDo360@gmail.com', '0987863360'), 
(N'Trần Nhật Long', N'251/11 Điện Biên Phủ, Q1, TpHCM', N'LongNhatTran@gmail.com', '0922702470'), 
(N'Bùi Tuấn Phi', N'45 Nguyễn Cảnh Chân, Q1, TpHCM', N'PhiBui348@gmail.com', '0969022348'), 
(N'Nguyễn Hoài Tâm', N'123/10 Lê Văn Việt, Q2, TpHCM', N'TamHoaiNguyen@gmail.com', '0962095749'), 
(N'Đỗ Thị Tuấn', N'123 Võ Văn Ngân, Thủ Đức, Q9, TpHCM', N'TuanThiDo@gmail.com', '0968473024'), 
(N'Lê Chí Linh', N'45 Nguyễn Cảnh Chân, Q1, TpHCM', N'LinhLe@gmail.com', '0944558016'), 
(N'Bùi Duy Tuấn', N'43/12 Nguyễn Văn Tăng, Thủ Đức, Q9, TpHCM', N'TuanBui059@gmail.com', '0980105059'), 
(N'Phạm Văn Trung', N'873 Lê Hồng Phong, Q5, TpHCM50/34 Lê Đại Hành, Q10, TpHCM', N'TrungPham725@gmail.com', '0944160725'), 
(N'Bùi Văn Hân', N'45/2 An Dương Vương, Q5, TpHCM', N'HanBui@gmail.com', '0956292882'), 
(N'Vũ Chí Linh', N'34 Trương Định, Q3, TpHCM', N'LinhVu@gmail.com', '0968522936'), 
(N'Nguyễn Đình Vinh', N'45 Nguyễn Cảnh Chân, Q1, TpHCM', N'VinhDinhNguyen@gmail.com', '0909068190'), 
(N'Phan Chí Vinh', N'123/78 Lê Văn Chí, Q5, TpHCM547/11 Nguyễn Đình Chiểu, Q5, TpHCM', N'VinhChiPhan@gmail.com', '0970812158'), 
(N'Lê Huy Phi', N'23/5 Nguyễn Trãi, Q5, TpHCM', N'PhiHuyLe@gmail.com', '0942802830'), 
(N'Đặng Chí Hân', N'873 Lê Hồng Phong, Q5, TpHCM50/34 Lê Đại Hành, Q10, TpHCM', N'HanDang945@gmail.com', '0932821945'), 
(N'Bùi Thị Vinh', N'227 Nguyễn Văn Cừ, Q5, TpHCM', N'VinhBui@gmail.com', '0937563200'), 
(N'Phan Ngọc Khải', N'45/2 An Dương Vương, Q5, TpHCM', N'KhaiPhan@gmail.com', '0949166220'), 
(N'Vũ Ngọc Trúc', N'43/12 Nguyễn Văn Tăng, Thủ Đức, Q9, TpHCM', N'TrucNgocVu@gmail.com', '0984178095'), 
(N'Vũ Hoài Linh', N'251/11 Điện Biên Phủ, Q1, TpHCM', N'LinhHoaiVu@gmail.com', '0925411020'), 
(N'Bùi Huy Thanh', N'20 Đặng Văn Bi, Linh Chiểu, Thủ Đức, Q9, TpHCM72/13 Nguyễn Đình Chiểu, Q1, TpHCM', N'ThanhBui965@gmail.com', '0917140965'), 
(N'Đặng Huy Long', N'34/34B Nguyễn Trãi, Q1, TpHCM', N'LongDang@gmail.com', '0948816835'), 
(N'Trần Chí Tuấn', N'123 Võ Văn Ngân, Thủ Đức, Q9, TpHCM', N'TuanTran@gmail.com', '0974837862'), 
(N'Bùi Tuấn Linh', N'34/34B Nguyễn Trãi, Q1, TpHCM', N'LinhBui@gmail.com', '0969529291'), 
(N'Bùi Chí Vinh', N'34/34B Nguyễn Trãi, Q1, TpHCM', N'VinhBui@gmail.com', '0945136760'), 
(N'Vũ Ngọc Minh', N'20 Đặng Văn Bi, Linh Chiểu, Thủ Đức, Q9, TpHCM72/13 Nguyễn Đình Chiểu, Q1, TpHCM', N'MinhVu@gmail.com', '0986806829'), 
(N'Trần Ngọc Linh', N'34 Trương Định, Q3, TpHCM', N'LinhTran@gmail.com', '0951598132'), 
(N'Vũ Ngọc Tâm', N'43/12 Nguyễn Văn Tăng, Thủ Đức, Q9, TpHCM', N'TamVu115@gmail.com', '0920300115'), 
(N'Đặng Nhật Thanh', N'123/78 Lê Văn Chí, Q5, TpHCM547/11 Nguyễn Đình Chiểu, Q5, TpHCM', N'ThanhNhatDang@gmail.com', '0960822473'), 
(N'Phan Tuấn Phi', N'34/34B Nguyễn Trãi, Q1, TpHCM', N'PhiPhan870@gmail.com', '0931427870'), 
(N'Nguyễn Tuấn Phi', N'34/34B Nguyễn Trãi, Q1, TpHCM', N'PhiNguyen085@gmail.com', '0960500085'), 
(N'Đỗ Ngọc Trúc', N'873 Lê Hồng Phong, Q5, TpHCM50/34 Lê Đại Hành, Q10, TpHCM', N'TrucDo173@gmail.com', '0937872173'), 
(N'Lê Đình Tâm', N'731 Trần Hưng Đạo, Q5, TpHCM', N'TamLe@gmail.com', '0974232861'), 
(N'Trần Đình Hân', N'45 Nguyễn Cảnh Chân, Q1, TpHCM', N'HanTran810@gmail.com', '0972973810'), 
(N'Nguyễn Nhật Vinh', N'32/3 Trần Bình Trọng, Q5, TpHCM', N'VinhNguyen718@gmail.com', '0964345718'), 
(N'Lê Tuấn Linh', N'123/10 Lê Văn Việt, Q2, TpHCM', N'LinhTuanLe@gmail.com', '0910066255'), 
(N'Đỗ Duy Long', N'873 Lê Hồng Phong, Q5, TpHCM50/34 Lê Đại Hành, Q10, TpHCM', N'LongDuyDo@gmail.com', '0963166145'), 
(N'Phạm Văn Tâm', N'731 Trần Hưng Đạo, Q5, TpHCM', N'TamVanPham@gmail.com', '0918816216'), 
(N'Trần Hoài Long', N'251/11 Điện Biên Phủ, Q1, TpHCM', N'LongTran828@gmail.com', '0980913828'), 
(N'Phan Đình Trung', N'260/18 Nguyễn Duy Trinh, Q2, TpHCM', N'TrungDinhPhan@gmail.com', '0903226914'), 
(N'Vũ Minh Trung', N'260/18 Nguyễn Duy Trinh, Q2, TpHCM', N'TrungMinhVu@gmail.com', '0955667822')
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
('59H1-869.60', '1', '3', '01/01/2023', '0'),
('59X1-200.70', '2', '4', '01/01/2023', '0'),
('59X1-312.49', '3', '7', '02/01/2023', '0'),
('59B1-398.68', '4', '4', '03/01/2023', '0'),
('59X1-871.98', '5', '2', '03/01/2023', '0'),
('59T1-747.11', '6', '2', '04/02/2023', '0'),
('59H1-021.17', '7', '9', '05/02/2023', '0'),
('59T1-925.22', '8', '10', '05/02/2023', '0'),
('59T1-181.56', '9', '1', '06/02/2023', '0'),
('59H1-808.68', '10', '3', '07/02/2023', '0'),
('59H1-313.13', '11', '9', '08/03/2023', '0'),
('59T1-768.98', '12', '7', '08/03/2023', '0'),
('59T1-043.21', '13', '1', '08/03/2023', '0'),
('59T1-287.14', '14', '9', '09/03/2023', '0'),
('59B1-060.98', '15', '2', '10/04/2023', '0'),
('59X1-179.11', '16', '8', '11/04/2023', '0'),
('59T1-201.46', '17', '5', '11/04/2023', '0'),
('59X1-460.36', '18', '2', '12/05/2023', '0'),
('59U1-458.36', '19', '4', '12/05/2023', '0'),
('59H1-449.19', '20', '2', '13/05/2023', '0'),
('59F1-632.59', '21', '9', '13/05/2023', '0'),
('59T1-155.92', '22', '2', '14/06/2023', '0'),
('59H1-528.56', '23', '8', '15/06/2023', '0'),
('59H1-288.99', '24', '7', '16/06/2023', '0'),
('59U1-351.31', '25', '5', '16/06/2023', '0'),
('59H1-654.79', '26', '6', '17/07/2023', '0'),
('59H1-172.61', '27', '2', '17/07/2023', '0'),
('59X1-087.64', '28', '1', '17/07/2023', '0'),
('59T1-934.90', '29', '6', '18/07/2023', '0'),
('59T1-366.79', '30', '6', '19/08/2023', '0'),
('59T1-557.75', '31', '1', '19/08/2023', '0'),
('59X1-139.73', '32', '1', '20/08/2023', '0'),
('59T1-402.21', '33', '3', '21/08/2023', '0'),
('59T1-948.19', '34', '4', '22/09/2023', '0'),
('59T1-896.95', '35', '2', '22/09/2023', '0'),
('59F1-519.77', '36', '4', '23/09/2023', '0'),
('59X1-810.52', '37', '4', '23/09/2023', '0'),
('59H1-902.81', '38', '9', '24/10/2023', '0'),
('59T1-204.30', '39', '5', '25/10/2023', '0'),
('59T1-627.14', '40', '10', '26/10/2023', '0'),
('59U1-016.30', '41', '3', '26/10/2023', '0'),
('59H1-594.85', '42', '2', '25/11/2023', '0'),
('59T1-142.36', '43', '10', '25/11/2023', '0'),
('59H1-927.12', '44', '6', '26/11/2023', '0'),
('59B1-500.37', '45', '5', '27/11/2023', '0'),
('59U1-663.17', '46', '8', '28/11/2023', '0'),
('59H1-239.77', '47', '4', '29/12/2023', '0'),
('59T1-293.64', '48', '3', '30/12/2023', '0'),
('59B1-548.00', '49', '1', '30/12/2023', '0'),
('59B1-342.30', '50', '6', '31/12/2023', '0')

SELECT * FROM XE
---LOAD DỮ LIỆU VÀ SẮP XẾP THEO MaKhachHang
SELECT *
FROM XE
ORDER BY MaKhachHang

INSERT INTO PHIEUSUACHUA(BienSo, NgaySuaChua, TongTien)
VALUES
('59H1-869.60', '01/01/2023', '12240000'), 
('59X1-200.70', '01/01/2023', '14130000'), 
('59X1-312.49', '02/01/2023', '11690000'), 
('59B1-398.68', '03/01/2023', '8310000'), 
('59X1-871.98', '03/01/2023', '15470000'), 
('59T1-747.11', '04/02/2023', '16020000'), 
('59H1-021.17', '05/02/2023', '37944000'), 
('59T1-925.22', '05/02/2023', '3208600'), 
('59T1-181.56', '06/02/2023', '13563000'), 
('59H1-808.68', '07/02/2023', '38550000'), 
('59H1-313.13', '08/03/2023', '21060000'), 
('59T1-768.98', '08/03/2023', '33526380'), 
('59T1-043.21', '08/03/2023', '82400000'), 
('59T1-287.14', '09/03/2023', '15670000'), 
('59B1-060.98', '10/04/2023', '7406000'), 
('59X1-179.11', '11/04/2023', '15620000'), 
('59T1-201.46', '11/04/2023', '5642000'), 
('59X1-460.36', '12/05/2023', '30144600'), 
('59U1-458.36', '12/05/2023', '38889000'), 
('59H1-449.19', '13/05/2023', '29100000'), 
('59F1-632.59', '13/05/2023', '51150000'), 
('59T1-155.92', '14/06/2023', '25712600'), 
('59H1-528.56', '15/06/2023', '69850000'), 
('59H1-288.99', '16/06/2023', '46260000'), 
('59U1-351.31', '16/06/2023', '21668000'), 
('59H1-654.79', '17/07/2023', '23180000'), 
('59H1-172.61', '17/07/2023', '27360000'), 
('59X1-087.64', '17/07/2023', '35061800'), 
('59T1-934.90', '18/07/2023', '10480400'), 
('59T1-366.79', '19/08/2023', '41500000'), 
('59T1-557.75', '19/08/2023', '30990000'), 
('59X1-139.73', '20/08/2023', '38168900'), 
('59T1-402.21', '21/08/2023', '19250000'), 
('59T1-948.19', '22/09/2023', '19250000'), 
('59T1-896.95', '22/09/2023', '21668000'), 
('59F1-519.77', '23/09/2023', '18140000'), 
('59X1-810.52', '23/09/2023', '13780000'), 
('59H1-902.81', '24/10/2023', '24477400'), 
('59T1-204.30', '25/10/2023', '13563000'), 
('59T1-627.14', '26/10/2023', '38700000'), 
('59U1-016.30', '26/10/2023', '20660000'), 
('59H1-594.85', '25/11/2023', '20670080'), 
('59T1-142.36', '25/11/2023', '76100000'), 
('59H1-927.12', '26/11/2023', '12090000'), 
('59B1-500.37', '27/11/2023', '46214000'), 
('59U1-663.17', '28/11/2023', '8310000'), 
('59H1-239.77', '29/12/2023', '21918000'), 
('59T1-293.64', '30/12/2023', '21618800'), 
('59B1-548.00', '30/12/2023', '20810800'), 
('59B1-342.30', '31/12/2023', '38550000')

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

INSERT INTO CHITIETPHIEUSUACHUA(MaPhieuSuaChua, MaTienCong, TienCong , TongTienVatTuPhuTung, TongCong)
VALUES
('1', '2', '900000', '11340000', '12240000'), 
('2', '2', '900000', '13230000', '14130000'), 
('3', '5', '350000', '11340000', '11690000'), 
('4', '1', '750000', '7560000', '8310000'), 
('5', '5', '350000', '15120000', '15470000'), 
('6', '2', '900000', '15120000', '16020000'), 
('7', '2', '900000', '37044000', '37944000'), 
('8', '4', '550000', '2658600', '3208600'), 
('9', '2', '900000', '12663000', '13563000'), 
('10', '1', '750000', '37800000', '38550000'), 
('11', '2', '900000', '20160000', '21060000'), 
('12', '1', '750000', '32776380', '33526380'), 
('13', '3', '500000', '81900000', '82400000'), 
('14', '4', '550000', '15120000', '15670000'), 
('15', '5', '350000', '7056000', '7406000'), 
('16', '3', '500000', '15120000', '15620000'), 
('17', '5', '350000', '5292000', '5642000'), 
('18', '2', '900000', '29244600', '30144600'), 
('19', '2', '900000', '37989000', '38889000'), 
('20', '1', '750000', '28350000', '29100000'), 
('21', '1', '750000', '50400000', '51150000'), 
('22', '3', '500000', '25212600', '25712600'), 
('23', '4', '550000', '69300000', '69850000'), 
('24', '2', '900000', '45360000', '46260000'), 
('25', '3', '500000', '21168000', '21668000'), 
('26', '3', '500000', '22680000', '23180000'), 
('27', '2', '900000', '26460000', '27360000'), 
('28', '3', '500000', '34561800', '35061800'), 
('29', '5', '350000', '10130400', '10480400'), 
('30', '4', '550000', '40950000', '41500000'), 
('31', '1', '750000', '30240000', '30990000'), 
('32', '5', '350000', '37818900', '38168900'), 
('33', '5', '350000', '18900000', '19250000'), 
('34', '5', '350000', '18900000', '19250000'), 
('35', '3', '500000', '21168000', '21668000'), 
('36', '3', '500000', '17640000', '18140000'), 
('37', '4', '550000', '13230000', '13780000'), 
('38', '4', '550000', '23927400', '24477400'), 
('39', '2', '900000', '12663000', '13563000'), 
('40', '2', '900000', '37800000', '38700000'), 
('41', '3', '500000', '20160000', '20660000'), 
('42', '3', '500000', '20170080', '20670080'), 
('43', '3', '500000', '75600000', '76100000'), 
('44', '1', '750000', '11340000', '12090000'), 
('45', '5', '350000', '45864000', '46214000'), 
('46', '1', '750000', '7560000', '8310000'), 
('47', '1', '750000', '21168000', '21918000'), 
('48', '5', '350000', '21268800', '21618800'), 
('49', '4', '550000', '20260800', '20810800'), 
('50', '1', '750000', '37800000', '38550000')

---DBCC CHECKIDENT ('CHITIETPHIEUSUACHUA', RESEED, 0);
---DELETE FROM CHITIETPHIEUSUACHUA;
---LOAD DỮ LIỆU
SELECT * FROM CHITIETPHIEUSUACHUA

INSERT INTO VATTUPHUTUNG(TenVatTuPhuTung, DonGiaNhap, DonGiaBan, SoLuongTon)
VALUES
(N'Ắc quy AGM (Absorbent Glass Mat)', '1500000', '1575000', '5'), 
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

INSERT INTO CHITIETSUDUNGVATTUPHUTUNG(MaChiTietPhieuSuaChua, MaVatTuPhuTung, SoLuong, DonGia, ThanhTien)
VALUES
('1', '1', '6', '1890000', '11340000'), 
('2', '2', '7', '1890000', '13230000'), 
('3', '3', '6', '1890000', '11340000'), 
('4', '4', '4', '1890000', '7560000'), 
('5', '5', '8', '1890000', '15120000'), 
('6', '6', '6', '2520000', '15120000'), 
('7', '7', '14', '2646000', '37044000'), 
('8', '8', '1', '2658600', '2658600'), 
('9', '9', '5', '2532600', '12663000'), 
('10', '10', '12', '3150000', '37800000'), 
('11', '11', '4', '5040000', '20160000'), 
('12', '12', '13', '2521260', '32776380'), 
('13', '13', '13', '6300000', '81900000'), 
('14', '14', '4', '3780000', '15120000'), 
('15', '15', '2', '3528000', '7056000'), 
('16', '16', '6', '2520000', '15120000'), 
('17', '17', '2', '2646000', '5292000'), 
('18', '18', '11', '2658600', '29244600'), 
('19', '19', '15', '2532600', '37989000'), 
('20', '20', '9', '3150000', '28350000'), 
('21', '21', '10', '5040000', '50400000'), 
('22', '22', '10', '2521260', '25212600'), 
('23', '23', '11', '6300000', '69300000'), 
('24', '24', '12', '3780000', '45360000'), 
('25', '25', '6', '3528000', '21168000'), 
('26', '26', '9', '2520000', '22680000'), 
('27', '27', '10', '2646000', '26460000'), 
('28', '28', '13', '2658600', '34561800'), 
('29', '29', '4', '2532600', '10130400'), 
('30', '30', '13', '3150000', '40950000'), 
('31', '31', '6', '5040000', '30240000'), 
('32', '32', '15', '2521260', '37818900'), 
('33', '33', '3', '6300000', '18900000'), 
('34', '34', '5', '3780000', '18900000'), 
('35', '35', '6', '3528000', '21168000'), 
('36', '36', '7', '2520000', '17640000'), 
('37', '37', '5', '2646000', '13230000'), 
('38', '38', '9', '2658600', '23927400'), 
('39', '39', '5', '2532600', '12663000'), 
('40', '40', '12', '3150000', '37800000'), 
('41', '41', '4', '5040000', '20160000'), 
('42', '42', '8', '2521260', '20170080'), 
('43', '43', '12', '6300000', '75600000'), 
('44', '44', '3', '3780000', '11340000'), 
('45', '45', '13', '3528000', '45864000'), 
('46', '46', '3', '2520000', '7560000'), 
('47', '47', '8', '2646000', '21168000'), 
('48', '48', '8', '2658600', '21268800'), 
('49', '49', '8', '2532600', '20260800'), 
('50', '50', '12', '3150000', '37800000')

---LOAD DỮ LIỆU
SELECT * FROM CHITIETSUDUNGVATTUPHUTUNG

INSERT INTO PHIEUNHAPVATTUPHUTUNG(NgayNhap, TongTien)
VALUES
('25/09/2022', '9900000'),
('26/09/2022', '9900000'),
('27/09/2022', '10800000'),
('28/09/2022', '9000000'),
('29/09/2022', '7200000'),
('30/09/2022', '16500000'),
('02/10/2022', '25600000'),
('03/10/2022', '11270000'),
('05/10/2022', '10570000'),
('08/10/2022', '32000000'),
('10/10/2022', '35000000'),
('11/10/2022', '19513000'),
('12/10/2022', '63000000'),
('15/10/2022', '20000000'),
('18/10/2022', '18400000'),
('21/10/2022', '18000000'),
('22/10/2022', '12800000'),
('25/10/2022', '20930000'),
('27/10/2022', '24160000'),
('29/10/2022', '18000000'),
('01/11/2022', '42000000'),
('04/11/2022', '21014000'),
('06/11/2022', '72000000'),
('07/11/2022', '37500000'),
('09/11/2022', '25300000'),
('10/11/2022', '16500000'),
('13/11/2022', '16000000'),
('14/11/2022', '25760000'),
('16/11/2022', '15100000'),
('17/11/2022', '28000000'),
('19/11/2022', '24500000'),
('22/11/2022', '22515000'),
('26/11/2022', '36000000'),
('30/11/2022', '20000000'),
('05/12/2022', '27600000'),
('06/12/2022', '19500000'),
('07/12/2022', '14400000'),
('08/12/2022', '19320000'),
('12/12/2022', '12080000'),
('13/12/2022', '30000000'),
('15/12/2022', '24500000'),
('16/12/2022', '12008000'),
('18/12/2022', '58500000'),
('19/12/2022', '22500000'),
('20/12/2022', '32200000'),
('21/12/2022', '10500000'),
('23/12/2022', '14400000'),
('24/12/2022', '12880000'),
('25/12/2022', '16610000'),
('30/12/2022', '30000000')
--DBCC CHECKIDENT ('PHIEUNHAPVATTUPHUTUNG', RESEED, 0);
--DELETE FROM PHIEUNHAPVATTUPHUTUNG
---LOAD DỮ LIỆU
SELECT * FROM PHIEUNHAPVATTUPHUTUNG

INSERT INTO CHITIETPHIEUNHAP(MaPhieuNhap, MaVatTuPhuTung, SoLuongNhap, DonGiaNhap, ThanhTien)
VALUES
('1', '1', '11', '900000', '9900000'), 
('2', '2', '11', '900000', '9900000'), 
('3', '3', '12', '900000', '10800000'), 
('4', '4', '10', '900000', '9000000'), 
('5', '5', '8', '900000', '7200000'), 
('6', '6', '11', '1500000', '16500000'), 
('7', '7', '16', '1600000', '25600000'), 
('8', '8', '7', '1610000', '11270000'), 
('9', '9', '7', '1510000', '10570000'), 
('10', '10', '16', '2000000', '32000000'), 
('11', '11', '10', '3500000', '35000000'), 
('12', '12', '13', '1501000', '19513000'), 
('13', '13', '14', '4500000', '63000000'), 
('14', '14', '8', '2500000', '20000000'), 
('15', '15', '8', '2300000', '18400000'), 
('16', '16', '12', '1500000', '18000000'), 
('17', '17', '8', '1600000', '12800000'), 
('18', '18', '13', '1610000', '20930000'), 
('19', '19', '16', '1510000', '24160000'), 
('20', '20', '9', '2000000', '18000000'), 
('21', '21', '12', '3500000', '42000000'), 
('22', '22', '14', '1501000', '21014000'), 
('23', '23', '16', '4500000', '72000000'), 
('24', '24', '15', '2500000', '37500000'), 
('25', '25', '11', '2300000', '25300000'), 
('26', '26', '11', '1500000', '16500000'), 
('27', '27', '10', '1600000', '16000000'), 
('28', '28', '16', '1610000', '25760000'), 
('29', '29', '10', '1510000', '15100000'), 
('30', '30', '14', '2000000', '28000000'), 
('31', '31', '7', '3500000', '24500000'), 
('32', '32', '15', '1501000', '22515000'), 
('33', '33', '8', '4500000', '36000000'), 
('34', '34', '8', '2500000', '20000000'), 
('35', '35', '12', '2300000', '27600000'), 
('36', '36', '13', '1500000', '19500000'), 
('37', '37', '9', '1600000', '14400000'), 
('38', '38', '12', '1610000', '19320000'), 
('39', '39', '8', '1510000', '12080000'), 
('40', '40', '15', '2000000', '30000000'), 
('41', '41', '7', '3500000', '24500000'), 
('42', '42', '8', '1501000', '12008000'), 
('43', '43', '13', '4500000', '58500000'), 
('44', '44', '9', '2500000', '22500000'), 
('45', '45', '14', '2300000', '32200000'), 
('46', '46', '7', '1500000', '10500000'), 
('47', '47', '9', '1600000', '14400000'), 
('48', '48', '8', '1610000', '12880000'), 
('49', '49', '11', '1510000', '16610000'), 
('50', '50', '15', '2000000', '30000000')

---LOAD DỮ LIỆU
SELECT * FROM CHITIETPHIEUNHAP

--SELECT CT.SoLuongNhap - VT.SoLuongTon AS SoLuongSD
--FROM CHITIETPHIEUNHAP CT, VATTUPHUTUNG VT
--WHERE CT.MaVatTuPhuTung = VT.MaVatTuPhuTung

--SELECT DonGiaBan + 0.2*DonGiaBan
--FROM VATTUPHUTUNG

INSERT INTO BAOCAOTONKHO(MaVatTuPhuTung, Thang, Nam, TonDau, PhatSinh, TonCuoi)
VALUES
('1', '09', '2022', '11', '0', '5'), 
('2', '09', '2022', '11', '0', '4'), 
('3', '09', '2022', '12', '0', '6'), 
('4', '09', '2022', '10', '0', '6'), 
('5', '09', '2022', '8', '0', '0'), 
('6', '09', '2022', '11', '0', '5'), 
('7', '10', '2022', '16', '0', '2'), 
('8', '10', '2022', '7', '0', '6'), 
('9', '10', '2022', '7', '0', '2'), 
('10', '10', '2022', '16', '0', '4'), 
('11', '10', '2022', '10', '0', '6'), 
('12', '10', '2022', '13', '0', '0'), 
('13', '10', '2022', '14', '0', '1'), 
('14', '10', '2022', '8', '0', '4'), 
('15', '10', '2022', '8', '0', '6'), 
('16', '10', '2022', '12', '0', '6'), 
('17', '10', '2022', '8', '0', '6'), 
('18', '10', '2022', '13', '0', '2'), 
('19', '10', '2022', '16', '0', '1'), 
('20', '10', '2022', '9', '0', '0'), 
('21', '11', '2022', '12', '0', '2'), 
('22', '11', '2022', '14', '0', '4'), 
('23', '11', '2022', '16', '0', '5'), 
('24', '11', '2022', '15', '0', '3'), 
('25', '11', '2022', '11', '0', '5'), 
('26', '11', '2022', '11', '0', '2'), 
('27', '11', '2022', '10', '0', '0'), 
('28', '11', '2022', '16', '0', '3'), 
('29', '11', '2022', '10', '0', '6'), 
('30', '11', '2022', '14', '0', '1'), 
('31', '11', '2022', '7', '0', '1'), 
('32', '11', '2022', '15', '0', '0'), 
('33', '11', '2022', '8', '0', '5'), 
('34', '11', '2022', '8', '0', '3'), 
('35', '12', '2022', '12', '0', '6'), 
('36', '12', '2022', '13', '0', '6'), 
('37', '12', '2022', '9', '0', '4'), 
('38', '12', '2022', '12', '0', '3'), 
('39', '12', '2022', '8', '0', '3'), 
('40', '12', '2022', '15', '0', '3'), 
('41', '12', '2022', '7', '0', '3'), 
('42', '12', '2022', '8', '0', '0'), 
('43', '12', '2022', '13', '0', '1'), 
('44', '12', '2022', '9', '0', '6'), 
('45', '12', '2022', '14', '0', '1'), 
('46', '12', '2022', '7', '0', '4'), 
('47', '12', '2022', '9', '0', '1'), 
('48', '12', '2022', '8', '0', '0'), 
('49', '12', '2022', '11', '0', '3'), 
('50', '12', '2022', '15', '0', '3')

---LOAD DỮ LIỆU
SELECT * FROM BAOCAOTONKHO

UPDATE XE
SET TienNo += (SELECT SUM(TongTien)
			   FROM PHIEUSUACHUA PS
			   WHERE XE.BienSo = PS.BienSo)

INSERT INTO PHIEUTHUTIEN(BienSo, NgayThu, SoTienThu)
VALUES
('59H1-869.60', '01/01/2023', '12240000'), 
('59X1-200.70', '01/01/2023', '14130000'), 
('59X1-312.49', '02/01/2023', '11690000'), 
('59B1-398.68', '03/01/2023', '8310000'), 
('59X1-871.98', '03/01/2023', '15470000'), 
('59T1-747.11', '04/02/2023', '16020000'), 
('59H1-021.17', '05/02/2023', '37944000'), 
('59T1-925.22', '05/02/2023', '3208600'), 
('59T1-181.56', '06/02/2023', '13563000'), 
('59H1-808.68', '07/02/2023', '38550000'), 
('59H1-313.13', '08/03/2023', '21060000'), 
('59T1-768.98', '08/03/2023', '33526380'), 
('59T1-043.21', '08/03/2023', '82400000'), 
('59T1-287.14', '09/03/2023', '15670000'), 
('59B1-060.98', '10/04/2023', '7406000'), 
('59X1-179.11', '11/04/2023', '15620000'), 
('59T1-201.46', '11/04/2023', '5642000'), 
('59X1-460.36', '12/05/2023', '30144600'), 
('59U1-458.36', '12/05/2023', '38889000'), 
('59H1-449.19', '13/05/2023', '29100000'), 
('59F1-632.59', '13/05/2023', '51150000'), 
('59T1-155.92', '14/06/2023', '25712600'), 
('59H1-528.56', '15/06/2023', '69850000'), 
('59H1-288.99', '16/06/2023', '46260000'), 
('59U1-351.31', '16/06/2023', '21668000'), 
('59H1-654.79', '17/07/2023', '23180000'), 
('59H1-172.61', '17/07/2023', '27360000'), 
('59X1-087.64', '17/07/2023', '35061800'), 
('59T1-934.90', '18/07/2023', '10480400'), 
('59T1-366.79', '19/08/2023', '41500000'), 
('59T1-557.75', '19/08/2023', '30990000'), 
('59X1-139.73', '20/08/2023', '38168900'), 
('59T1-402.21', '21/08/2023', '19250000'), 
('59T1-948.19', '22/09/2023', '19250000'), 
('59T1-896.95', '22/09/2023', '21668000'), 
('59F1-519.77', '23/09/2023', '18140000'), 
('59X1-810.52', '23/09/2023', '13780000'), 
('59H1-902.81', '24/10/2023', '24477400'), 
('59T1-204.30', '25/10/2023', '13563000'), 
('59T1-627.14', '26/10/2023', '38700000'), 
('59U1-016.30', '26/10/2023', '20660000'), 
('59H1-594.85', '25/11/2023', '20670080'), 
('59T1-142.36', '25/11/2023', '76100000'), 
('59H1-927.12', '26/11/2023', '12090000'), 
('59B1-500.37', '27/11/2023', '46214000'), 
('59U1-663.17', '28/11/2023', '8310000'), 
('59H1-239.77', '29/12/2023', '21918000'), 
('59T1-293.64', '30/12/2023', '21618800'), 
('59B1-548.00', '30/12/2023', '20810800'), 
('59B1-342.30', '31/12/2023', '38550000')

---DBCC CHECKIDENT ('PHIEUTHUTIEN', RESEED, 0);
----DELETE FROM PHIEUTHUTIEN
---LOAD DỮ LIỆU
SELECT * FROM PHIEUTHUTIEN

UPDATE XE
SET TienNo -= (SELECT SUM(TongTien)
			   FROM PHIEUSUACHUA PS
			   WHERE XE.BienSo = PS.BienSo)


INSERT INTO BAOCAODOANHSO(TongDoanhThu, Thang, Nam)
VALUES
('61840000', '01', '2023'), 
('109285600', '02', '2023'), 
('152656380', '03', '2023'), 
('28668000', '04', '2023'), 
('149283600', '05', '2023'), 
('163490600', '06', '2023'), 
('96082200', '07', '2023'), 
('129908900', '08', '2023'), 
('72838000', '09', '2023'), 
('97400400', '10', '2023'), 
('163384080', '11', '2023'), 
('102897600', '12', '2023')
---LOAD DỮ LIỆU
SELECT * FROM BAOCAODOANHSO

INSERT INTO CHITIETBAOCAODOANHSO(MaBaoCaoDoanhSo, MaHieuXe, SoLuotSua, ThanhTien, TiLe)
VALUES
('1', '3', '1', '12240000', '0.20'),
('1', '4', '2', '22440000', '0.36'),
('1', '7', '1', '11690000', '0.19'),
('1', '2', '1', '15470000', '0.25'),
('2', '2', '1', '16020000', '0.15'),
('2', '9', '1', '37944000', '0.35'),
('2', '10', '1', '3208600', '0.03'),
('2', '1', '1', '13563000', '0.12'),
('2', '3', '1', '38550000', '0.35'),
('3', '1', '1', '82400000', '0.54'),
('3', '9', '2', '36730000', '0.24'),
('3', '7', '1', '33526380', '0.22'),
('4', '2', '1', '7406000', '0.26'),
('4', '5', '1', '5642000', '0.20'),
('4', '8', '1', '15620000', '0.54'),
('5', '4', '1', '38889000', '0.26'),
('5', '2', '2', '59244600', '0.40'),
('5', '9', '1', '51150000', '0.34'),
('6', '2', '1', '25712600', '0.16'),
('6', '8', '1', '69850000', '0.43'),
('6', '7', '1', '46260000', '0.28'),
('6', '5', '1', '21668000', '0.13'),
('7', '1', '1', '35061800', '0.36'),
('7', '6', '2', '33660400', '0.35'),
('7', '2', '1', '27360000', '0.28'),
('8', '6', '1', '41500000', '0.32'),
('8', '1', '2', '69158900', '0.53'),
('8', '3', '1', '19250000', '0.15'),
('9', '4', '3', '51170000', '0.30'),
('9', '2', '1', '21668000', '0.70'),
('10', '9', '1', '24477400', '0.25'),
('10', '5', '1', '13563000', '0.14'),
('10', '3', '1', '20660000', '0.21'),
('10', '10', '1', '38700000', '0.40'),
('11', '10', '1', '76100000', '0.47'),
('11', '2', '1', '20670080', '0.13'),
('11', '6', '1', '12090000', '0.07'),
('11', '5', '1', '46214000', '0.28'),
('11', '8', '1', '8310000', '0.05'),
('12', '4', '1', '21918000', '0.21'),
('12', '1', '1', '20810800', '0.20'),
('12', '3', '1', '21618800', '0.21'),
('12', '6', '1', '38550000', '0.38')
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
