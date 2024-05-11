## ⛓️ Chain Of Responsibility

#### Bu projemizde bir diğer tasarım deseni olan Chain Of Responsibility hakkında fikir edinerek,çalışma prensibini,avantajlarını ve proje içerisinde nasıl kullanıldığına dair bilgi edindik.

#### ℹ️ Chain Of Responsibility : Bir isteği sonuca ulaştırabilmek için, bir dizi (ardı ardına sıralanmışzincir halkası gibi ) karar mekanizması boyunca iletmemizi ve en uygun karar mekanizmasının karar vermesi ile çıktı oluşturmasına olanak sağlar.
Her halkanın kendine ait bir karar mekanızması vardır ve işlemi kendine özgü değerlendirerek sonucu bir sonraki halkaya aktarabilir.Bu işlem, isteğe cevap verilemediği taktirde zincirin son halkasına kadar iletletilerek devam eder.

## ➕ Avantajları 
* Esneklik : Sisteme kolayca yeni halkalar eklenebilir veya çıkarılabilir. Çalışma prensibini kaybetmeden halkalar birbiri ile haberleşmeye devam edebilir.
* Geliştirilebilirlik : Halkalar kendi karar mekanizmalarını oluşturur ve  önceki veya sonraki halkaya sıkı bir bağlılık olmadığı için kod yazmak ve geliştirmek daha kolaydır.
* Hata Tespiti : Bir bütün değil, birbiri ile uyumlu parçalar halinde çalışan bu sistemde meydana gelebilecek hatalar ilgili zincirin tespiti ve giderilmesi için avantaj sağlar.

![Ekran görüntüsü 2024-05-11 125044](https://github.com/gozgirfaruk/Chain-Of-Responsibility-Design-Pattern/assets/125920944/b88b4ffa-d688-4d67-a6ab-b02889441b42)

![Screenshot_1](https://github.com/gozgirfaruk/Chain-Of-Responsibility-Design-Pattern/assets/125920944/52174bdc-618d-47d7-8939-6a289cc0abb1)
