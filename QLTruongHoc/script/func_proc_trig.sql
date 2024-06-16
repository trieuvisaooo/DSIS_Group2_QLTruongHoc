ALTER SESSION SET CONTAINER = XEPDB1;
-------------------------------------------------------------------------------------------------------------
-- 1. FUNCTIONS
-------------------------------------------------------------------------------------------------------------
-- Func1
CREATE OR REPLACE FUNCTION QLTH.XEMTTCN_NHANSU_FUNC(P_SCHEMA IN VARCHAR2, P_OBJECT IN VARCHAR2)
    RETURN VARCHAR2
AS
    LATRGKHOA NUMBER;
    LANHANSU NUMBER;
BEGIN 
    SELECT COUNT(*) INTO LANHANSU FROM QLTH.QLTH_NHANSU WHERE TO_CHAR(MANS) = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF (LANHANSU = 1) THEN 
        SELECT COUNT(*) INTO LATRGKHOA FROM QLTH.QLTH_DONVI WHERE MADV = 'VPK' AND TO_CHAR(TRGDV) = SYS_CONTEXT('USERENV', 'SESSION_USER');
        IF (LATRGKHOA = 1) THEN
            RETURN '';
        ELSE
            RETURN 'MANS = ' || SYS_CONTEXT('USERENV', 'SESSION_USER');
        END IF;
    ELSE 
        RETURN '1 = 0';
    END IF;

END;
/
-- Func2
CREATE OR REPLACE FUNCTION QLTH.XEMPHANCONG_FUNC(P_SCHEMA IN VARCHAR2, P_OBJECT IN VARCHAR2)
    RETURN VARCHAR2
AS
    V_USERNAME VARCHAR2(10);
    LaNS NUMBER;
    LaSV NUMBER;
    V_VAITRO NVARCHAR2(50);
    V_DONVI VARCHAR2(10);
    MA_CUR SYS_REFCURSOR;
    MA VARCHAR(10);
    STRSQL VARCHAR2(4000);
BEGIN
    V_USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
    SELECT COUNT(*) INTO LaNS FROM QLTH.QLTH_NHANSU WHERE TO_CHAR(MANS) = V_USERNAME;
    SELECT COUNT(*) INTO LaSV FROM QLTH.QLTH_SINHVIEN WHERE TO_CHAR(MASV) = V_USERNAME;
    IF (LaSV = 1) THEN 
         RETURN '';
    END IF;
    IF (LaNS = 1) THEN 
        SELECT VAITRO, MADV INTO V_VAITRO, V_DONVI FROM QLTH.QLTH_NHANSU WHERE TO_CHAR(MANS) = V_USERNAME;
    END IF;
    IF (V_VAITRO = N'Giáo vụ' OR V_VAITRO = N'Trưởng khoa') THEN
        RETURN '';
    ELSIF (V_VAITRO = N'Trưởng đơn vị') THEN
        OPEN MA_CUR FOR SELECT TO_CHAR(MANS) FROM QLTH.QLTH_NHANSU WHERE MADV = V_DONVI;
        LOOP 
            FETCH MA_CUR INTO MA;
            EXIT WHEN MA_CUR%NOTFOUND;
            
            IF (STRSQL IS NOT NULL) THEN
                STRSQL := STRSQL || ',';
            END IF;
            
            STRSQL := STRSQL || TO_NUMBER(MA); --'''' || MA || '''';
            
        END LOOP;
        CLOSE MA_CUR;
        
        IF (STRSQL IS NULL) THEN
            RETURN '1 = 0';
        ELSE 
            RETURN 'MAGV IN (' || STRSQL || ')';
        END IF; 
    ELSIF (V_VAITRO = N'Giảng viên') THEN
        RETURN 'MAGV = ' || TO_NUMBER(V_USERNAME);
    ELSE
        RETURN '1 = 0';
    END IF;
