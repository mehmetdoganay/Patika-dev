let userName = prompt("Welcome, please enter your name. ")
document.querySelector(".name").innerHTML = userName

if(userName == ""){
    alert("you forgot to enter the name.")
    window.location.reload(false)
}
    
//while(userName == "")
  //  alert("you forgot to enter the name.")
    //userName = prompt("Welcome, please enter your name. ")
    //window.location.reload(false)



var clock;
function now() {
    var nowClock = new Date()

    var dayHour = nowClock.getHours()
    var dayMin = nowClock.getMinutes()
    var daySec = nowClock.getSeconds()

    clock = dayHour + ':' + ((dayMin < 10 ) ? '0' :  "" ) +dayMin + ':' + ((daySec < 10) ? '0' : "" ) + daySec
    
    document.querySelector(".dateHour").innerHTML = clock

    setTimeout("now()",1000)

}

let today = new Date()
let localDay = new Array(7)

 localDay[0] = "Sunday";
 localDay[1] = "Monday";
 localDay[2] = "Tuesday";
 localDay[3] = "Wednesday";
 localDay[4] = "Thursday";
 localDay[5] = "Friday";
 localDay[6] = "Saturday";

 let n = localDay[today.getDay()];

document.querySelector(".dateDay").innerHTML = n







