
// Dizi Oluşturduk
let numbers = [1,4,5,7,4,3,7,8]
let namesMale = ["Mehmet","Ömer","Ahmet","Canberk"]
let namesFamela = ["Elif","Ayşe","İdal"]

//numbers dizisine unshift() metodu ile namesFamela dizisini ekledik 
// dizi tek bir dizi elemanı gibi eklenir !
numbers.unshift(namesFamela)  
console.log(numbers)
console.log(numbers.length) 
console.log(numbers[0]) // dizinin ilk elemanını aldık O da bir dizidir
console.log(numbers[0] [0]) //Dizinin ilk elemanı bir dizi olduğu için dizin içindeki dizinin ilk elemanını aldık

// push metodu  eleman ekler. sona!
numbers.push("Deniz")
console.log(numbers)

// pop() dizideki son elemanı siler
numbers.pop()
console.log("pop()" +numbers)

// includes() Dizinin içindeki elemanı kontrol eder var mı yok mu  ? true false döner
console.log("includes() " + numbers[0] [0].includes("Elif"))  // true
console.log("includes() " + numbers.includes(20)) // false

// slice() bir dizinin belli bir ögesini kopyalar
let pcDonanim = ["fare","mouse","kulaklık"]

let pcParca = ["Monitör","Kasa"]
pcParca = pcDonanim.slice(0,2) // 0. index ile 1.index dahil dizi ögelerini kopyalar
console.log(pcParca) // !!! Ekleme yaptığın diğer dizi elemanlarını siler
 

// join("değer") girilen değer ile birlikte tüm diziyi tek bir indexte toplam birleştirir 

let kasaDonanim = ["Ekran kartı","işlemci","RAM",true,22]
console.log("join() " +kasaDonanim + "//" + kasaDonanim[0]) 
let kasaDonanim2 = kasaDonanim.join("") 
console.log("join() " + kasaDonanim2 + "//"+ kasaDonanim2[0]) 

// concat() dizileri birleştirip tek dizi haline getirir
let yiyecekler = ["pasta", "baklava", "puding"]
let icecekler = ["su", "kahve"]

let menu = yiyecekler.concat(icecekler)
console.log("concat() " + menu)

// foreach() dizideki eleman kadar döngü oluşturur
let markalar = ["apple","microsoft","patika","kodluyoruz"]

markalar.forEach((element,elementIndex) => {
    console.log("forech() "+ element + " " + elementIndex)
});

// map() foreach gibi bir dizinin elemanı kadar bir döngü oluşturur ama map farklı bir dizinde tutar
let sayılar =  [1,2,3,4,5,6,7]

let sayılarOnKati = sayılar.map(function(sayi) {
    return sayi*10
})

console.log(sayılar) // aynı kalır
console.log("map() " + sayılarOnKati) // yeni dizi