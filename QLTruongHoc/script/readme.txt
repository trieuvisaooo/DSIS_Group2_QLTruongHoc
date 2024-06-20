===============================
==QUY TRÌNH CHẠY CÁC FILE SQL==
===============================
(*) Lưu ý: Nếu đã cài QLTH trước đó thì phải xóa hết các connection liên quan.
1. CONNECTION: XE_DBA	sys@//localhost:1521/xe (ROLE:SYSDBA)
RUN QLTH_Schema => RUN Function_StoreProcedure_Trigger => QLTH_User
2. CONNECTION: XEPDB1_QLTH	QLTH@//localhost:1521/xepdb1 (ROLE: Default)
RUN Requirement1 => DISCONNECT => CONNECT AGAIN => RUN Requirement2 => RUN Requirement3
3. CONNECTION: XE_DBA	sys@//localhost:1521/xe (ROLE:SYSDBA)
RUN Requirement4

==============================
==  NỘI DUNG CÁC FILE SQL   ==
==============================

Function_StoreProcedure_Trigger: 
- Chứa các Function, Store Procedure, Trigger được sử dụng

QLTH_Schema:
- Enable ols, enable audit
- Khởi tạo User QLTH và cấp các quyền cần thiết cho QLTH
- Tạo CSDL (bao gồm cả việc insert data) trên QLTH
- Tạo các Role cần thiết cho CSDL

QLTH_User:
- Tạo các User của CSDL QLTH
- Cấp các role tương ứng với vai trò của user trong CSDL 

Requirement1: 
- Các chính sách truy cập cho yêu cầu 1 của phân hệ 2
- Phần tạo trước chính sách OLS cho THONGBAO

Requirement2:
- Cài đặt chính sách OLS của yêu cầu 2 của phân hệ 2

Requirement3:
- Cài đặt các chính sách Audit và các câu truy vấn để xem thông tin audit

Requirement4: 
- Enable Flashback Log để phục việc recovery bảng theo thời điểm trong quá khứ dựa vào audit