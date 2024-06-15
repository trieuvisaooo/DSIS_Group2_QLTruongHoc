select * from qlth.qlth_phancong;

delete from qlth.qlth_phancong
where mahp = 'CSC12001'
and hk = 1
and nam = '2023-2024'
and mact = 'CQ'
and ngayhoc = 'T2'
and tiet = '1-4';

rollback;

select * from qlth.qlth_nhansu;

select kh.mahp, hp.tenhp, kh.hk, kh.nam, kh.mact
from qlth.qlth_khmo kh 
join qlth.qlth_hocphan hp on kh.mahp = hp.mahp
where hp.madv = 'HTTT';

select madv
from qlth.qlth_nhansu
where mans = SYS_CONTEXT('USERENV', 'SESSION_USER');

select mans, hoten
from qlth.qlth_nhansu
where madv = 'HTTT';

select * from qlth.UV_QLTH_NHANSU;

