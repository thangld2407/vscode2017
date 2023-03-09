use formpk
go

INSERT INTO dbo.Account VALUES(1, 'admin', 'admin', 0);
INSERT INTO dbo.Account VALUES(1, 'operator', 'operator', 1);

select * from Account;



use Formbka
go

SELECT * FROM Account

UPDATE Account SET password = 'admin'  WHERE username = 'admin'

CREATE TABLE Recipe (
    totalKG int,
    xiMang int,
	cat int,
	troBay int,
	khoang int,
	phuGia1 int,
	phuGia2 int,
	phuGia3 int,
	isDefault int,
);

DROP TABLE Recipe

SELECT * FROM Recipe

INSERT INTO Recipe VALUES (200, 48, 48, 48, 48, 3,3,2, 0)