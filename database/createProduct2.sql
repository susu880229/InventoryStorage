use public_storage
create table Product2
(
product_id int IDENTITY(1,1) not null,
description varchar(25),
name varchar(25),
quantity int,
unit varchar(20),
length decimal(5,2),
width decimal(5,2),
height decimal(5,2),
check_in_date date,
check_out_date date,
weight decimal(5,2),
expire_date date,
order_id int,
location_id int,
primary key(product_id),
foreign key (order_id) references Orders (order_id),
foreign key (location_id) references Location (location_id)
    
);
