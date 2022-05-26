// *****************DOM ETKİNLİKLERİ*****************

const title = document.querySelector(".title")
title.addEventListener("mouseover",getMouseover)

//Mouse Üstüne geldiğinde
function getMouseover() {
    title.innerHTML = "Mouseover Etkinliği çalışıyor"
    this.style.color == "red" ? this.style.color = "black" : this.style.color = "red" 
}

// Tıklama Fonksiyonu
function getClick() {
    title.innerHTML = "Click Etkinliği çalışıyor"
    alert("Tıklama İşlemi gerçekleşti")
}