-- nhân viên cơ bản uname = 100000
select * from qlth.qlth_nhansu;
update qlth.qlth_nhansu set dt = '0123456789';
select * from qlth.qlth_sinhvien;
select * from qlth.qlth_donvi;
select * from qlth.qlth_hocphan;
select * from qlth.qlth_khmo;
select * from qlth.qlth_chuongtrinh;
-- giảng viên uname = 200000
select * from qlth.uv_qlth_xemphanconggiangday;
select * from qlth.qlth_dangky;
update qlth.qlth_dangky set diemthi = 8 where masv = 21120347;
-- giáo vụ uname = 300000
select * from qlth.qlth_phancong;
-- SELECT MADV FROM QLTH.QLTH_NHANSU WHERE TO_CHAR(MANS) = SYS_CONTEXT('USERENV', 'SESSION_USER') AND VAITRO = N'Trưởng đơn vị';
-- SELECT COUNT(*) FROM QLTH.QLTH_NHANSU WHERE MANS = TO_NUMBER(SYS_CONTEXT('USERENV', 'SESSION_USER')) AND VAITRO = N'Giáo vụ';
update qlth.qlth_phancong set ngayhoc = 'T6', tiet = '6-9';
select * from qlth.qlth_dangky;
INSERT INTO QLTH.QLTH_DANGKY(MASV, MAHP, HK, NAM, MACT, NGAYHOC, TIET) VALUES(21120347, 'CSC12001', 1, '2023-2024', 'CQ', 'T2', '1-4');
DELETE FROM QLTH.QLTH_DANGKY WHERE (MAHP = 'CSC12001' AND HK = 1 AND NAM = '2023-2024' AND MACT = 'CQ' AND NGAYHOC = 'T2' AND TIET = '1-4');
-- trưởng đơn vị uname = 400001
select * from qlth.qlth_phancong;
update qlth.qlth_phancong set ngayhoc = 'T4', tiet = '2-5' where magv = 200001;
update qlth.qlth_phancong set ngayhoc = 'T4', tiet = '2-5' where magv = 200012;
-- trưởng khoa uname = 500000
-- SELECT COUNT(*) FROM QLTH.UV_QLTH_XEMTHONGTINCANHAN_NS WHERE TO_CHAR(MANS) = UserName AND (VAITRO = N'Giảng viên' OR VAITRO = N'Trưởng đơn vị' OR VAITRO = N'Trưởng khoa');
select * from qlth.qlth_phancong;
update qlth.qlth_phancong set ngayhoc = 'T6', tiet = '6-9';
select * from qlth.qlth_nhansu;
select * from qlth.qlth_chuongtrinh;
select * from qlth.qlth_coso;
select * from qlth.qlth_nganh;
select * from qlth.qlth_thoigiandk;
select * from qlth.qlth_sinhvien;
-- sinh viên uname = 21120347
select * from qlth.qlth_sinhvien;
update qlth.qlth_sinhvien set diachi = N'TP.Hồ Chí Minh', DT = '0123456789';
select * from qlth.qlth_hocphan;
-- SELECT SV.MACT FROM QLTH.QLTH_SINHVIEN SV WHERE SV.MASV = TO_NUMBER(SYS_CONTEXT('USERENV', 'SESSION_USER'));
select * from qlth.uv_qlth_kehoachmohp;
-- select * from qlth.qlth_thoigiandk;
select * from qlth.qlth_dangky;
INSERT INTO QLTH.QLTH_DANGKY(MASV, MAHP, HK, NAM, MACT, NGAYHOC, TIET) VALUES(21120347, 'CSC12001', 1, '2023-2024', 'CQ', 'T2', '1-4');
INSERT INTO QLTH.QLTH_DANGKY(MASV, MAHP, HK, NAM, MACT, NGAYHOC, TIET) VALUES(21120347, 'CSC12001', 3, '2023-2024', 'CQ', 'T5', '6-9');
DELETE FROM QLTH.QLTH_DANGKY WHERE MAHP = 'CSC12001' AND HK = 1 AND NAM = '2023-2024' AND MACT = 'CQ' AND NGAYHOC = 'T2' AND TIET = '1-4';
select * from qlth.qlth_thongbao;