END;
/
-- Func3
CREATE OR REPLACE FUNCTION QLTH.SUAPHANCONG_FUNC(P_SCHEMA IN VARCHAR2, P_OBJECT IN VARCHAR2)
    RETURN VARCHAR2
AS
    V_VAITRO NVARCHAR2(50);
    V_DONVI VARCHAR2(10);
    MA_CUR SYS_REFCURSOR;
    MA VARCHAR(10);
    STRSQL VARCHAR2(4000);
BEGIN
    
    SELECT VAITRO, MADV INTO V_VAITRO, V_DONVI FROM QLTH.QLTH_NHANSU WHERE TO_CHAR(MANS) = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF (V_VAITRO = N'Giáo vụ' OR V_VAITRO = N'Trưởng khoa') THEN
        OPEN MA_CUR FOR SELECT MAHP FROM QLTH.QLTH_HOCPHAN WHERE MADV = 'VPK';
        LOOP 
            FETCH MA_CUR INTO MA;
            EXIT WHEN MA_CUR%NOTFOUND;
            
            IF (STRSQL IS NOT NULL) THEN
                STRSQL := STRSQL || ',';
            END IF;
            
            STRSQL := STRSQL || '''' || MA || '''';
            
        END LOOP;
        CLOSE MA_CUR;
        IF (STRSQL IS NULL) THEN
            RETURN '1 = 0';
        ELSE 
            RETURN 'MAHP IN (' || STRSQL || ')';
        END IF; 
    ELSIF (V_VAITRO = N'Trưởng đơn vị') THEN
        OPEN MA_CUR FOR SELECT MAHP FROM QLTH.QLTH_HOCPHAN WHERE MADV = V_DONVI;
        LOOP 
            FETCH MA_CUR INTO MA;
            EXIT WHEN MA_CUR%NOTFOUND;
            
            IF (STRSQL IS NOT NULL) THEN
                STRSQL := STRSQL || ',';
            END IF;
            
            STRSQL := STRSQL || '''' || MA || '''';
            
        END LOOP;
        CLOSE MA_CUR;
        IF (STRSQL IS NULL) THEN
            RETURN '1 = 0';
        ELSE 
            RETURN 'MAHP IN (' || STRSQL || ')';
        END IF;
    ELSE
        RETURN '1 = 0';
    END IF;
END;
/
-- Func4
CREATE OR REPLACE FUNCTION QLTH.THAOTACTRENDANGKY_FUNC (P_SCHEMA IN VARCHAR2, P_OBJECT IN VARCHAR2)
    RETURN VARCHAR2
AS 
    UName NUMBER;
    LaGVien NUMBER;
    LaGVu NUMBER;
    LaSV NUMBER;
    V_MACT VARCHAR2(5);
BEGIN 
    UName := TO_NUMBER(SYS_CONTEXT('USERENV', 'SESSION_USER'));
    SELECT COUNT(*) INTO LaGVien FROM QLTH.QLTH_NHANSU WHERE MANS = UName AND (VAITRO = N'Giảng viên' OR VAITRO = N'Trưởng đơn vị' OR VAITRO = N'Trưởng khoa');
    SELECT COUNT(*) INTO LaGVu FROM QLTH.QLTH_NHANSU WHERE MANS = UName AND VAITRO = N'Giáo vụ';
    SELECT COUNT(*) INTO LaSV FROM QLTH.QLTH_SINHVIEN WHERE MASV = UName;
    IF (LaGVien = 1) THEN
        RETURN 'MAGV = ' || UName;
    ELSIF (LaGVu = 1) THEN
        RETURN '';
    ELSIF (LaSV = 1) THEN
        SELECT SV.MACT INTO V_MACT FROM QLTH.QLTH_SINHVIEN SV WHERE SV.MASV = UName;
        RETURN 'MASV = ' || UName || ' AND MACT = ' || '''' || V_MACT || '''';
    ELSE
        RETURN '1 = 0';
    END IF;
