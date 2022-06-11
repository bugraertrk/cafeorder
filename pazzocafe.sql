use pazzocafe;
CREATE TABLE IF NOT EXISTS URUNLER(
	ürün_ad varchar(64) PRIMARY KEY not null,
    URUN_ADI varchar(100) NOT NULL,
    MAAS int NOT NULL
    );
CREATE TABLE IF NOT EXISTS musteriler(
	NUMARA INT PRIMARY KEY NOT NULL,
	`AD SOYAD` VARCHAR(50) NOT NULL,
	MAİL VARCHAR(255)  not null,
    ADRES VARCHAR(255) not null,
    SEHİR VARCHAR(25) not null,
	TELEFON varchar(20)  not NULL
);
CREATE TABLE IF NOT EXISTS çalışanlar(
	NUMARA_ca INT PRIMARY KEY NOT NULL,
    `AD SOYAD` VARCHAR(50) NOT NULL,
    MAİL_ca VARCHAR(255)  not null,
    TELEFON_ca varchar(25) not NULL
);
CREATE TABLE IF NOT EXISTS siparisler(
	SIPARIS_NO INT PRIMARY KEY NOT NULL,
    ürün_ad varchar(16) null, 
    NUMARA int not null,
    NUMARA_ca int not null,
    adet int not null,
    tutar int not null,
    foreign key(ürün_ad) references URUNLER(ürün_ad),
    foreign key(NUMARA) references musteriler(NUMARA),
    foreign key(NUMARA_ca) references çalışanlar(NUMARA_ca)
);

    

DELIMITER $$
CREATE PROCEDURE Pazzo_MusteriEkle (
	id  	int,
    adsoy	varchar(50) ,
    tel 	varchar(20) ,
    mail 	varchar(255),
    adr 	varchar(255),
    sehir   varchar(25)
)
BEGIN
	INSERT INTO musteriler(NUMARA, `AD SOYAD`, TELEFON, MAİL, ADRES, SEHİR)
    VALUES 	(id, adsoy, tel, mail, adr, sehir);
END $$
DELIMITER ;
    
call Pazzo_MusteriEkle (1, 'Ahmet Buğra Ertürk', 0539-838-04-07, 'bugra-ertrk@hotmail.com','Aladağ mahallesi', 'Bartın/Merkez');
select * from musteriler;
    
    
DELIMITER $$
CREATE PROCEDURE Pazzo_MusteriGuncelle (
	id  	int ,
    adsoy	varchar(50) ,
    tel 	varchar(20) ,
    mail 	varchar(255),
    adr 	varchar(255),
    sehir   varchar(25)
)
BEGIN
	UPDATE musteriler
    SET 
        `AD SOYAD`		= adsoy,
		TELEFON		 	= tel,
		MAİL		 	= mail,
		ADRES		 	= adr,
        SEHİR			= sehir
	WHERE 
    	NUMARA  		= id;
END $$
DELIMITER ;

call Pazzo_MusteriGuncelle(1, 'Buğra Ertürk', 0555-555-55-55, 'mail@mail.com', 'Kepez', 'Antalya');
select * from musteriler;

DELIMITER $$
CREATE PROCEDURE Pazzo_MusteriSil (
	id  	int
)
BEGIN
	DELETE FROM musteriler
	WHERE  	NUMARA  = id;
END $$
DELIMITER ;

call Pazzo_MusteriSil(1);
select * from musteriler;

DELIMITER $$
CREATE PROCEDURE Pazzo_MusterilerHepsi ()
BEGIN
	SELECT 
		NUMARA 			as ID,
		`AD SOYAD` 		as AdıSoyadı,
		TELEFON			as Telefon, 
		MAİL 			as Mail,
		ADRES 			as Adres,
        SEHİR 			as Şehir
    FROM musteriler;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE Pazzo_MusteriBul (
	filtre  varchar(32) 
)
BEGIN
	SELECT * FROM musteriler
    WHERE 
		`AD SOYAD`		LIKE  CONCAT('%',filtre,'%') OR
		TELEFON 		LIKE  CONCAT('%',filtre,'%') OR
		MAİL 			LIKE  CONCAT('%',filtre,'%') OR
		ADRES 			LIKE  CONCAT('%',filtre,'%') OR
        SEHİR 			LIKE CONCAT('%',filtre,'%');
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE Pazzo_UrunlerHepsi ()
BEGIN
	SELECT * FROM URUNLER;
END $$
DELIMITER ;

