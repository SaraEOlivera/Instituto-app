Use master
Go
Create Database Instituto_BD2 on(
	Name = 'Instituto_BD2',
	Filename = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Instituto_BD2.mdf',
	Size = 10mb,
	Maxsize = 500mb,
	Filegrowth = 100mb
)
Log on 
(
	Name = 'Instituto_BD2_log',
	Filename = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Instituto_BD2_log.ldf',
	Size = 10mb,
	Maxsize = 500mb,
	Filegrowth = 100mb
)