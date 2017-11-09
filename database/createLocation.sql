use public_storage
create table Location
(
location_id int IDENTITY(1,1) NOT NULL,
asile_id int,
Pallet_id int,
current_volumn int DEFAULT 0 NOT NULL,
current_weight int DEFAULT 0 NOT NULL,
foreign key (asile_id) references Asile (asile_id),
foreign key (Pallet_id) references Pallet (Pallet_id),
primary key (location_id)
);
