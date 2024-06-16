-- Câu 1: Enable Audit
-- Câu 2: Standard Audit
-- Cài đặt chính sách audit để theo dõi dba
CREATE AUDIT POLICY DBA_ON_QLTH_AUDIT_POL
ROLES DBA
CONTAINER = CURRENT;
AUDIT POLICY DBA_ON_QLTH_AUDIT_POL ;
--NOAUDIT POLICY DBA_ON_QLTH_AUDIT_POL;
--DROP AUDIT POLICY DBA_ON_QLTH_AUDIT_POL;

-- Cài đặt chính sách audit để theo dõi các hành động trên bảng DANGKY
CREATE AUDIT POLICY ACTIONS_ON_DANGKY_AUDIT_POL
ACTIONS DELETE, INSERT, UPDATE ON QLTH.QLTH_DANGKY;
AUDIT POLICY ACTIONS_ON_DANGKY_AUDIT_POL;
--NOAUDIT POLICY ACTIONS_ON_DANGKY_AUDIT_POL;
--DROP AUDIT POLICY ACTIONS_ON_DANGKY_AUDIT_POL;

-- Cài đặt chính sách audit để theo dõi các hành động trên bảng NHANSU
CREATE AUDIT POLICY ACTIONS_ON_NHANSU_AUDIT_POL
ACTIONS DELETE, INSERT, UPDATE ON QLTH.QLTH_DANGKY;
AUDIT POLICY ACTIONS_ON_NHANSU_AUDIT_POL;
--NOAUDIT POLICY ACTIONS_ON_NHANSU_AUDIT_POL;
--DROP AUDIT POLICY ACTIONS_ON_NHANSU_AUDIT_POL;

/*
SELECT DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, OBJECT_TYPE, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE
FROM UNIFIED_AUDIT_TRAIL
WHERE UNIFIED_AUDIT_POLICIES LIKE '%DBA_ON_QLTH_AUDIT_POL%'
ORDER BY EVENT_TIMESTAMP DESC;
*/

/*
SELECT DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, OBJECT_TYPE, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE
FROM UNIFIED_AUDIT_TRAIL
WHERE UNIFIED_AUDIT_POLICIES LIKE '%ACTIONS_ON_DANGKY_AUDIT_POL%'
ORDER BY EVENT_TIMESTAMP DESC;
*/

/*
SELECT DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, OBJECT_TYPE, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE
FROM UNIFIED_AUDIT_TRAIL
WHERE UNIFIED_AUDIT_POLICIES LIKE '%ACTIONS_ON_NHANSU_AUDIT_POL%'
ORDER BY EVENT_TIMESTAMP DESC;
*/

/*
SELECT DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, OBJECT_TYPE, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE
FROM UNIFIED_AUDIT_TRAIL
WHERE UNIFIED_AUDIT_POLICIES LIKE '%DBA_ON_QLTH_AUDIT_POL%' OR UNIFIED_AUDIT_POLICIES LIKE '%ACTIONS_ON_DANGKY_AUDIT_POL%' OR UNIFIED_AUDIT_POLICIES LIKE '%ACTIONS_ON_NHANSU_AUDIT_POL%'
ORDER BY EVENT_TIMESTAMP DESC;
*/

-- Câu 3: Fine-Grained Audit
-- a. Chính sách bật audit khi có hành vi Cập nhật quan hệ DANGKY tại các trường liên quan đến điểm số
-- nhưng người đó không thuộc vai trò Giảng viên.
CREATE OR REPLACE FUNCTION QLTH.LAGIANGVIEN(USERNAME IN VARCHAR2) RETURN PLS_INTEGER
AS
    CNT_GV NUMBER;
BEGIN
    IF USERNAME = 'QLTH' THEN
        return 0;
    END IF;
    
    SELECT COUNT(*) INTO CNT_GV FROM DBA_ROLE_PRIVS WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER') AND GRANTED_ROLE = 'RL_QLTH_GIANGVIEN';
    
    IF CNT_GV > 0 THEN
        RETURN 1;
    END IF;
    
    RETURN 0;
EXCEPTION
    WHEN OTHERS THEN
        RETURN 0;
END;
/

/*
BEGIN
  DBMS_FGA.DROP_POLICY(
    object_schema    => 'QLTH',
    object_name      => 'QLTH_DANGKY',
    policy_name      => 'UPDATE_DANGKY_DIEM');
END;
/
*/

BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema    => 'QLTH',
    object_name      => 'QLTH_DANGKY',
    policy_name      => 'UPDATE_DANGKY_DIEM',
    audit_column     => 'DIEMTHI,DIEMQT,DIEMCK,DIEMTK',
    audit_condition  => 'QLTH.LAGIANGVIEN(USER) = 0',
    statement_types  => 'UPDATE',
    handler_schema   => NULL,
    handler_module   => NULL,
    audit_trail => dbms_fga.db + dbms_fga.extended);
END;
/

-- b. Chính sách bật audit khi có hành vi của người dùng này có thể đọc trên trường PHUCAP của người khác ở quan hệ NHANSU.
/*
BEGIN
  DBMS_FGA.DROP_POLICY(
    object_schema    => 'QLTH',
    object_name      => 'QLTH_NHANSU',
    policy_name      => 'SELECT_PHUCAP_NHANSU');
END;
/
*/

BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema    => 'QLTH',
    object_name      => 'QLTH_NHANSU',
    policy_name      => 'SELECT_PHUCAP_NHANSU',
    audit_column     => 'PHUCAP',
    audit_condition  => 'TO_CHAR(MANS) != USER',
    statement_types  => 'SELECT',
    handler_schema   => NULL,
    handler_module   => NULL,
    audit_trail => dbms_fga.db + dbms_fga.extended);
END;
/

-- Câu 4: Kiểm tra nhật kí của 2 policy trên

SELECT FGA_POLICY_NAME, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, OBJECT_TYPE, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE
FROM UNIFIED_AUDIT_TRAIL
WHERE FGA_POLICY_NAME = 'SELECT_PHUCAP_NHANSU'
ORDER BY EVENT_TIMESTAMP DESC;


SELECT FGA_POLICY_NAME, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, OBJECT_TYPE, SQL_TEXT, SYSTEM_PRIVILEGE_USED, RETURN_CODE
FROM UNIFIED_AUDIT_TRAIL
WHERE FGA_POLICY_NAME = 'UPDATE_DANGKY_DIEM'
ORDER BY EVENT_TIMESTAMP DESC;
