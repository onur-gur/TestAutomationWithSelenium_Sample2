Feature: Hepsiburada
	Hepsiburada sitesine gidilir ürün aratılır ürün seçilir,ürün detay sayfasına gidilir,
	yorum yapılır

@mytag
Scenario: AddComment
	* 'https://www.hepsiburada.com/' adresine gidilir
	* 'İphone' aratılır
	* Ürün Detay Safyasına gidilir
	* Yorumlar tabına gidilir eğer yorumlar tabında yorum yoksa test sonlandırılır
	* Gelen ilk yorum içerisinde Evet butonuna basılır
	* 'Teşekkür Ederiz.' yazısı görülür