--------------------------------------------
DELIMITER $$
CREATE PROCEDURE Pazzo_UrunEkle (
	id			varchar(64)  ,
    ad 			varchar(250) ,
	fiyat 		int		 
)
BEGIN
	INSERT INTO URUNLER(ürün_ad, URUN_ADI, MAAS)
    VALUES 	(id, ad, fiyat);
END $$
DELIMITER ;

call Pazzo_UrunEkle('absdf', 'urun1', 123);
select * from URUNLER;



DELIMITER $$
CREATE PROCEDURE Pazzo_UrunSil (
	id			varchar(64)
    )
BEGIN
	DELETE FROM URUNLER
	WHERE ürün_ad  = id;
END $$
DELIMITER $$;

call Pazzo_UrunSil('ab');
select * from URUNLER;




DELIMITER $$
CREATE PROCEDURE Pazzo_CalisanEkle (
	id  	int,
    adsoy	varchar(50) ,
    tel 	varchar(25) ,
    mail 	varchar(255)
)
BEGIN
	INSERT INTO çalışanlar(NUMARA_ca, `AD SOYAD`, TELEFON_ca ,MAİL_ca)
    VALUES 	(id, adsoy, tel, mail);
END $$
DELIMITER $$;
    
call Pazzo_CalisanEkle (5, 'Ahmet Buğra Ertürk', 0539-838-04-07, 'bugra-ertrk@hotmail.com');
select * from çalışanlar;

DELIMITER $$
CREATE PROCEDURE Pazzo_CalisanlarHepsi ()
BEGIN
	SELECT * FROM çalışanlar;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE Pazzo_CalisanGuncelle (
	id  	int ,
    adsoy	varchar(50) ,
    tel 	varchar(20) ,
    mail 	varchar(255)
)
BEGIN
	UPDATE çalışanlar
    SET 
        `AD SOYAD`		= adsoy,
		TELEFON_ca		= tel,
		MAİL_Ca		 	= mail
	WHERE 
    	NUMARA_ca  		= id;
END $$
DELIMITER $$;

call Pazzo_CalisanGuncelle(1, 'Buğra Ertürk', 0555-555-55-55, 'mail@mail.com');
select * from çalışanlar;


DELIMITER $$
CREATE PROCEDURE Pazzo_CalisanSil (
	id  	int
)
BEGIN
	DELETE FROM çalışanlar
	WHERE  	NUMARA_ca  = id;
END $$
DELIMITER $$;

call Pazzo_CalisanSil(1);
select * from çalışanlar;


------------------------------------------
DELIMITER $$
CREATE PROCEDURE Pazzo_MusteriSiparisler(
	id			int  
)
BEGIN
	SELECT * FROM siparisler
    WHERE SIPARIS_NO = id;
END $$
DELIMITER $$;

------------------------------------------------
DELIMITER $$
CREATE PROCEDURE Pazzo_UrunSiparis(
	id			varchar(64) 
)
BEGIN
	SELECT * FROM URUNLER
    WHERE ürün_ad = id;
END $$
DELIMITER $$;



---------------------------------------------------------------------------------
DELIMITER $$
CREATE PROCEDURE Pazzo_SiparisEkle (
	cid     int,
    sid		int ,
	mid		int ,
	uid		varchar(64) ,    
    adet 	int 	,
	tutar 	int 		
)
BEGIN
	INSERT INTO siparisler (NUMARA_ca,SIPARIS_NO, NUMARA,ürün_ad, adet, tutar)
    VALUES 	(cid, sid, mid, uid, adet, tutar);
END $$
DELIMITER $$;

call Pazzo_SiparisEkle(1, 1, 1, 'ur', 12, 120);
select * from siparisler;


DELIMITER $$
CREATE PROCEDURE Pazzo_SiparisSil (
	id  	int
)
BEGIN
	DELETE FROM siparisler
	WHERE  	SIPARIS_NO  = id;
END $$
DELIMITER $$;


DELIMITER $$
CREATE PROCEDURE Pazzo_SiparisDetay (
)
BEGIN
SELECT   
		s.SIPARIS_NO,
        m.NUMARA,
        u.ürün_ad,
        CONCAT(`AD SOYAD` ) as `Müşteri Ad Soyad`,
        URUN_ADI as `Ürün`,
        MAAS as `Birim Fiyat`
       
FROM  	musteriler m inner join  siparisler s 
	on m.NUMARA = s.NUMARA 
		inner join urunler u on s.ürün_ad = u.ürün_ad;
END $$
DELIMITER ;
