select * from qlth.qlth_sinhvien;

update qlth.qlth_sinhvien
set hoten = N'Tr?n Ý V?n', phai = N'Nam', ngsinh = '2003-07-05', diachi = '', dt = '', mact = 'CQ'
where masv = 21120360;

commit;

INSERT INTO QLTH.QLTH_SINHVIEN(MASV, HOTEN, PHAI, NGSINH, DIACHI, DT, MACT)
VALUES(19120337, N'Tr??ng V?n Tú', N'Nam', '09-AUG-2001', N'12A Nguy?n Thái H?c', '0789110420', 'CQ');

select * from qlth.qlth_sinhvien where masv = 21120360;
ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD'