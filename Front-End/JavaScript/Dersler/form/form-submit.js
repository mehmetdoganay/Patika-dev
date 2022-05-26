// formlarda name bildisi olmalı !!

let formDom = document.querySelector(".userForm")
formDom.addEventListener("submit",formSubmit)

function formSubmit(event) {
    event.preventDefault() // default işlemi engellendi
    console.log("işlem gerçekleşti")
    let nameInputDom = document.querySelector("#name")
    let passInputDom = document.querySelector("#pwd")
    console.log(nameInputDom.value,passInputDom.value) //value içerisine girilen bilgiyi verir
    localStorage.setItem("name",nameInputDom.value) // input değerini localStorage'a gönderdik
}

