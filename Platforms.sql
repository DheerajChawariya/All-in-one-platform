USE all_in_one_platform;
GO
CREATE TABLE platforms
(SNO INT PRIMARY KEY,
Educational_Platforms VARCHAR(100),
Job_Provider_Platforms VARCHAR(100),
Online_Community_Platforms VARCHAR(100),
E_Commerce_Platforms VARCHAR(100),
Travelling_Platforms VARCHAR(100),
Entertainment_Platforms VARCHAR(100),
AI_Tools VARCHAR(100),
News_Platforms VARCHAR(100));
Go
Insert into platforms(SNO,Educational_Platforms) VALUES(8,'Shiksha');
Go