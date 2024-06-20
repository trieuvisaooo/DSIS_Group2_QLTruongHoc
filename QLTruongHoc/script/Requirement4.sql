ALTER SESSION SET CONTAINER = CDB$ROOT;
-- Enable Flashback
SELECT flashback_on FROM v$database;
ALTER DATABASE FLASHBACK ON;
ALTER SYSTEM SET db_flashback_retention_target = 10080;