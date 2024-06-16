-------------------------------------------------------------------------------------------------------------
-- YÊU CẦU 1: CÁC ĐẶT CÁC CHÍNH SÁCH ĐIỀU KHIỂN TRUY CẬP
-------------------------------------------------------------------------------------------------------------
/*
-- Dùng sys cấp quyền exempt access policy cho user QLTH để miễn khỏi tất cả các func RLS cho QLTH
-- Note: Sau khi cấp quyền này thì sử dụng auditing để tránh việc lạm dụng quyền của QLTH
GRANT EXEMPT ACCESS POLICY TO "QLTH";
*/

-------------------------------------------------------------------------------------------------------------
-- CÁC CHÍNH SÁCH CÀI ĐẶT CHUNG
-------------------------------------------------------------------------------------------------------------
-- CS CHUNG 1(XEMTTCN_NHANSU_POLICY): 
-- nhân viên cơ bản, giảng viên, giáo vụ, trưởng đơn vị đều chỉ có thể xem dữ liệu chính mình trên NHANSU, trưởng khoa xem tất cả trên NHANSU
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

/*
BEGIN
    DBMS_RLS.DROP_POLICY(object_schema => 'QLTH',
    object_name => 'QLTH_NHANSU',
    policy_name => 'XEMTTCN_NHANSU_POLICY');
END;
/
*/

BEGIN
    DBMS_RLS.ADD_POLICY(object_schema => 'QLTH',
                        object_name => 'QLTH_NHANSU',
                        policy_name => 'XEMTTCN_NHANSU_POLICY',
                        policy_function => 'XEMTTCN_NHANSU_FUNC',
                        statement_types => 'SELECT, UPDATE',
                        update_check => TRUE);
END;
/
-- SELECT
GRANT SELECT ON QLTH.QLTH_NHANSU TO RL_QLTH_NHANVIEN;
GRANT SELECT ON QLTH.QLTH_NHANSU TO RL_QLTH_GIANGVIEN;
GRANT SELECT ON QLTH.QLTH_NHANSU TO RL_QLTH_GIAOVU;
GRANT SELECT ON QLTH.QLTH_NHANSU TO RL_QLTH_TRUONGDV;
GRANT SELECT ON QLTH.QLTH_NHANSU TO RL_QLTH_TRUONGKHOA;
-- UPDATE
GRANT UPDATE(DT) ON QLTH.QLTH_NHANSU TO RL_QLTH_NHANVIEN;
GRANT UPDATE(DT) ON QLTH.QLTH_NHANSU TO RL_QLTH_GIANGVIEN;
GRANT UPDATE(DT) ON QLTH.QLTH_NHANSU TO RL_QLTH_GIAOVU;
GRANT UPDATE(DT) ON QLTH.QLTH_NHANSU TO RL_QLTH_TRUONGDV;
GRANT UPDATE ON QLTH.QLTH_NHANSU TO RL_QLTH_TRUONGKHOA;
-------------------------------------------------------------------------------------------------------------
-- CS CHUNG 2(XEMPHANCONG_POLICY): 
-- giáo vụ xem toàn bộ PHANCONG, trưởng đơn vị chỉ xem PHANCONG với giáo viên trong khoa, trưởng khoa xem toàn bộ PHANCONG
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

/*
BEGIN
    DBMS_RLS.DROP_POLICY(object_schema => 'QLTH',
    object_name => 'QLTH_PHANCONG',
    policy_name => 'XEMPHANCONG_POLICY');
END;
/
*/

BEGIN
    DBMS_RLS.ADD_POLICY(object_schema => 'QLTH',
                        object_name => 'QLTH_PHANCONG',
                        policy_name => 'XEMPHANCONG_POLICY',
                        policy_function => 'XEMPHANCONG_FUNC',
                        statement_types => 'SELECT');
