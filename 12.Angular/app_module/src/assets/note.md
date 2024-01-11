# Angular Notları

## Angular CLI Komutları
1) HTML Sayfası oluşturmak istiyorsak component oluşturmalıyız, component oluşturmak için 
```typescript
    ng generate component component_adi 
    ng g c component_adi 
```
yazılır.
Önemli Not: Bu kod çalıştırıldığı klasörde işlem yapacağından dolayı nereye oluşturmak istiyorsak mutlaka orada bu kod çalıştırılmalı

Kod çalıştırıltan sonra 1 klasör ve 4 dosya oluşturulur. Oluşturulan Component class'ı da app.Module declarations kısmına bağımlılık için eklenir. Bu sayede o kısımda bulunan diğer class ve componentler bu yapıyı kullanabilir.

2) Eğer bir HTML attribute'ü oluşturmak istersek o zaman directive oluşturmalıyız, directive oluşturmak için
```typescript
    ng generate directive directive_adi 
    ng g d directive_adi 
```
Directive'ler ile eklenen attributeler sadece eventler aracılığı ile tetiklenebilir. İsterseniz mevcut element de yaklanıp üzerinde işlem yapılabilir.

3) HTML tarafında kullandığımız değişkenleri işlemek istersek o aman pipe oluşturmalıyız, pipe oluşturmak için
```typescript
    ng generate pipe pipe_adi
    ng g p pipe_adi
```

- Pipe kullanmak için işlemek istediğimiz verinin yanına "| => pipe işareti" bu işareti yapıyoruz. Arkasına pipe name'ini yazıyoruz. Ve isteresek parametreler gönderebiliyoruz

### Angular tarafından bize verilen pipe'lar
- uppercase => bu pipe Angular tarafından bize veriliyor. Kullanıldığı string değerini büyütür
- lowercase => bu pipe Angular tarafından bize veriliyor. Kullanıldığı string değerini küçültür
- titlecase => bu pipe Angular tarafından bize veriliyor. Kullanıldığı string değerini her kelimenin baş harfi büyük kalanları küçük olmasını sağlar
- date => bu pipe Angular tarafından bize veriliyor. Tarih değerlerini istediğimiz tarih formatında görüntüleyebilmemizi sağlıyor
- currency => bu pipe Angular tarafından bize veriliyor. Para değerlerini istediğimiz para formatında görüntüleyebilmemizi sağlıyor
- async => bu pipe Angular tarafından bize veriliyor. Asenkron yapılarının takip edilmiş sonuçlarını yakalar

4) İstersek ek bir Module ekleyerek yapıya dahil edeceğimiz başka Module ya da Component | Directive | Pipe'ları yük olarak o Module içerisine verebiliyoruz. Exports propertysiylede paylaşıma geri açabiliyoruz.
```typescript
    ng generate module example
    ng g m example
```

5) İstersek tüm yapıda kullanabileceğimiz paylaşım classları yani Service'ler oluşturabiliyoruz. Bu serviceler içerisinde property ve metot barındırabiliyor. Uygulamanın açıldığı browserun memorysini kullanır. O sayfa yenilenene ya da kapatılana kadar içerisinde değeri muhafaza eder.
```typescript
    ng generate service product
    ng g s product
```

