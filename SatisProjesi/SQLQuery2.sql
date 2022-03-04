-- BU TR�GGER B�R SATI� ��LEM� YAPILDI�INDA 
--tblSatislar tablosuna sat�� kayd� yap�ld���nda
--tblUrunler tablosundan stok miktar�nda azaltma yapt�ran
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