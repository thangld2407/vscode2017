use formpk
go

INSERT INTO dbo.Account VALUES(1, 'admin', 'admin', 0);
INSERT INTO dbo.Account VALUES(1, 'operator', 'operator', 1);

select * from Account;