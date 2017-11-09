use public_storage
create table Asile
(
    asile_id int IDENTITY(1,1) not null,
    asile_name varchar(25),
    primary key (asile_id)
);
