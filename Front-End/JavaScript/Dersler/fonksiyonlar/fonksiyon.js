// geriye değer döndürmeyen bir toplama işlemi yapan fonksiyon
function topla() {
    var a = 5
    var b = 9
    console.log(a+b)
}

// fonksiyonun çağırılması
topla()

// Değerleri parametre şeklinde verilen ve geriye değer döndüren bir fonksiyon
function toplaReturn(a,b) {
    return a+b
}

var sum =  toplaReturn(15,9) // fonsiyona 2 parametre girdik parameterler zorunlu !! 
console.log(sum) // fonksiyon değerini bir değişkene atıp consolda yazdırdık 

// fonksiyon içinde fonksiyon 
function getWrite(ad,soyad) {
    return `Merhaba ${ad} ${soyad}` // ad soyad parametre alan bir fonksiyon yazdık
}
// başka bir fonsiyonda ise değerleri kullanıcıdan aldığımız getWrite fonksiyonunu çağırdık
function getRead() {
    console.log("JavaScript Fonksiyonlar dersine hoşgeldiniz "+ getWrite(prompt("Adınız"),prompt("Soyadınız")))
}

getRead()

//Fat arrow fonskiyon 
//Tek satırlık fonksiyon oluşurulacaksa bu tür fonskiyon oluşturmak daha kullanışlı

const carpma = (a,b) =>  a*b
console.log(carpma(5,3))

// Örnek 

const getFilmList = list => { 

    list.forEach((series,index) => {
        console.log(`${index+1}, ${series}`)
    });
}

getFilmList(["Rick and Mort","Vikings","Sex Education","Game of Thrones"])

