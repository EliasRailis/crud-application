
CREATE TABLE Student(
    StudentID INT NOT NULL,
    Firstname VARCHAR(50) NOT NULL,
    Lastname VARCHAR(50) NOT NULL,
    MI VARCHAR(50),
    Gender VARCHAR(50) NOT NULL,
    Address VARCHAR(50) NOT NULL,
    Birthday DATETIME NOT NULL, 
    PRIMARY KEY(StudentID)
);

--Create Procedure
CREATE PROCEDURE usp_CreateStudentRecord
    @StudentID INT,
    @Firstname VARCHAR(50),
    @Lastname VARCHAR(50),
    @MI VARCHAR(50),
    @Gender VARCHAR(50),
    @Address VARCHAR(50),
    @Birthday DATETIME
AS
BEGIN
INSERT INTO Student(StudentID,Firstname,Lastname,MI,Gender,Address,Birthday) 
VALUES (@StudentID,@Firstname,@Lastname,@MI,@Gender,@Address,@Birthday)
END
GO

--Read procedure
CREATE PROCEDURE usp_ReadStudentRecords
    @StudentID INT
AS
BEGIN
SELECT * FROM Student WHERE StudentID = @StudentID
END
GO

--Update procedure
CREATE PROCEDURE usp_UpdateStudentRecords
    @StudentID INT,
    @Firstname VARCHAR(50),
    @Lastname VARCHAR(50),
    @MI VARCHAR(50),
    @Gender VARCHAR(50),
    @Address VARCHAR(50),
    @Birthday DATETIME
AS
BEGIN
UPDATE Student SET
    Firstname = @Firstname,
    Lastname = @Lastname,
    MI = @MI,
    Gender = @Gender,
    Address = @Address,
    Birthday = @Birthday
WHERE StudentID = @StudentID
END
GO

--Delete procedure
CREATE PROCEDURE usp_DeleteStudentRecord
    @StudentID INT
AS
BEGIN
DELETE FROM Student WHERE StudentID = @StudentID
END
GO