END;
/
-- Func5
CREATE OR REPLACE FUNCTION QLTH.XEM_TTSV_SV_FUNC (P_SCHEMA IN VARCHAR2, P_OBJECT IN VARCHAR2)
    RETURN VARCHAR2
AS 
   UserName QLTH.QLTH_SINHVIEN.MASV%TYPE;
   LaSV NUMBER;
BEGIN 
    UserName := SYS_CONTEXT('USERENV', 'SESSION_USER');
    SELECT COUNT(*) INTO LaSV FROM QLTH.QLTH_SINHVIEN WHERE MASV = UserName;
    IF (LaSV = 1) THEN
        RETURN 'MASV = ' || UserName;
    ELSE 
        RETURN '';
    END IF;
END;
/
-- Func6
CREATE OR REPLACE FUNCTION XEMTGDK_FUNC (P_SCHEMA IN VARCHAR2, P_OBJECT IN VARCHAR2)
    RETURN VARCHAR2
AS 
   LASV NUMBER;
   V_MACT VARCHAR2(5);
BEGIN 
    SELECT COUNT(*) INTO LASV FROM QLTH.QLTH_SINHVIEN WHERE TO_CHAR(MASV) = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF (LASV = 1) THEN
        SELECT MACT INTO V_MACT FROM QLTH.QLTH_SINHVIEN WHERE TO_CHAR(MASV) = SYS_CONTEXT('USERENV', 'SESSION_USER');
        RETURN 'MACT = ' || '''' || V_MACT || '''';
    ELSE 
        RETURN '';
    END IF;
END;
/
-- Func7
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
-- Func8
-- Func9
-- Func10
-- Func11
-- Func12
-- Func13
-- Func14

-------------------------------------------------------------------------------------------------------------
-- 2. STORE PROCEDURES
-------------------------------------------------------------------------------------------------------------
-- SYS PROCS
-- SP1
CREATE OR REPLACE PROCEDURE SYS.USP_RECOVER_TABLE
    (TAB_NAME IN VARCHAR2, RECOVER_TIME IN VARCHAR2, RES OUT NUMBER)
AS
    STRSQL VARCHAR2(2000);
BEGIN
    STRSQL := 'ALTER TABLE ' || TAB_NAME || ' ENABLE ROW MOVEMENT';
    EXECUTE IMMEDIATE (STRSQL);
    
    STRSQL := 'FLASHBACK TABLE ' || TAB_NAME || ' TO TIMESTAMP TO_TIMESTAMP(' || '''' || RECOVER_TIME || '''' || ', ''MM/DD/YYYY HH:MI:SS AM'')';
    EXECUTE IMMEDIATE (STRSQL);

    STRSQL := 'ALTER TABLE ' || TAB_NAME || ' DISABLE ROW MOVEMENT';
    EXECUTE IMMEDIATE (STRSQL);
    
    RES := 0;
END;
/
-- QLTH PROCS
-- SP2
-- SP8
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."CREATE_ROLE" (
  p_role_name IN VARCHAR2,
  p_password IN VARCHAR2 DEFAULT NULL
)
IS
BEGIN
  IF p_password IS NULL THEN
  BEGIN
    EXECUTE IMMEDIATE ('CREATE ROLE ' || p_role_name);
  END;
  ELSE
    EXECUTE IMMEDIATE ('CREATE ROLE ' || p_role_name || ' IDENTIFIED BY ' || p_password);
  END IF;
END;
/
-- SP9
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."ADDUSER_PROC" 
    (u_username VARCHAR2, u_password VARCHAR2)
AS
    STRSQL VARCHAR2(2000);

BEGIN
--    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
--    EXECUTE IMMEDIATE (STRSQL);

    STRSQL := 'CREATE USER ' || '"' || u_username || '"' ||' IDENTIFIED BY ' || '"' || u_password || '"';
    EXECUTE IMMEDIATE (STRSQL);

    STRSQL := 'GRANT CONNECT TO ' || '"' || u_username || '"';
    EXECUTE IMMEDIATE (STRSQL);
