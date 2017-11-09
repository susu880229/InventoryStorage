use public_storage
Create table Client2
(
client_id INT IDENTITY(1,1) NOT NULL ,
client_name VARCHAR( 25 ) ,
client_phone VARCHAR( 25 ) ,
client_email VARCHAR( 30 ) ,
client_address VARCHAR( 40 ) ,
PRIMARY KEY ( client_id )
);
