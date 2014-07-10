--declare @Id uniqueidentifier = 'eaedcbbe-1246-47b1-8881-f21c67c89c5b'

select * from Customer where Id != @Id

