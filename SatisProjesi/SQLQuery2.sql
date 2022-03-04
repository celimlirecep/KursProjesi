-- BU TRÝGGER BÝR SATIÞ ÝÞLEMÝ YAPILDIÐINDA 
--tblSatislar tablosuna satýþ kaydý yapýldýðýnda
--tblUrunler tablosundan stok miktarýnda azaltma yaptýran
USE SatisProjesi
GO
CREATE TRIGGER trgUrunStokGuncelle ON tblSatislar
FOR INSERT AS 
BEGIN
	DECLARE @urunID INT, @satisAdeti INT 
	SELECT @urunID=UrunID,@satisAdeti=SatisAdeti
	FROM INSERTED --INSERT tablosu
	UPDATE tblUrunler SET StokMiktari = StokMiktari - @satisAdeti
	WHERE ID=@urunID
END

USE SatisProjesi
GO
DISABLE TRIGGER trgUrunStokGuncelle ON tblSatislar

USE SatisProjesi
GO
ENABLE TRIGGER trgUrunStokGuncelle ON tblSatislar