--    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
--    EXECUTE IMMEDIATE (STRSQL);
END;
/
-- SP10
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."CHECK_USER_ROLE_EXIST" (
    user_role in varchar2,
    result_ out number
)
as
    cnt int;
begin
    SELECT count(*) into cnt FROM DBA_ROLES WHERE role = user_role;
    if cnt > 0 then
        result_ := 2;
    else 
        begin
            SELECT count(*) into cnt FROM DBA_USERS WHERE username = user_role;
            if cnt > 0 then
                result_ := 1;
            else
                result_ := 0;
            end if;
        end;
    end if;
end;
/
-- SP11
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."DELETE_ROLE" (
    p_role_name IN VARCHAR2
) AS
BEGIN
        EXECUTE IMMEDIATE ('DROP ROLE ' || p_role_name);
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'Error deleting role: ' || SQLERRM);
END delete_role;
/
-- SP12
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."DELETE_USER" (p_username IN VARCHAR2)
IS
BEGIN
  EXECUTE IMMEDIATE ('DROP USER ' || '"' || p_username || '"');
END;
/
-- SP13
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."GRANT_ROLE" (
    user_name in varchar2,
    role_name in varchar2,
    withadminoption in varchar2,
    result_ out number
)
as
    user_role_exist int;
BEGIN
    check_user_role_exist(user_name, user_role_exist);
    if user_role_exist = 0 then 
        result_ := -1;
        return;
    end if;
    check_user_role_exist(role_name, user_role_exist);
    if user_role_exist = 0 or user_role_exist = 1 then 
        result_ := -2;
        return;
    end if;
    execute immediate 'GRANT "' || role_name || '" TO "' || user_name || '" ' || withadminoption;
    result_ := 3;
    return;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -01918 THEN
            RAISE;
        END IF;
END;
/
-- SP14
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."REVOKE_ROLE" 
(
    userOrRole varchar2,
    role_name varchar2,
    result_ OUT int
)
IS
    user_role_exist int;
    res int;
BEGIN
    check_user_role_exist(userOrRole, user_role_exist);
    if user_role_exist = 0 then --N?u userOrRole kh�ng t?n t?i
        result_ := -1;
        return;
    end if;
    check_user_role_exist(role_name, user_role_exist);
    if user_role_exist = 0 or user_role_exist = 1 then --N?u role_name kh�ng t?n t?i
        result_ := -2;
        return;
    end if;
    select count(*) into res from dba_role_privs where grantee = userOrRole and granted_role = role_name;
    if res = 0 then
        result_ := -3;
        return;
    end if;
    execute immediate ('REVOKE ' || role_name || ' FROM ' || userOrRole);
    result_ := 3;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -01918 THEN
            RAISE;
        END IF;
END;
/
-- SP15
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."CHANGE_ROLE_PASSWORD" (
  p_role_name IN VARCHAR2,
  p_new_password IN VARCHAR2
)
IS
  role_exists NUMBER;
BEGIN
  SELECT COUNT(*) INTO role_exists FROM dba_roles WHERE role = p_role_name;

  IF role_exists > 0 THEN
    IF (p_new_password IS NULL) THEN
      EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role_name || ' NOT IDENTIFIED';
      DBMS_OUTPUT.PUT_LINE('Password for role ' || p_role_name || ' has been removed.');
    ELSE
      EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role_name || ' IDENTIFIED BY ' || p_new_password;
      DBMS_OUTPUT.PUT_LINE('Password for role ' || p_role_name || ' has been changed.');
    END IF;
  ELSE
    DBMS_OUTPUT.PUT_LINE('Role ' || p_role_name || ' does not exist.');
  END IF;
END;
/
-- SP16
CREATE OR REPLACE PROCEDURE "QLTH"."CHANGE_PASSWORD" (
   p_username IN VARCHAR2,
   p_new_password IN VARCHAR2
) AS
   v_user_count NUMBER;
