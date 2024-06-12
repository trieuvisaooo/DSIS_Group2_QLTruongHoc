select dk.mahp, hp.tenhp,dk.hk, dk.nam, dk.mact, dk.ngayhoc, dk.tiet,sv.masv, sv.hoten, dk.diemthi, dk.diemqt, dk.diemck, dk.diemtk
from qlth.qlth_dangky dk join qlth.qlth_sinhvien sv on dk.masv = sv.masv
join qlth.qlth_hocphan hp on dk.mahp = hp.mahp;

SELECT * FROM QLTH.UV_QLTH_DONVI_FORM;

SELECT * FROM QLTH.QLTH_DONVI;


select PC.MAGV, PC.MAHP, HP.TENHP, PC.HK, PC.NAM, CT.TENCT, PC.NGAYHOC, PC.TIET 
from qlth.uv_qlth_xemphanconggiangday PC JOIN QLTH.qlth_hocphan HP ON PC.MAHP = HP.MAHP
JOIN QLTH.QLTH_CHUONGTRINH CT ON CT.MACT = PC.MACT
where hp.tenhp = 'An toàn và b?o m?t d? li?u trong h? th?ng thông tin'
and pc.hk = 1
and pc.nam = '2023-2024'
and ct.tenct = 'Chính quy - Ch??ng trình chu?n'
and pc.ngayhoc = 'T2'
and pc.tiet = '1-4';

select dk.mahp, hp.tenhp,dk.hk, dk.nam, dk.mact, dk.ngayhoc, dk.tiet,sv.masv, sv.hoten, dk.diemthi, dk.diemqt, dk.diemck, dk.diemtk
from qlth.qlth_dangky dk join qlth.qlth_sinhvien sv on dk.masv = sv.masv 
join qlth.qlth_hocphan hp on dk.mahp = hp.mahp
join qlth.qlth_chuongtrinh ct on dk.mact = ct.mact
where hp.tenhp = 'An toàn và b?o m?t d? li?u trong h? th?ng thông tin'
and dk.hk = 1
and dk.nam = '2023-2024'
and ct.tenct = 'Chính quy - Ch??ng trình chu?n'
and dk.ngayhoc = 'T2'
and dk.tiet = '1-4';