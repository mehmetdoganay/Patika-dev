// ******************liste-icindeki-ogeye-ulasmak-veya-yeni-oge-olusturmak**********************

let lastChild = document.querySelector("ul#list>li:last-child") // son list elemanınını aldık
console.log(lastChild) 
lastChild.innerHTML = "Son li elemanı değişti"

let firstChild = document.querySelector("ul#list>li:first-child") // ilk list elemanınını aldık
console.log(firstChild) 
firstChild.innerHTML = "ilk li elemanı değişti"

let ulDOM = document.querySelector("ul#list") 
let liDOM = document.createElement("li")

liDOM.innerHTML = "oluşturduğumuz öge"

ulDOM.append(liDOM) // ul nin içerisine kendi oluşturduğumuz li elemanını ekledik

console.log(ulDOM.lastChild)  // artık son öge ekledğimiz öge

// ulDOM.prepend(liDOM)  //  burada ise prepend diyerek oluşturduğumuz ögeyi en başa ekleyebiliriz.