drop trigger if exists User_Insert;
drop trigger if exists User_Delete;
drop trigger if exists User_Update;
GO
CREATE TRIGGER User_Insert
    ON [Product]
    AFTER INSERT
AS
BEGIN
    INSERT INTO History(UserId, Operation)
    SELECT Id, 'ADDED ' FROM INSERTED;
END
GO
CREATE TRIGGER User_Delete
    ON [Product]
    AFTER DELETE
AS
BEGIN
    INSERT INTO History(UserId, Operation)
    SELECT Id, 'DELETED ' FROM DELETED;
END
GO
CREATE TRIGGER User_Update
    ON [Product]
    AFTER UPDATE
AS
BEGIN
    INSERT INTO History(UserId, Operation)
    SELECT Id, 'UPDATED ' FROM INSERTED;
END
GO