END;
/
-------------------------------------------------------------------------------------------------------------
-- CS CHUNG 3(SUAPHANCONG_POLICY): 
-- giáo vụ sửa PHANCONG với học phần do VPK quản lý
-- trưởng đơn vị thêm,sửa,xóa phân công PHANCONG với học phần của bộ môn do mình quản lý
-- trưởng khoa thêm,sửa,xóa PHANCONG với học phần do VPK quản lý
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


/*
BEGIN
    DBMS_RLS.DROP_POLICY(object_schema => 'QLTH',
    object_name => 'QLTH_PHANCONG',
    policy_name => 'SUAPHANCONG_POLICY');
END;
/
*/

BEGIN
    DBMS_RLS.ADD_POLICY(object_schema => 'QLTH',
                        object_name => 'QLTH_PHANCONG',
                        policy_name => 'SUAPHANCONG_POLICY',
                        policy_function => 'SUAPHANCONG_FUNC',
                        statement_types => 'INSERT, DELETE, UPDATE',
                        update_check => TRUE);
END;
/
-------------------------------------------------------------------------------------------------------------
-- CS CHUNG 4(THAOTACTRENDANGKY_POLICY): 
-- Giảng viên (trưởng đơn vị, trưởng khoa) được xem DANGKY, chỉnh sửa điểm số những học phần mà mình được phân công dạy
-- Giáo vụ được thêm, xóa theo mong muốn của sinh viên trong thời gian đăng ký
-- Sinh viên xem thông tin đăng ký liên quan đến bản thân, được thêm, xóa trong thời gian đăng ký.

-- Xem đăng ký
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

/*
BEGIN
    DBMS_RLS.DROP_POLICY(object_schema => 'QLTH',
    object_name => 'QLTH_DANGKY',
    policy_name => 'THAOTACTRENDANGKY_POLICY');
END;
/
*/

BEGIN
    DBMS_RLS.ADD_POLICY(object_schema => 'QLTH',
    object_name => 'QLTH_DANGKY',
    policy_name => 'THAOTACTRENDANGKY_POLICY',
    policy_function => 'THAOTACTRENDANGKY_FUNC',
    statement_types => 'SELECT, INSERT, DELETE, UPDATE',
    update_check => TRUE);
END;
/
-------------------------------------------------------------------------------------------------------------
/*
CS#1: “Nhân viên cơ bản”:
-   Xem dòng dữ liệu của chính mình trong quan hệ NHANSU, có thể sửa số điện thoại (ĐT) của chính mình nếu số điện thoại có thay đổi.
-   Xem thông tin của SINHVIEN, DONVI, HOCPHAN, KHMO.
*/

GRANT SELECT ON QLTH.QLTH_SINHVIEN TO RL_QLTH_NHANVIEN;
GRANT SELECT ON QLTH.QLTH_DONVI TO RL_QLTH_NHANVIEN;
GRANT SELECT ON QLTH.QLTH_HOCPHAN TO RL_QLTH_NHANVIEN;
GRANT SELECT ON QLTH.QLTH_KHMO TO RL_QLTH_NHANVIEN;
GRANT SELECT ON QLTH.QLTH_CHUONGTRINH TO RL_QLTH_NHANVIEN; -- Chính sách bổ sung để hiện thị lên app
/*
CS#2: “Giảng viên”:
-   Như một người dùng có vai trò “Nhân viên cơ bản” (xem mô tả CS#1).
-   Xem phân công giảng dạy liên quan đến bản thân mình (PHANCONG).
-   Xem trên quan hệ ĐANGKY liên quan đến các lớp học phần mà giảng viên được phân công giảng dạy.
-   Cập nhật các trường liên quan điểm số (trong quan hệ ĐANGKY) của các sinh viên có tham gia lớp học phần mà giảng viên đó được phân công giảng dạy. Các trường liên quan điểm số bao gồm: ĐIEMTH, ĐIEMQT, ĐIEMCK, ĐIEMTK.
*/

