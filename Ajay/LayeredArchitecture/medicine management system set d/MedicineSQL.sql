--creating table for storing medicine details
create table MedicineDetails_032(MedicineID int primary key identity(1,1),MedicineName nvarchar(50),Type nvarchar(50),BatchNo nvarchar(50),Manufacturer nvarchar(50),ManufactureDate date,ExpiryDate date,Price float)

select * from MedicineDetails_032
----------------------------------------------------
--creating store procedure for add ing details
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE AddMedicine_032
(
@MedicineName nvarchar(50),
@Type nvarchar(50),
@BatchNo nvarchar(50),
@Manufacturer nvarchar(50),
@ManufactureDate date,
@ExpiryDate date,
@Price float)
AS
BEGIN
	SET NOCOUNT ON;

	insert into MedicineDetails_032(MedicineName,Type,BatchNo ,Manufacturer,ManufactureDate,ExpiryDate,Price)
	values(@MedicineName,@Type,@BatchNo,@Manufacturer,@ManufactureDate,@ExpiryDate,@Price)
END
GO
---------------------------------------------------------------
--creating stored procedure for diplaying details where type =tablet
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DisplayMedicine_032

AS
BEGIN
	SET NOCOUNT ON;

        select * from MedicineDetails_032 where Type='Tablet'
END
GO


select * from MedicineDetails_032