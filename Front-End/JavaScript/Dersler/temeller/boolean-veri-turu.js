// *************Boolean Veri Türü **********************

let isActive = true // 1
isActive = false // 0
console.log(isActive)

let userName ;
let isUserName = Boolean(userName)
console.log(isUserName)

Boolean("11")  //true
Boolean("0") //true
Boolean(" ") // false

userName = "Mehmet"
console.log("user name :"+ userName +"  "+ Boolean(userName) )