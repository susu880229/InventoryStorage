use public_storage
insert into Location (asile_id, Pallet_id)
select a.asile_id, p.Pallet_id
from Asile a
CROSS JOIN Pallet p