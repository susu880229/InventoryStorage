use public_storage
create table Orders
(
order_id INT IDENTITY(1,1) NOT NULL ,
client_id INT,
bill DECIMAL( 6, 2 ) ,
PRIMARY KEY ( order_id ) ,
FOREIGN KEY ( client_id ) REFERENCES Client2( client_id )
);
