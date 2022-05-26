// ************** CSS CLASS eklemek ********************

let greating = document.querySelector("#greating") // greating adında ki id'yi seçtik ve greating değişkenine atadık
greating.classList.add("text-primary")  // greating id'sine sahip olan ögeye bir class oluşturduk
console.log(greating.classList)

let titleID = document.querySelector("#title")

titleID.classList.add("style","text","btn") // çoklu class ekleme

console.log(titleID.classList.item(1)) // 1. indeksteki classı yazdırdık

titleID.classList.remove("text") // text classını sildik

console.log(titleID.classList.length) // toplam class sayısını yazdırdık

console.log(titleID.classList.contains("style")) // varmı yokmu / true false döner

if(titleID.classList.contains("style") == true) // contains ile style adında class varmı varmı sorduk 
{
    titleID.classList.toggle("style") // toggle ise style adında bir değişken varsa siler yoksa ise ekler
    console.log(titleID)
    titleID.classList.toggle("addToggle") // addTogle adında bir değişken yok ve ekleme yaptık
    console.log(titleID)
} 



