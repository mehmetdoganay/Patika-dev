// *******************DOM içerisinden öğre seçimi **********************

// with getElement..
let title = document.getElementById('title')
title.innerHTML = "Title değiştirildi"
console.log(title.innerHTML)

// with  querySelector 
let link = document.querySelector("ul>li>a")
link.innerHTML += " değiştirildi !"
console.log(link.innerHTML)
link.style.color = "yellow" // a elementinin title'ını sarı renk ile değiştirdik

link.classList.add("btn") // a elementine btn classı eklendi