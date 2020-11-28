--create database ComputerFields;
USE ComputerFields;

CREATE TABLE Login (
    userId INT PRIMARY KEY IDENTITY (1, 1),
    username VARCHAR(100),
    password VARCHAR(100) 
)

INSERT INTO Login (username,password)

VALUES ('nikunj','nikunj'),('nikunj2','nikunj2'),('nikunj3','nikunj3'),('nikunj4','nikunj4'),('nikunj5','nikunj5'); 

SELECT * FROM Login;


CREATE TABLE CSSubjects (
    SubjectID INT PRIMARY KEY IDENTITY (1, 1),
    SubjectName VARCHAR(100),
    SubjectLevel VARCHAR(100),
	Duration INT,
	Descriptions VARCHAR(500),
	PrimaryLanguage VARCHAR(100)
)

INSERT INTO CSSubjects (SubjectName,SubjectLevel,Duration,Descriptions,PrimaryLanguage)

VALUES ('PC Hardware','easy',4,'They set up basic computer systems that meet user requirements by selecting the appropriate types of hardware, cables/connectors, and peripheral devices. ','none'),
('Web Design','easy',4,'develop a well-designed Web site through the use of HTML and CSS.','HTML/CSS'),
('Operating Systems','easy',4,'demonstrations and lab work, students learn to install, deploy, and upgrade a Windows Operating System (OS).','Windows Scripts'),
('Interpersonal Communication','easy',4,'interpersonal communications theory to workplace-based and real life situations. ','none'),
('C++ Programming','mediocore',4,'object-oriented programming using the C++ programming language. Develop algorithms, code, and test at an introductory level','C++'),
('Work Safely','easy',4,'introduces students to the importance of working safely and addresses how employers and employees can control the hazards and risks associated with the workplace.','none'),


('JavaScript Programming ','easy',4,'become familiar with some fundamental of this programming concepts.','JavaScript'),
('Java Programming','easy',4,'Java applications using the current Java SDK and a number of integrated development environments.','Java'),
('Intro to SQL','easy',4,'create and query a database with SQL Data Definition Language (DDL) and SQL Data Manipulation Language (DML).','SQL'),
('Alternative Solutions','mediocore',4,'serve to enhance or supplement existing training in response to cutting edge technologies or industry demands.','Qt(C++)'),

('Database Design','easy',4,'fundamental skills needed to develop a database and its related application.','Visual Paradigm'),
('Database Programming','hard',4,'Connecting to a database and updating the data in that database is an essential part of understanding and building user applications.','.Net (C#)'),
('Game Development in C++','hard',4,' introduced to the concepts of version control, defect tracking systems, and multimedia libraries.','C++'),
('Software Engineering','mediocore',4,'fundamental principles of system development with object oriented technology using Unified Modeling language (UML). ','none'),

('Business for IT','easy',4,'developing communication, collaboration, and leadership skills. ','none'),
('Math for Programming','mediocore',4,'introduces statistics, including descriptive statistics, probability distributions and sampling.','none'),
('Server Side Web Dev','hard',4,'creating robust, scalable web applications for use on the internet.','ASP.Net'),
('Android Programming','hard',4,'Android application programming as a solid foundation for designing, creating and deploying applications into the Google Play Store.','Kotlin'),
('Quality Assurance Testing','mediocore',4,'exposure to the software testing process with a focus on product quality subsequent to unit testing.','Java');


SELECT * FROM CSSubjects;

CREATE TABLE Jobs (
    JobID INT PRIMARY KEY IDENTITY (1, 1),
    JobName VARCHAR(100),
	JobLevel VARCHAR(100),
    EstimatedPay INT,
	Typee VARCHAR(100),
	Descriptions VARCHAR(500),
) 

INSERT INTO Jobs (JobName,JobLevel,EstimatedPay,Typee,Descriptions)

VALUES ('Junior Software developer','Junior',50000,'Software','do programming to develop software'),
('FullStack Developer','Intermediate',50000,'Web Design','JavaScript programming to develop web applications'),
('UX Designer','Senior',40000,'UI','Design UI for Web applications'),
('Quality assurance tester','Intermediate',50000,'Testing','Testing software using Java'),
('Network engineer','Junior',40000,'Networking','Network engineers work on the day-to-day maintenance and development of a companys computer network'),
('Database administrator','Senior',60000,'Database','diagnose and solve complex IT issues related to the data infrastructure to ensure an organizations data is safe'),
('Data scientist','Intermediate',70000,'Data Science','IT tools use statistics and machine learning to help collect and process a companys data such as financial records, sales, prospects and lead generation'),
('Android Developer','Junior',50000,'Application','Java programming to develop Android applications'),
('Game Developer','Junior',80000,'Gaming','C++ programming to develop Game applications');

SELECT * FROM CSSubjects;
SELECT * FROM Jobs;

SELECT TOP (1) JobID FROM Jobs ORDER BY JobName

CREATE TABLE Subject_RelatedJobs (
    Sub_RJobID INT PRIMARY KEY IDENTITY (1, 1),
    SubjectID INT FOREIGN KEY (SubjectID) REFERENCES CSSubjects(SubjectID),
    JobID INT FOREIGN KEY (JobID) REFERENCES Jobs(JobID)
) 
--drop table Subject_RelatedJobs;

INSERT INTO Subject_RelatedJobs (SubjectID,JobID)

VALUES (1,5),
(2,2),(2,3),
(3,1),(3,2),(3,3),(3,4),(3,5),(3,6),(3,7),(3,8),(3,9),
(4,1),(4,2),(4,3),(4,4),(4,5),(4,6),(4,7),(4,8),(4,9),
(5,1),(5,9),
(6,1),(6,2),(6,3),(6,4),(6,5),(6,6),(6,7),(6,8),(6,9),
(7,1),(7,2),(7,9),
(8,1),(8,4),(8,8),
(9,1), (9,6),(9,7),
(10,1),
(11,1),(11,6),(11,7),
(12,1),(12,6),(12,7),
(13,9),
(14,1),(14,2),(14,3),(14,4),(14,5),(14,6),(14,7),(14,8),(14,9),
(15,1),(15,2),(15,3),(15,4),(15,5),(15,6),(15,7),(15,8),(15,9),
(16,1),(16,4),(16,6),(16,7),(16,8),(16,9),
(17,2),(17,6),(17,7),
(18,9),
(19,1),(19,4),(19,6);


SELECT SubjectName,JobName FROM Subject_RelatedJobs SR
JOIN CSSubjects sub ON sub.SubjectID=SR.SubjectID 
JOIN Jobs job ON job.JobID=SR.JobID;
