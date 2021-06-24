/* გვაქვს Teacher ცხრილი, რომელსაც აქვს შემდეგი მახასიათებლები: სახელი, გვარი, სქესი, საგანი. გვაქვს Pupil ცხრილი, რომელსაც აქვს შემდეგი მახასიათებლები: სახელი, გვარი, სქესი, კლასი. ააგეთ ნებისმიერ რელაციურ ბაზაში ისეთი დამოკიდებულება, რომელიც საშუალებას მოგვცემს, რომ მასწავლებელმა ასწავლოს რამოდენიმე მოსწავლეს და ამავდროულად მოსწავლეს ჰყავდეს რამდენიმე მასწავლებელი (როგორც რეალურ ცხოვრებაში). 1. დაწერეთ sql რომელიც ააგებს შესაბამის table-ებს. 2. დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც ასწავლის მოსწავლეს, რომელის სახელია: „გიორგი“ . Teacher: Name Lname Sex Subject Pupil: Name Lname Sex Class */

DROP TABLE IF EXISTS TeacherPupilRelation;

DROP TABLE IF EXISTS Teacher;

DROP TABLE IF EXISTS Pupil;


CREATE TABLE Teacher( TeacherID INT PRIMARY KEY NOT NULL IDENTITY(1,1), Name varchar(30), Lname varchar(30), Sex varchar(15), Subject varchar(50) );



INSERT INTO Teacher(Name, Lname, Sex, Subject) values ('Natela', 'Maglakelidze', 'Female', 'Inglisuri');

INSERT INTO Teacher(Name, Lname, Sex, Subject) values ('Giuli', 'Lepetvadze', 'Female', 'Qartuli');

INSERT INTO Teacher(Name, Lname, Sex, Subject) values ('Anton', 'Rekepitdze', 'Male', 'Matematika');



CREATE TABLE Pupil( PupilID INT PRIMARY KEY NOT NULL IDENTITY(1,1), Name varchar(35), Lname varchar(35), Sex varchar(10), Class varchar(10) );



INSERT INTO Pupil(Name, Lname, Sex, Class) values ('Giorgi', 'Giorgadze', 'Male', '11');

INSERT INTO Pupil(Name, Lname, Sex, Class) values ('Luka', 'Lukava', 'Male', '2');

INSERT INTO Pupil(Name, Lname, Sex, Class) values ('Lika', 'Likashvili', 'Female', '7');



CREATE TABLE TeacherPupilRelation( TeacherID INT NOT NULL, PupilID INT NOT NULL, FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID), FOREIGN KEY (PupilID) REFERENCES Pupil(PupilID), UNIQUE (TeacherID, PupilID) );



INSERT INTO TeacherPupilRelation(TeacherID, PupilID) values (1, 2);

INSERT INTO TeacherPupilRelation(TeacherID, PupilID) values (2, 3);

INSERT INTO TeacherPupilRelation(TeacherID, PupilID) values (2, 2);

INSERT INTO TeacherPupilRelation(TeacherID, PupilID) values (3, 1);

INSERT INTO TeacherPupilRelation(TeacherID, PupilID) values (3, 3);



SELECT  *
FROM Pupil AS p
JOIN [dbo].[TeacherPupilRelation] AS tpr
ON p.PupilID = tpr.PupilID
JOIN Teacher AS t
ON t.TeacherID = tpr.TeacherID
SELECT  *
FROM Teacher AS T
JOIN [dbo].[TeacherPupilRelation] AS tpr
ON t.TeacherID = tpr.TeacherID
JOIN Pupil AS p
ON p.PupilID = tpr.PupilID
WHERE p.Name = 'giorgi'  