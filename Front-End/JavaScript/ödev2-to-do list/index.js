const inputDom = document.querySelector("#task")
const btnDom = document.querySelector("#liveToastBtn")
const listDom = document.querySelector("#list")
const btnDel = document.querySelector(".close")

btnDom.addEventListener("click",crtElement)

function crtElement () {
    const crtLi = document.createElement("li") // li elementi oluşturduk
    const crtSpan = document.createElement("span") // span tagı oluşturduk
    crtSpan.classList.add("close") // spana close adında class ekledik 
    crtSpan.innerHTML= "X" //spanın içinde X yazsın dedik
    crtLi.innerHTML = `<span> ${inputDom.value} </span>` // oluşturduğumuz li elemanı unputun değerini alsın dedik span içerisinde 
    crtLi.appendChild(crtSpan) // oluşturduğumuz li'ye oluşturuduğumuz spanı ekledik 
    listDom.appendChild(crtLi) // var olan list elemanına ise oluşturdğumuz li elemanını ekledik

}

btnDel.addEventListener("click",delElement)

function delElement () {
    
    const findUl = document.querySelector("#list")
    const findLi = document.querySelector(".close")
    findUl.removeChild(findLi)
}