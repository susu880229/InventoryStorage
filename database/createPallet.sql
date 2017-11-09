use public_storage
create table Pallet
(
Pallet_id int not null,
Pallet_capacity int,
Pallet_require int,
Pallet_price decimal(5,2),
primary key (Pallet_id)
);
