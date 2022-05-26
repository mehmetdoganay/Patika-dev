//****************Number veri Türü*******************
let price = 100
let tax = 0.8
let priceTax = price * tax
let total = priceTax + price


console.log(
    "Fiyat: " +price,
    "Vergi oranı: " + tax, 
    "Toplam Vergi: " + priceTax,
    "Toplam Tutar: " + total
)

//Artirma ve azaltma işlemleri

let counter = 500 
counter ++;
counter +=1
console.log(counter)

counter--;
counter -=5
console.log(counter)

counter *= 10;
console.log(counter)

counter/=2;
console.log(counter)

// işlem onceliği 
console.log( 2 + 5 * 10)
console.log(( 2 + 5 ) * 10)

// us alma **:
console.log(2 * 2 * 2 * 2)
console.log(2 ** 4)

//yuvarlama işlemleri 
console.log("Aşağı yuvarlama :"+Math.floor(1.7))

console.log("Yukarı Yuvarlama "+ Math.ceil(2.2))

console.log("Yakına yuvarlama "+Math.round(3.3)) // 1.5 yukarı yuvarlar