BEGIN
   -- Check if the user exists and the old password is correct
   SELECT COUNT(*) INTO v_user_count FROM dba_users WHERE username = p_username;

   IF v_user_count = 0 THEN
      RAISE_APPLICATION_ERROR(-20001, 'User does not exist is incorrect');
   END IF;

   -- Change the user's password
   EXECUTE IMMEDIATE 'ALTER USER ' || '"' ||p_username || '"'|| ' IDENTIFIED BY ' || '"' ||p_new_password || '"';
   DBMS_OUTPUT.PUT_LINE('Password changed successfully');
EXCEPTION
   WHEN OTHERS THEN
      DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
END;
/
-- SP17
CREATE OR REPLACE NONEDITIONABLE PROCEDURE "QLTH"."GRANTSELECTPRIV" (
    user_role in varchar2,
    schema_name in varchar2,
    table_name in varchar2,
    column_name in varchar2,
    withgrantoption in varchar2
)
as
    view_string varchar2(100);
    numOfView number;
begin
    view_string := 'SELECTVIEW_' || table_name || '_' || user_role;
    select count(*) into numOfView
    from all_views
    where view_name =  view_string and owner = schema_name;
    if (numOfView > 0) then
        execute immediate 'DROP VIEW ' || '"' || schema_name || '"' || '.' || '"' || view_string || '"';    
    end if;

    execute immediate 'CREATE OR REPLACE VIEW ' || '"' ||schema_name || '"' || '.' || '"' || view_string || '"' || ' AS SELECT ' || column_name || ' FROM ' || '"' ||schema_name || '"' || '.' || '"' || table_name || '"';
    execute immediate 'GRANT SELECT ON ' || '"' || schema_name || '"' || '.' || '"' || view_string || '"' || ' TO "' || user_role || '" ' || withgrantoption;   
end;
/
-- SP18
CREATE OR REPLACE PROCEDURE QLTH.USER_LOGIN
    (USRNAME VARCHAR2, USR_ROLE NVARCHAR2, CNT OUT INTEGER)
AS
    LaSV NUMBER;
    LaNS NUMBER;
BEGIN
    CNT := 0;
    
    IF USR_ROLE = N'Sinh viên' THEN
        SELECT COUNT(*) INTO LaSV FROM QLTH.QLTH_SINHVIEN WHERE TO_CHAR(MASV) = USRNAME;
    ELSE    
        SELECT COUNT(*) INTO LaNS FROM QLTH.QLTH_NHANSU WHERE TO_CHAR(MANS) = USRNAME AND VAITRO = USR_ROLE;
    END IF;
    
    IF (LaNS = 1) THEN
        CNT := 1;
    END IF;
    
    IF (LaSV = 1) THEN
        CNT := 2;
    END IF;
END;
/
-------------------------------------------------------------------------------------------------------------
-- 3. TRIGGERS
-------------------------------------------------------------------------------------------------------------
CREATE OR REPLACE TRIGGER QLTH.CHINHSUADK_TRIG 
    BEFORE 
    INSERT OR DELETE
    ON QLTH.QLTH_DANGKY
    FOR EACH ROW
DECLARE
    NGAYBD TIMESTAMP;
    NGAYKT TIMESTAMP;
    NGAYSUA TIMESTAMP;
