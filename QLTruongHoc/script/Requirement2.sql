----------------------------------------------------------------------------------
---- YÊU CẦU 2: CÁC ĐẶT CÁC CHÍNH SÁCH OLS CHO BẢNG THÔNG BÁO
----------------------------------------------------------------------------------
--
----------------------------------------------------------------------------------
---- BƯỚC 1: TẠO CHÍNH SÁCH OLS 
----------------------------------------------------------------------------------
--EXECUTE SA_SYSDBA.DROP_POLICY('notification_olspolicy');
--/
--
--BEGIN 
--     SA_SYSDBA.CREATE_POLICY( 
--     policy_name => 'notification_olspolicy', 
--     column_name => 'notification_label'
--); 
--END; 
--/
-----------------------------------------------------
---- ENABLE POLICY VỪA TẠO -> KHỞI ĐỘNG LẠI SQLDEV --
-----------------------------------------------------
--EXEC SA_SYSDBA.ENABLE_POLICY ('notification_olspolicy'); 
--/
--------------------------------------------------------------------------------
-- BƯỚC 2: ĐỊNH NGHĨA CÁC THÀNH PHẦN CỦA LABEL
--------------------------------------------------------------------------------
EXECUTE SA_COMPONENTS.CREATE_LEVEL('notification_olspolicy', 350, 'TK', 'TRUONG KHOA');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('notification_olspolicy', 300, 'TDV', 'TRUONG DON VI');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('notification_olspolicy', 250, 'GVIEN', 'GIANG VIEN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('notification_olspolicy', 200, 'GVU', 'GIAO VU');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('notification_olspolicy', 150, 'NV', 'NHAN VIEN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('notification_olspolicy', 100, 'SV', 'SINH VIEN');
--SELECT * FROM DBA_SA_LEVELS; 

EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('notification_olspolicy', 60, 'HTTT', 'HE THONG THONG TIN');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('notification_olspolicy', 50, 'CNPM', 'CONG NGHE PHAN MEM');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('notification_olspolicy', 40, 'KHMT', 'KHOA HOC MAY TINH');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('notification_olspolicy', 30, 'CNTT', 'CONG NGHE THONG TIN');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('notification_olspolicy', 20, 'TGMT', 'THI GIAC MAY TINH');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('notification_olspolicy', 10, 'MMT', 'MANG MAY TINH VA VIEN THONG');
--SELECT * FROM DBA_SA_COMPARTMENTS;

EXECUTE SA_COMPONENTS.CREATE_GROUP('notification_olspolicy', 400, 'CS1', 'CO SO 1');
EXECUTE SA_COMPONENTS.CREATE_GROUP('notification_olspolicy', 500, 'CS2', 'CO SO 2');
--SELECT * FROM DBA_SA_COMPARTMENTS;

--------------------------------------------------------------------------------
-- BƯỚC 3: TẠO CÁC LABEL OLS (DATA LABEL)
--------------------------------------------------------------------------------

-- TẠO DATA LABEL
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 990, label_value => 'TK', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 980, label_value => 'TDV', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 970, label_value => 'TDV::CS1', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 960, label_value => 'GVU:HTTT', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 950, label_value => 'GVU', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 940, label_value => 'TDV:HTTT', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 930, label_value => 'SV:HTTT:CS1', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 920, label_value => 'TDV:KHMT:CS1', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 910, label_value => 'SV', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 900, label_value => 'TDV:KHMT', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 890, label_value => 'GVIEN:HTTT', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 880, label_value => 'NV::CS2', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 870, label_value => 'GVIEN', data_label => true); END;
/
BEGIN SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'notification_olspolicy', label_tag => 860, label_value => 'GVIEN:CNPM:CS1', data_label => true); END;
/
--------------------------------------------------------------------------------
-- BƯỚC 4: GÁN CHÍNH SÁCH OLS CHO TABLE (SCHEMA) MUỐN BẢO VỆ (VỚI OPTION LÀ NO_CONTROL)
--------------------------------------------------------------------------------
BEGIN 
     SA_POLICY_ADMIN.APPLY_TABLE_POLICY ( 
     POLICY_NAME => 'notification_olspolicy',
     SCHEMA_NAME => 'QLTH', 
     TABLE_NAME => 'QLTH_THONGBAO',
     TABLE_OPTIONS => 'NO_CONTROL'
     ); 
END;
/

