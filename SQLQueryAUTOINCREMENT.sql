ALTER TABLE DAU DROP CONSTRAINT PK_DAU
ALTER TABLE DAU DROP COLUMN DAU_Id
ALTER TABLE DAU ADD DAU_Id INT IDENTITY(1,1) primary key;