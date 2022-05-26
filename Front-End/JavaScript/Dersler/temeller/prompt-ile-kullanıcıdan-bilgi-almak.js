let fullName = prompt("lütfen adınızı giriniz :")
console.log(fullName)

let yazdir = document.getElementById("title")

yazdir.innerHTML = `${yazdir.innerHTML} <small style= "font-size:46px;">${fullName}</small>`