-- UPDATE DATALABEL CHO BẢNG QLTH_THONGBAO
UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'TK') WHERE MATB = 1001;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'TDV') WHERE MATB = 1002;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'TDV::CS1') WHERE MATB = 1003;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'GVU:HTTT') WHERE MATB = 1004;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'GVU') WHERE MATB = 1005;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'TDV:HTTT') WHERE MATB = 1006;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'SV:HTTT:CS1') WHERE MATB = 1007;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'TDV:KHMT:CS1') WHERE MATB = 1008;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'SV') WHERE MATB = 1009;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'TDV:KHMT') WHERE MATB = 1010;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'GVIEN:HTTT') WHERE MATB = 1011;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'NV::CS2') WHERE MATB = 1012;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'GVIEN') WHERE MATB = 1013;

UPDATE QLTH.QLTH_THONGBAO
SET notification_label = CHAR_TO_LABEL('notification_olspolicy', 'GVIEN:CNPM:CS1') WHERE MATB = 1014;
-- SELECT * FROM QLTH.QLTH_THONGBAO;

--------------------------------------------------------------------------------
-- BƯỚC 5: GÁN CÁC NHÃN CHO USER
--------------------------------------------------------------------------------
-- Gán quyền xem thông báo cho các user
GRANT SELECT ON QLTH.QLTH_THONGBAO TO RL_QLTH_TRUONGKHOA;
GRANT SELECT ON QLTH.QLTH_THONGBAO TO RL_QLTH_TRUONGDV;
GRANT SELECT ON QLTH.QLTH_THONGBAO TO RL_QLTH_GIAOVU;
GRANT SELECT ON QLTH.QLTH_THONGBAO TO RL_QLTH_GIANGVIEN;
GRANT SELECT ON QLTH.QLTH_THONGBAO TO RL_QLTH_NHANVIEN;
GRANT SELECT ON QLTH.QLTH_THONGBAO TO RL_QLTH_SINHVIEN;
-- Gán nhãn cho trưởng khoa có thể đọc được toàn bộ thông báo
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"500000"',
        max_read_label => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
    );
END;
/
-- Gán nhãn cho trưởng đơn vị phụ trách cơ sở 2 có thể đọc được toàn bộ thông báo (giả sử gán cho trưởng đơn vị CNPM)
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"400002"',
        max_read_label => 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
    );
END;
/

-- Gán nhãn cho giáo vụ có thể đọc được tất cả thông báo dành cho giáo vụ   
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"300006"',
        max_read_label => 'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
    );
END;
/
-- Gán nhãn cho trưởng đơn vị hệ thống thông tin    
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"400001"',
        max_read_label => 'TDV:HTTT:CS1,CS2'
    );
END;
/
-- Gán nhãn cho trưởng đơn vị khoa học máy tính 
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"400003"',
        max_read_label => 'TDV:KHMT:CS1,CS2'
    );
END;
/

-- Gán nhãn cho giáo vụ ngành hệ thống thông tin
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"300000"',
        max_read_label => 'GVU:HTTT:CS1,CS2'
    );
END;
/

-- Gán nhãn cho sinh viên ngành hệ thống thông tin
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"21120347"',
        max_read_label => 'SV:HTTT:CS1,CS2'
    );
END;
/

-- Gán nhãn cho giảng viên ngành hệ thống thông tin
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
        policy_name => 'notification_olspolicy',
        user_name => '"200000"',
        max_read_label => 'GVIEN:HTTT:CS1,CS2'
    );
END;
/

--------------------------------------------------------------------------------
-- BƯỚC 6:GÁN LẠI CHÍNH SÁCH OLS VÀO BẢNG (VỚI OPTION LÀ READ_CONTROL, WRITE_CONTROL, CHECK_CONTROL)
--------------------------------------------------------------------------------
BEGIN
--  SA_SYSDBA.ALTER_POLICY(policy_name => 'OLS_QLTH', default_options => 'read_control, label_default');
    SA_POLICY_ADMIN.REMOVE_TABLE_POLICY( policy_name => 'notification_olspolicy', schema_name => 'QLTH', table_name => 'QLTH_THONGBAO', drop_column => FALSE);
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY( policy_name => 'notification_olspolicy', schema_name => 'QLTH', table_name => 'QLTH_THONGBAO', table_options => 'READ_CONTROL, WRITE_CONTROL, CHECK_CONTROL');
END;
/