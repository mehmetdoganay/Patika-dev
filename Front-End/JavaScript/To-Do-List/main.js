// Listedeki elemanlara span eklemek  
var nodeList= document.getElementsByTagName("li");
for (let index = 0; index < nodeList.length; index++) {
   var span = document.createElement("span");
   var txt = document.createTextNode("X");
   span.className = "close"
   span.appendChild(txt);
   nodeList[index].appendChild(span);
}

// Eklenen spana silme fonksiyonu eklemek
var close = document.getElementsByClassName("close");
for (let index = 0; index < close.length; index++) {
    close[i].onclick = function() {
        var div = this.parentElement;
        div.style.display = "none";
    }
}

function newElement() {
    var li = document.createElement("li"); //li elemanı oluşturuldu.
    var inputValue = document.getElementById("task").value; // id task olan inputun değeri değişkene atandı
    var t = document.createTextNode(inputValue); // bir text oluşturup inputValue değişkeni texte atandı
    li.appendChild(t);
    
    if(inputValue === '') {
        alert("Herhangi Bir Not Girmediniz.!");
    } else {
        document.getElementById("list").appendChild(li);
    }
    document.getElementById("task").value = "";

    var nodeList= document.getElementsByTagName("li");
    for (let index = 0; index < nodeList.length; index++) {
    var span = document.createElement("span");
    var txt = document.createTextNode("X");
    span.className = "close"
    span.appendChild(txt);
    nodeList[index].appendChild(span);
    }
}