-- Có vai trò "Nhân viên cơ bản"
GRANT RL_QLTH_NHANVIEN TO RL_QLTH_GIANGVIEN;
--GRANT SELECT ON QLTH.QLTH_SINHVIEN TO RL_QLTH_GIANGVIEN;
--GRANT SELECT ON QLTH.QLTH_DONVI TO RL_QLTH_GIANGVIEN;
--GRANT SELECT ON QLTH.QLTH_HOCPHAN TO RL_QLTH_GIANGVIEN;
--GRANT SELECT ON QLTH.QLTH_KHMO TO RL_QLTH_GIANGVIEN;

-- Xem phân công giảng dạy liên quan đến bản thân mình (PHANCONG). 
-- PHANCONG
CREATE OR REPLACE VIEW QLTH.UV_QLTH_XEMPHANCONGGIANGDAY
AS
    SELECT PC.MAGV, PC.MAHP, PC.HK, PC.NAM, PC.MACT, PC.NGAYHOC, PC.TIET
    FROM QLTH.QLTH_PHANCONG PC JOIN QLTH.QLTH_NHANSU GV ON PC.MAGV = GV.MANS
    WHERE TO_CHAR(PC.MAGV) = SYS_CONTEXT('USERENV', 'SESSION_USER') AND (GV.VAITRO = N'Giảng viên' OR GV.VAITRO = N'Trưởng đơn vị' OR GV.VAITRO = N'Trưởng khoa');

GRANT SELECT ON QLTH.UV_QLTH_XEMPHANCONGGIANGDAY TO RL_QLTH_GIANGVIEN;

-- Xem + cập nhật điểm trên quan hệ ĐANGKY liên quan đến các lớp học phần mà giảng viên được phân công giảng dạy
-- DANGKY
GRANT SELECT ON QLTH.QLTH_DANGKY TO RL_QLTH_GIANGVIEN;
GRANT UPDATE(DIEMTHI, DIEMQT, DIEMCK, DIEMTK) ON QLTH.QLTH_DANGKY TO RL_QLTH_GIANGVIEN;

/*
CS#3: “Giáo vụ”:
-   Như một người dùng có vai trò “Nhân viên cơ bản” (xem mô  tả CS#1).
-   Xem, thêm dòng hoặc cập nhật thông tin trên các quan hệ SINHVIEN, ĐONVI, HOCPHAN, KHMO, theo yêu cầu của trưởng khoa.
-   Xem trên toàn bộ quan hệ PHANCONG nhưng chỉ được sửa trên các dòng phân công liên quan các học phần do “Văn phòng khoa” phụ trách phân công giảng dạy, thừa hành người trưởng đơn vị tương ứng là trưởng khoa.
-   Xóa hoặc thêm dòng trên quan hệ ĐANGKY theo yêu cầu của sinh viên trong khoảng thời gian còn cho hiệu chỉnh đăng ký, xem điều kiện có thể hiệu chỉnh đăng ký học phần được mô tả bên dưới.
*/

-- Có vai trò như "Nhân viên cơ bản" + Có quyền thêm sửa thông tin trên SINHVIEN, ĐONVI, HOCPHAN, KHMO
GRANT RL_QLTH_NHANVIEN TO RL_QLTH_GIAOVU;
GRANT INSERT, UPDATE ON QLTH.QLTH_SINHVIEN TO RL_QLTH_GIAOVU;
GRANT INSERT, UPDATE ON QLTH.QLTH_DONVI TO RL_QLTH_GIAOVU;
GRANT INSERT, UPDATE ON QLTH.QLTH_HOCPHAN TO RL_QLTH_GIAOVU;
GRANT INSERT, UPDATE ON QLTH.QLTH_KHMO TO RL_QLTH_GIAOVU;

-- Xem toàn bộ quan hệ PHANCONG --> Chính sách chung 2: XEMPHANCONG_POLICY
-- Sửa trên các dòng phân công liên quan các học phần do “Văn phòng khoa” phụ trách --> Chính sách chung 3: SUAPHANCONG_POLICY 
GRANT SELECT ON QLTH.QLTH_PHANCONG TO RL_QLTH_GIAOVU;
GRANT UPDATE ON QLTH.QLTH_PHANCONG TO RL_QLTH_GIAOVU;

