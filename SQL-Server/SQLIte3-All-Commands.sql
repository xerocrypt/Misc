
/********* CREATE NEW TABLE ****************/
CREATE TABLE Introduction (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, English TEXT, German TEXT, Note TEXT, Category TEXT);


/************* INSERT INTO TABLE *********************/
INSERT INTO Introduction VALUES (0001, 'Test', 'Test', '', 'Introduction');


/********** SELECT ALL RECORDS FROM TABLE *************/
SELECT * FROM Introduction


/************ SHOW TABLE SCHEMA ******************/
.schema Introduction


/************ UPDATE AN ENTRY *****************/
UPDATE Introduction SET English = 'How are you?' WHERE Id = 2;
