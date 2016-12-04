
--create table User_Info 
--(UserID varchar(20), EmailID varchar(40), Password varchar(40), PhoneNumber varchar(20), AddressID varchar(20), RoleID varchar(20))

select * from User_Info

--create table Role (ID varchar(20), Roles varchar(40))

select * from Role

--Create table Address 
--(AddressID varchar(20), SocietyName varchar(40), BuildingNumber varchar(20), FlatNo varchar(40), Landmark varchar(40), City varchar(40), State varchar(40) , Pincode varchar(20))

select * from Address

--Create Shop
 --create table Shop_Master 
 --(ShopID varchar(20),ShopName varchar(40),ShopDescription varchar(max),BannerImageID varchar(20),ShopRegNumber varchar(20),PincodeLoc varchar(10),ShopAddressID varchar(20),ShopOwnerID varchar(20))

 select * from Shop_Master 

 --Create table Shop_Service_Pincodes (ShopID varchar(20),PincodeServe varchar(10))

 select * from Shop_Service_Pincodes

 --Create table Shop_Service(ShopID varchar(20), ProductID varchar(20))

 select * from Shop_Service

 --Create table ProductID(ProductID varchar(20), Catagory varchar(20), SubCatagory varchar(20),Price decimal, Discount float,ShopID varchar(20),ProductImageID varchar(20),ProductDescription varchar(40),AvailableQty integer,Valid char(1))

 select * from ProductID

 --create table Image_Master(ImageID varchar(20),ImageString varchar(max))
 
 select * from Image_Master

PaymentStatusRef (1-Open (Debit to Buyer(-ve) and Credit to Seller(+ve)), 2-Settled (Buyer or Seller) )





Payment(OrderID, PaymentID, PaymentStatus, Amount, Credited, Debited )
PaymentStatus(PaymentID,UserID, Credit/Debit, Amount)
WalletMaster(UserID, Amount )
WalletMasterHistory(UserID, Amount, UpdateID, TimeStamp, Credit/Debit, OrderID)
Order(OrderID, ProductID, Amount, UserID, Discount, Comment, Timestamp, Status)
OrderStatusHistory(OrderID, ProductID, Amount, UserID, Discount, Comment, Timestamp, Status)

Seller(UserID, ShopID)