-- Xóa hoặc thêm dòng trên quan hệ ĐANGKY theo yêu cầu của sinh viên trong khoảng thời gian còn cho hiệu chỉnh đăng ký
GRANT SELECT, INSERT, DELETE ON QLTH.QLTH_DANGKY TO RL_QLTH_GIAOVU;

/*
CS#4: “Trưởng đơn vị” gồm trưởng các bộ môn, không kể trưởng khoa:
-   Như một người dùng có vai trò “Giảng viên” (xem mô tả CS#2).
-   Thêm, xóa, sửa trên quan hệ PHANCONG, đối với các học phần được phụ trách chuyên môn bởi đơn vị mà mình làm trưởng, được xem phân công giảng dạy của các giảng viên thuộc các đơn vị mà mình làm trưởng.  
*/

-- Có vai trò như "Giảng viên"
GRANT RL_QLTH_GIANGVIEN TO RL_QLTH_TRUONGDV;
--GRANT SELECT ON QLTH.QLTH_SINHVIEN TO RL_QLTH_TRUONGDV;
--GRANT SELECT ON QLTH.QLTH_DONVI TO RL_QLTH_TRUONGDV;
--GRANT SELECT ON QLTH.QLTH_HOCPHAN TO RL_QLTH_TRUONGDV;
--GRANT SELECT ON QLTH.QLTH_KHMO TO RL_QLTH_TRUONGDV;
--GRANT SELECT ON QLTH.UV_QLTH_XEMPHANCONGGIANGDAY TO RL_QLTH_TRUONGDV;
--GRANT SELECT ON QLTH.QLTH_DANGKY TO RL_QLTH_TRUONGDV;
--GRANT UPDATE(DIEMTHI, DIEMQT, DIEMCK, DIEMTK) ON QLTH.QLTH_DANGKY TO RL_QLTH_TRUONGDV;

GRANT INSERT, DELETE, UPDATE, SELECT ON QLTH.QLTH_PHANCONG TO RL_QLTH_TRUONGDV;
-- Được xem phân công giảng dạy của các giảng viên thuộc các đơn vị mà mình làm trưởng. --> Chính sách chung 2: XEMPHANCONG_POLICY
-- Thêm, xóa, sửa trên quan hệ PHANCONG, đối với các học phần được phụ trách chuyên môn bởi đơn vị mà mình làm trưởng --> Chính sách chung 3: SUAPHANCONG_POLICY
/*
CS#5: “Trưởng khoa”:
--  Như một người dùng có vai trò “Giảng viên” 
-   Thêm, xóa, sửa trên quan hệ PHANCONG, đối với các học phần quản lý bởi đơn vị “Văn phòng khoa”.
-   Được quyền xem, thêm, xóa, cập nhật trên quan hệ NHANSU.
-   Được quyền xem không giới hạn trên toàn bộ lược đồ CSDL.
*/
-- Có vai trò như Giảng viên
GRANT RL_QLTH_GIANGVIEN TO RL_QLTH_TRUONGKHOA;
--GRANT SELECT ON QLTH.QLTH_SINHVIEN TO RL_QLTH_TRUONGKHOA;
--GRANT SELECT ON QLTH.QLTH_DONVI TO RL_QLTH_TRUONGKHOA;
--GRANT SELECT ON QLTH.QLTH_HOCPHAN TO RL_QLTH_TRUONGKHOA;
--GRANT SELECT ON QLTH.QLTH_KHMO TO RL_QLTH_TRUONGKHOA;
--GRANT SELECT ON QLTH.UV_QLTH_XEMPHANCONGGIANGDAY TO RL_QLTH_TRUONGKHOA;
--GRANT SELECT ON QLTH.QLTH_DANGKY TO RL_QLTH_TRUONGKHOA;
--GRANT UPDATE(DIEMTHI, DIEMQT, DIEMCK, DIEMTK) ON QLTH.QLTH_DANGKY TO RL_QLTH_TRUONGKHOA;

