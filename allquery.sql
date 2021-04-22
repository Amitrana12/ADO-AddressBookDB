USE [DBAddressBookADO]
GO

/****** Object:  Table [dbo].[AddreshBookADo]    Script Date: 18-04-2021 01:20:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AddreshBookADo](
	[first_name] [varchar](30) NOT NULL,
	[last_name] [varchar](30) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[City] [varchar](20) NULL,
	[state] [varchar](20) NULL,
	[zip] [int] NULL,
	[phone_number] [varchar](10) NOT NULL,
	[email] [varchar](20) NOT NULL,
	[addressbook_name] [varchar](20) NOT NULL,
	[addressbook_type] [varchar](20) NOT NULL
) ON [PRIMARY]
GO

insert into AddreshBookADo values
('Anil','Rana','Awas colony.','Rishikesh','UK',265356,'8979325425','Anil@gmail.com','Addressbook3','Friends'),
('Sunil','Semwal','kali mandir.','Ruderperyag','UK',548512,'9876543210','Sunil@gmail.com','Addressbook2','family'),
('chaman','Dhiyani','puliya.','Devperyag','UK',546522,'8976543210','chaman@gmail.com','Addressbook3','Profession'),
('Raman','Rawat','jhanda choak.','Kotdwar','UK',985151,'8755423025','Raman@gmail.com','Addressbook1','family'),
('Saurabh','gupta',' ghantagher.','Dehradun','UK',26232,'7856235620','Saurabh@gmail.com','Addressbook2','family'),
('Gaurabh','Rawat','kotewser.','Ruderperyag','UK',895154,'9875141545','Gaurabh@gmail.com','Addressbook3','family');


UPDATE AddreshBookADo SET state='Rajasthan' where city='Rishikesh';

select * from AddreshBookADo


create procedure Sp_AddContactDetails
(
    @first_name varchar(30),
	@last_name varchar(30),
	@address varchar(50), 
	@city varchar(20),
	@state varchar(20),
	@zip int=NULL,
	@phone_number varchar(10) ,
	@email varchar(20),
	@addressbook_name varchar(20) ,
	@addressbook_type varchar(20)
	)
	as begin 
	insert into AddreshBookADo values
	( @first_name,@last_name, @address, @city, @state, @zip, @phone_number, @email,  @addressbook_name,@addressbook_type);
	end 


	create procedure Sp_DeletContactDetails
	(@first_name varchar(20))
	as
	BEGIN  
            DELETE FROM AddreshBookADo
            WHERE first_name = @first_name  
        END  
