select pc.mahp, hp.tenhp, pc.hk, pc.nam, pc.ngayhoc, pc.tiet, pc.magv
from qlth.qlth_phancong pc join qlth.qlth_hocphan hp on pc.mahp = hp.mahp
where pc.mact in (select mact from qlth.qlth_chuongtrinh where tenct = 'Chính quy - Ch??ng trình chu?n')
and pc.mahp = 'CSC10001' 
and pc.hk = 3
and pc.nam = '2023-2024'
and pc.ngayhoc = 'T7'
and pc.tiet = '1-4';

SELECT * FROM QLTH.QLTH_PHANCONG;

update qlth.qlth_phancong pc
set pc.magv = 200001
where pc.mact = 'CQ'
and pc.mahp = 'CSC10001' 
and pc.hk = 3
and pc.nam = '2023-2024'
and pc.ngayhoc = 'T7'
and pc.tiet = '1-4';

select * from qlth.qlth_dangky;

select * from "QLTH"."UV_QLTH_XEMPHANCONGGIANGDAY";