BEGIN 
    NGAYSUA := SYSDATE;
    IF INSERTING THEN
        SELECT TGDK.NGAYBD, TGDK.NGAYKT INTO NGAYBD, NGAYKT 
        FROM QLTH.QLTH_THOIGIANDK "TGDK" 
        WHERE TGDK.HK = :NEW.HK AND TGDK.NAM = :NEW.NAM AND TGDK.MACT = :NEW.MACT;
        
        SELECT PC.MAGV INTO :NEW.MAGV
        FROM QLTH.QLTH_PHANCONG "PC"
        WHERE PC.MAHP = :NEW.MAHP AND PC.HK = :NEW.HK AND PC.NAM = :NEW.NAM AND PC.MACT = :NEW.MACT AND PC.NGAYHOC = :NEW.NGAYHOC AND PC.TIET = :NEW.TIET;
    ELSIF DELETING THEN 
        SELECT TGDK.NGAYBD, TGDK.NGAYKT INTO NGAYBD, NGAYKT 
        FROM QLTH.QLTH_THOIGIANDK "TGDK" 
        WHERE TGDK.HK = :OLD.HK AND TGDK.NAM = :OLD.NAM AND TGDK.MACT = :OLD.MACT;
    END IF;
    
    IF (NGAYSUA < NGAYBD) THEN
        RAISE_APPLICATION_ERROR (-20500, 'Chưa tới thời gian đăng kí học phần.'); 
        ROLLBACK;
    END IF;
    
    IF (NGAYSUA > NGAYKT) THEN
        RAISE_APPLICATION_ERROR (-20505, 'Đã hết thời gian đăng kí học phần.');
        ROLLBACK;
    END IF;
    
END;
/

CREATE OR REPLACE TRIGGER QLTH.CAPNHATSVDK_INSERT_TRIG 
    AFTER 
    INSERT
    ON QLTH.QLTH_DANGKY
    FOR EACH ROW
DECLARE
    V_SOSVTD NUMBER;
    V_SOSVDK_NEW NUMBER;
BEGIN 
    SELECT SOSVDK + 1 INTO V_SOSVDK_NEW FROM QLTH.QLTH_PHANCONG
    WHERE MAHP = :NEW.MAHP AND HK = :NEW.HK AND NAM = :NEW.NAM AND MACT = :NEW.MACT AND NGAYHOC = :NEW.NGAYHOC AND TIET = :NEW.TIET;
    
    SELECT SOSVTD INTO V_SOSVTD FROM QLTH.QLTH_HOCPHAN WHERE MAHP = :NEW.MAHP;
    
    IF (V_SOSVDK_NEW > V_SOSVTD) THEN
        RAISE_APPLICATION_ERROR (-20500, 'Đăng kí thất bại!'); 
        ROLLBACK;
    ELSE
        UPDATE QLTH.QLTH_PHANCONG SET SOSVDK = V_SOSVDK_NEW 
        WHERE MAHP = :NEW.MAHP AND HK = :NEW.HK AND NAM = :NEW.NAM AND MACT = :NEW.MACT AND NGAYHOC = :NEW.NGAYHOC AND TIET = :NEW.TIET; 
    END IF;
END;
/


CREATE OR REPLACE TRIGGER QLTH.CAPNHATSVDK_DELETE_TRIG 
    AFTER 
    DELETE
    ON QLTH.QLTH_DANGKY
    FOR EACH ROW
DECLARE
    V_SOSVTD NUMBER;
    V_SOSVDK_NEW NUMBER;
BEGIN 
    SELECT SOSVDK - 1 INTO V_SOSVDK_NEW FROM QLTH.QLTH_PHANCONG
    WHERE MAHP = :OLD.MAHP AND HK = :OLD.HK AND NAM = :OLD.NAM AND MACT = :OLD.MACT AND NGAYHOC = :OLD.NGAYHOC AND TIET = :OLD.TIET;
    
    SELECT SOSVTD INTO V_SOSVTD FROM QLTH.QLTH_HOCPHAN WHERE MAHP = :OLD.MAHP;
    
    IF (V_SOSVDK_NEW = -1) THEN
        RAISE_APPLICATION_ERROR (-20500, 'Hủy đăng kí thất bại!'); 
        ROLLBACK;
    ELSE
        UPDATE QLTH.QLTH_PHANCONG SET SOSVDK = V_SOSVDK_NEW 
        WHERE MAHP = :OLD.MAHP AND HK = :OLD.HK AND NAM = :OLD.NAM AND MACT = :OLD.MACT AND NGAYHOC = :OLD.NGAYHOC AND TIET = :OLD.TIET; 
    END IF;
END;
/