-- Thêm, xóa, sửa trên quan hệ PHANCONG, đối với các học phần quản lý bởi đơn vị “Văn phòng khoa”. --> Chính sách chung 3: SUAPHANCONG_POLICY
GRANT SELECT, UPDATE, INSERT, DELETE ON QLTH.QLTH_PHANCONG TO RL_QLTH_TRUONGKHOA;
-- Xem, thêm, xóa, cập nhật trên quan hệ NHANSU.
GRANT SELECT, UPDATE, INSERT, DELETE ON QLTH.QLTH_NHANSU TO RL_QLTH_TRUONGKHOA;

GRANT SELECT ON QLTH.QLTH_CHUONGTRINH TO RL_QLTH_TRUONGKHOA;
GRANT SELECT ON QLTH.QLTH_COSO TO RL_QLTH_TRUONGKHOA;
GRANT SELECT ON QLTH.QLTH_NGANH TO RL_QLTH_TRUONGKHOA;
GRANT SELECT ON QLTH.QLTH_THOIGIANDK TO RL_QLTH_TRUONGKHOA;

/*
CS#6: “Sinh viên”:
-   Trên quan hệ SINHVIEN, sinh viên chỉ được xem thông tin của chính mình, được chỉnh sửa thông tin địa chỉ (ĐCHI) và số điện thoại liên lạc (ĐT) của chính sinh viên.
-   Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương trình mà sinh viên đang theo học.
-   Thêm, xóa các dòng đăng ký học phần (ĐANGKY) liên quan đến chính sinh viên đó trong học kỳ của năm học hiện tại, nếu thời điểm hiệu chỉnh đăng ký còn hợp lệ. Sinh viên không thể sửa trên các trường liên quan đến điểm. Sinh viên được xem tất cả thông tin trên quan hệ ĐANGKY tại các dòng dữ liệu liên quan đến chính sinh viên.
*/
--------------------------------------------------------------------------------
/*
Trên quan hệ SINHVIEN, sinh viên chỉ được xem thông tin của chính mình, được
Chỉnh sửa thông tin địa chỉ (ĐCHI) và số điện thoại liên lạc (ĐT) của chính sinh viên.
*/
GRANT SELECT ON QLTH.QLTH_SINHVIEN TO RL_QLTH_SINHVIEN;
GRANT UPDATE(DIACHI, DT) ON QLTH.QLTH_SINHVIEN TO RL_QLTH_SINHVIEN;
GRANT SELECT ON QLTH.QLTH_CHUONGTRINH TO RL_QLTH_SINHVIEN; -- Chính sách bổ sung để hiện thị lên app

-- GRANT RL_QLTH_SINHVIEN TO "21120347";
-- SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '21120347';
-- SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = 'RL_QLTH_SINHVIEN';

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

/*
BEGIN
    DBMS_RLS.DROP_POLICY(object_schema => 'QLTH',
    object_name => 'QLTH_SINHVIEN',
    policy_name => 'XEM_TTSV_SV_POLICY');
END;
/
*/

BEGIN
    DBMS_RLS.ADD_POLICY(object_schema => 'QLTH',
    object_name => 'QLTH_SINHVIEN',
    policy_name => 'XEM_TTSV_SV_POLICY',
    policy_function => 'XEM_TTSV_SV_FUNC',
    statement_types => 'SELECT, UPDATE',
    update_check => TRUE);
END;
/

--------------------------------------------------------------------------------
/*
- Xem danh sách tất cả học phần (HOCPHAN)
- Xem danh sách kế hoạch mở môn (KHMO) của chương trình đào tạo mà sinh viên đang theo học.
*/
-- Xem danh sách tất cả học phần của chương trình đào tạo mà sinh viên đang theo học.
GRANT SELECT ON QLTH.QLTH_HOCPHAN TO RL_QLTH_SINHVIEN;
-- Xem danh sách kế hoạch mở môn (KHMO) của chương trình đào tạo mà sinh viên đang theo học.
CREATE OR REPLACE VIEW QLTH.UV_QLTH_KEHOACHMOHP AS
    SELECT KHM.MAHP, KHM.HK, KHM.NAM, KHM.MACT, PC.NGAYHOC, PC.TIET, HP.TENHP, HP.SOTC, HP.STLT, HP.STTH, HP.SOSVTD, HP.MADV
    FROM QLTH.QLTH_KHMO KHM JOIN QLTH.QLTH_HOCPHAN HP ON KHM.MAHP = HP.MAHP
                       JOIN QLTH.QLTH_PHANCONG PC ON KHM.MAHP = PC.MAHP AND KHM.HK = PC.HK AND KHM.NAM = PC.NAM AND KHM.MACT = PC.MACT;
GRANT SELECT ON QLTH.UV_QLTH_KEHOACHMOHP TO RL_QLTH_SINHVIEN;

CREATE OR REPLACE FUNCTION QLTH.XEM_KHMO_SV_FUNC (P_SCHEMA IN VARCHAR2, P_OBJECT IN VARCHAR2)
    RETURN VARCHAR2
AS 
   MACT_TEMP VARCHAR2(5);
BEGIN 
    SELECT MACT INTO MACT_TEMP FROM QLTH.QLTH_SINHVIEN WHERE TO_CHAR(MASV) = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF (MACT_TEMP IS NOT NULL) THEN
        RETURN 'MACT = ' || '''' || MACT_TEMP || '''';
    ELSE 
        RETURN '';
    END IF;
END;
/

/*
BEGIN
    DBMS_RLS.DROP_POLICY(object_schema => 'QLTH',
    object_name => 'UV_QLTH_KEHOACHMOHP',
    policy_name => 'XEM_KHMO_SV_POLICY');
END;
/
*/

BEGIN
    DBMS_RLS.ADD_POLICY(object_schema => 'QLTH',
    object_name => 'UV_QLTH_KEHOACHMOHP',
    policy_name => 'XEM_KHMO_SV_POLICY',
    policy_function => 'XEM_KHMO_SV_FUNC',
    statement_types => 'SELECT' );
END;
/
--------------------------------------------------------------------------------
/*
- Thêm, Xóa các dòng dữ liệu đăng ký học phần (ĐANGKY) liên quan đến chính sinh
viên đó trong học kỳ của năm học hiện tại (nếu thời điểm hiệu chỉnh đăng ký còn hợp
lệ).
- Sinh viên không được chỉnh sửa trên các trường liên quan đến điểm.
- Chính sách bổ sung: Sinh viên có thể xem các môn đã đăng kí của mình
*/
-- Tạo trigger để chỉ cho phép thêm, xóa trên bảng đăng kí trong thời gian đăng kí học phần
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

-- Grant quyền:
GRANT SELECT, INSERT, DELETE ON QLTH.QLTH_DANGKY TO RL_QLTH_SINHVIEN;

--------------------------------------------------------------------------------
-- YÊU CẦU 2: CÁC ĐẶT CÁC CHÍNH SÁCH OLS CHO BẢNG THÔNG BÁO
--------------------------------------------------------------------------------

--------------------------------------------------------------------------------
-- BƯỚC 1: TẠO CHÍNH SÁCH OLS 
--------------------------------------------------------------------------------
--CONNECT QLTH/QLTH@//localhost:1522/QLTRUONGHOC;
-- alter session set container = QLTRUONGHOC;
EXECUTE SA_SYSDBA.DROP_POLICY('notification_olspolicy');
/

BEGIN 
     SA_SYSDBA.CREATE_POLICY( 
     policy_name => 'notification_olspolicy', 
     column_name => 'notification_label'
); 
END; 
/
---------------------------------------------------
-- ENABLE POLICY VỪA TẠO -> KHỞI ĐỘNG LẠI SQLDEV --
---------------------------------------------------
EXEC SA_SYSDBA.ENABLE_POLICY ('notification_olspolicy'); 
/
